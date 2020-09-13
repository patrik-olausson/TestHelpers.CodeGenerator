namespace TestHelpers.CodeGenerator
{
    partial class FormFactoryMethodGenerator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFactoryMethodGenerator));
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.buttonGenerateFactoryMethod = new System.Windows.Forms.Button();
            this.buttonClearFields = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxCopyOutputToClipboard = new System.Windows.Forms.CheckBox();
            this.checkBoxGenerateOnPaste = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInput.Location = new System.Drawing.Point(12, 27);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput.Size = new System.Drawing.Size(776, 68);
            this.textBoxInput.TabIndex = 0;
            this.textBoxInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxInput_KeyUp);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutput.Location = new System.Drawing.Point(12, 154);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(776, 346);
            this.textBoxOutput.TabIndex = 1;
            // 
            // buttonGenerateFactoryMethod
            // 
            this.buttonGenerateFactoryMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenerateFactoryMethod.Location = new System.Drawing.Point(588, 506);
            this.buttonGenerateFactoryMethod.Name = "buttonGenerateFactoryMethod";
            this.buttonGenerateFactoryMethod.Size = new System.Drawing.Size(200, 31);
            this.buttonGenerateFactoryMethod.TabIndex = 3;
            this.buttonGenerateFactoryMethod.Text = "Generate factory method";
            this.buttonGenerateFactoryMethod.UseVisualStyleBackColor = true;
            this.buttonGenerateFactoryMethod.Click += new System.EventHandler(this.buttonGenerateFactoryMethod_Click);
            // 
            // buttonClearFields
            // 
            this.buttonClearFields.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearFields.Location = new System.Drawing.Point(473, 506);
            this.buttonClearFields.Name = "buttonClearFields";
            this.buttonClearFields.Size = new System.Drawing.Size(109, 31);
            this.buttonClearFields.TabIndex = 2;
            this.buttonClearFields.Text = "Clear";
            this.buttonClearFields.UseVisualStyleBackColor = true;
            this.buttonClearFields.Click += new System.EventHandler(this.buttonClearFields_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input (DTO with simple data types)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output (factory method for DTO)";
            // 
            // checkBoxCopyOutputToClipboard
            // 
            this.checkBoxCopyOutputToClipboard.AutoSize = true;
            this.checkBoxCopyOutputToClipboard.Checked = true;
            this.checkBoxCopyOutputToClipboard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCopyOutputToClipboard.Location = new System.Drawing.Point(12, 506);
            this.checkBoxCopyOutputToClipboard.Name = "checkBoxCopyOutputToClipboard";
            this.checkBoxCopyOutputToClipboard.Size = new System.Drawing.Size(235, 19);
            this.checkBoxCopyOutputToClipboard.TabIndex = 5;
            this.checkBoxCopyOutputToClipboard.Text = "Automatically copy output to clipboard";
            this.checkBoxCopyOutputToClipboard.UseVisualStyleBackColor = true;
            // 
            // checkBoxGenerateOnPaste
            // 
            this.checkBoxGenerateOnPaste.AutoSize = true;
            this.checkBoxGenerateOnPaste.Checked = true;
            this.checkBoxGenerateOnPaste.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGenerateOnPaste.Location = new System.Drawing.Point(14, 100);
            this.checkBoxGenerateOnPaste.Name = "checkBoxGenerateOnPaste";
            this.checkBoxGenerateOnPaste.Size = new System.Drawing.Size(234, 19);
            this.checkBoxGenerateOnPaste.TabIndex = 6;
            this.checkBoxGenerateOnPaste.Text = "Automatically start generation on Paste";
            this.checkBoxGenerateOnPaste.UseVisualStyleBackColor = true;
            // 
            // FormFactoryMethodGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.checkBoxGenerateOnPaste);
            this.Controls.Add(this.checkBoxCopyOutputToClipboard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClearFields);
            this.Controls.Add(this.buttonGenerateFactoryMethod);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFactoryMethodGenerator";
            this.Text = "TestHelpers -Code Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button buttonGenerateFactoryMethod;
        private System.Windows.Forms.Button buttonClearFields;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxCopyOutputToClipboard;
        private System.Windows.Forms.CheckBox checkBoxGenerateOnPaste;
    }
}

