using System;
using System.Windows.Forms;

namespace TestHelpers.CodeGenerator
{
    public partial class UserControlFactoryMethodGenerator : UserControl
    {
        public UserControlFactoryMethodGenerator()
        {
            InitializeComponent();
        }

        private void textBoxInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (checkBoxGenerateOnPaste.Checked == false) return;

            if (IsPasteCommand(e))
                GenerateCode();

            static bool IsPasteCommand(KeyEventArgs e)
            {
                return e.Control && e.KeyValue == 86;
            }
        }

        private void GenerateCode()
        {
            if (!string.IsNullOrWhiteSpace(textBoxInput.Text))
            {
                Cursor = Cursors.WaitCursor;
                textBoxInput.ReadOnly = true;
                var result = DynamicTypeCompiler.GenerateCode(textBoxInput.Text);
                if (result.Success)
                {
                    textBoxInput.Clear();
                    textBoxInput.Focus();

                    if (checkBoxCopyOutputToClipboard.Checked)
                    {
                        Clipboard.SetText(result.Output);
                    }
                }
                textBoxOutput.Text = result.Output;
                textBoxInput.ReadOnly = false;
                Cursor = Cursors.Default;
            }
            else
            {
                textBoxOutput.Text = "The input is empty. Paste the class you want to generate a factory method for...";
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxInput.Clear();
            textBoxOutput.Clear();
            textBoxInput.Focus();
        }

        private void buttonGenerateFactoryMethod_Click(object sender, EventArgs e)
        {
            GenerateCode();
        }
    }
}
