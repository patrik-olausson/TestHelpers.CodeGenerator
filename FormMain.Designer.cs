
namespace TestHelpers.CodeGenerator
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.userControlFactoryMethodGenerator1 = new TestHelpers.CodeGenerator.UserControlFactoryMethodGenerator();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.userControlEncoding1 = new TestHelpers.CodeGenerator.UserControlEncoding();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1026, 787);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.userControlFactoryMethodGenerator1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1018, 759);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Factory methods";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // userControlFactoryMethodGenerator1
            // 
            this.userControlFactoryMethodGenerator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlFactoryMethodGenerator1.Location = new System.Drawing.Point(3, 3);
            this.userControlFactoryMethodGenerator1.Name = "userControlFactoryMethodGenerator1";
            this.userControlFactoryMethodGenerator1.Size = new System.Drawing.Size(1012, 753);
            this.userControlFactoryMethodGenerator1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.userControlEncoding1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1018, 759);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Encoding";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // userControlEncoding1
            // 
            this.userControlEncoding1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlEncoding1.Location = new System.Drawing.Point(3, 3);
            this.userControlEncoding1.Name = "userControlEncoding1";
            this.userControlEncoding1.Size = new System.Drawing.Size(1012, 753);
            this.userControlEncoding1.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 787);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "TestHelpers - Code Utils";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private UserControlFactoryMethodGenerator userControlFactoryMethodGenerator1;
        private UserControlEncoding userControlEncoding1;
    }
}