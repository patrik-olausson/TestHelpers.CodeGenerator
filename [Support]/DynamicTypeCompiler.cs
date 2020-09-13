using System;
using System.IO;
using System.Linq;
using System.Runtime.Loader;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.Text;

namespace TestHelpers.CodeGenerator
{
    public class CodeGenerationResult
    {
        public bool Success { get; }
        public string Output { get; }

        public CodeGenerationResult(bool success, string output)
        {
            Success = success;
            Output = output;
        }
    }

    public class DynamicTypeCompiler
    {
        public static CodeGenerationResult GenerateCode(string inputSourceCode)
        {
            string codeToCompile;

            try
            {
                codeToCompile = Validate(inputSourceCode);
            }
            catch (Exception e)
            {
                return new CodeGenerationResult(false, e.Message);
            }

            using var peStream = new MemoryStream();
            var result = CompileAndEmitIntoAssembly(codeToCompile, peStream);

            var sb = new StringBuilder();
            if (result.Success)
            {
                var types = GetTypesFromCompiledAssembly(peStream);
                foreach (var type in types)
                {
                    sb.AppendLine(FactoryMethodGenerator.CreateForType(type));
                }
            }
            else
            {
                sb.AppendLine("*** Unable to generate code due to compilation error(s) ***");
                var failures = result.Diagnostics.Where(d => d.IsWarningAsError || d.Severity == DiagnosticSeverity.Error);
                foreach (var failure in failures)
                {
                    sb.AppendLine($"{failure.Id}: {failure.GetMessage()}");
                }
            }

            return new CodeGenerationResult(result.Success, sb.ToString());
        }

        private static string Validate(string inputSourceCode)
        {
            if (string.IsNullOrWhiteSpace(inputSourceCode))
                throw new ArgumentException("You must specify an input");

            if (!inputSourceCode.Contains("using System"))
                return $"namespace TestHelpers.CodeGenerator {{ using System; {inputSourceCode} }}";

            return inputSourceCode;
        }

        private static Type[] GetTypesFromCompiledAssembly(Stream peStream)
        {
            peStream.Seek(0, SeekOrigin.Begin);
            var assemblyLoadContext = new CustomAssemblyLoadContext();
            var assembly = assemblyLoadContext.LoadFromStream(peStream);
            var types = assembly.GetTypes();
            return types;
        }

        private static EmitResult CompileAndEmitIntoAssembly(
            string sourceCode, 
            Stream peStream,
            string assemblyName = "Temp.dll")
        {
            var codeString = SourceText.From(sourceCode);
            var options = CSharpParseOptions.Default.WithLanguageVersion(LanguageVersion.CSharp9);
            var parsedSyntaxTree = SyntaxFactory.ParseSyntaxTree(codeString, options);

            var references = new MetadataReference[]
            {
                MetadataReference.CreateFromFile(typeof(object).Assembly.Location),
                MetadataReference.CreateFromFile(typeof(System.Runtime.AssemblyTargetedPatchBandAttribute).Assembly.Location),
                MetadataReference.CreateFromFile(typeof(Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo).Assembly.Location),
            };

            var compilation = CSharpCompilation.Create(
                assemblyName,
                new []{  parsedSyntaxTree },
                references: references,
                options: new CSharpCompilationOptions(
                    OutputKind.DynamicallyLinkedLibrary,
                    optimizationLevel: OptimizationLevel.Release,
                    assemblyIdentityComparer: DesktopAssemblyIdentityComparer.Default));

            return compilation.Emit(peStream);
        }

        private class CustomAssemblyLoadContext : AssemblyLoadContext
        {

        }
    }
}