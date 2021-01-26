using System;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace TestHelpers.CodeGenerator
{
    public partial class UserControlEncoding : UserControl
    {
        public UserControlEncoding()
        {
            InitializeComponent();
        }

        private void buttonEncode_Click(object sender, EventArgs e)
        {
            if (radioButtonBase64.Checked)
            {
                textBoxOutput.Text = Convert.ToBase64String(Encoding.UTF8.GetBytes(textBoxInput.Text));
            }
            else
            {
                textBoxOutput.Text = WebUtility.UrlEncode(textBoxInput.Text);
            }
        }

        private void buttonDecode_Click(object sender, EventArgs e)
        {
            if (radioButtonBase64.Checked)
            {
                textBoxOutput.Text = Encoding.UTF8.GetString(Convert.FromBase64String(textBoxInput.Text));
            }
            else
            {
                textBoxOutput.Text = WebUtility.UrlDecode(textBoxInput.Text);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxInput.Clear();
            textBoxOutput.Clear();
            textBoxInput.Focus();
        }
    }
}
