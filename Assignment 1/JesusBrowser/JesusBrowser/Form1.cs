using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JesusBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbOperator.Items.AddRange(new string[] { "+", "-", "*", "/" });
            cbOperator.SelectedIndex = 0;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtUrl.Text);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            float num1 = float.TryParse(txtNum1.Text, out num1) ? num1 : 0;
            float num2 = float.TryParse(txtNum2.Text, out num2) ? num2 : 0;
            switch (cbOperator.SelectedIndex)
            {
                case 0: 
                    lblResult.Text = (num1 + num2).ToString(); 
                    break;
                case 1: 
                    lblResult.Text = (num1 - num2).ToString(); 
                    break;
                case 2: 
                    lblResult.Text = (num1 * num2).ToString(); 
                    break;
                case 3: 
                    lblResult.Text = (num2 != 0 ? (num1 / num2).ToString() : "Error"); 
                    break;
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            EncryptService.ServiceClient client = new EncryptService.ServiceClient();
            try
            {
                lblEncrypted.Text = client.Encrypt(txtInputMessage.Text);
            } catch (Exception ec)
            {
                lblEncrypted.Text = "Error: " + ec.Message;
            }
        }
    }
}
