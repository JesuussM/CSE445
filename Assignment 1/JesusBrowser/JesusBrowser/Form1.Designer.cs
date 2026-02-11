namespace JesusBrowser
{
    partial class Form1
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.cbOperator = new System.Windows.Forms.ComboBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblEql = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblCalc = new System.Windows.Forms.Label();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblEncrypt = new System.Windows.Forms.Label();
            this.txtInputMessage = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.lblEncrypted = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(3, 49);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(695, 380);
            this.webBrowser1.TabIndex = 0;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(513, 8);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(85, 35);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(223, 12);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(275, 26);
            this.txtUrl.TabIndex = 2;
            this.txtUrl.Text = "http://";
            // 
            // cbOperator
            // 
            this.cbOperator.FormattingEnabled = true;
            this.cbOperator.Location = new System.Drawing.Point(90, 478);
            this.cbOperator.Name = "cbOperator";
            this.cbOperator.Size = new System.Drawing.Size(45, 28);
            this.cbOperator.TabIndex = 3;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(59, 512);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(100, 37);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(12, 480);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(72, 26);
            this.txtNum1.TabIndex = 5;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(141, 480);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(72, 26);
            this.txtNum2.TabIndex = 6;
            // 
            // lblEql
            // 
            this.lblEql.AutoSize = true;
            this.lblEql.Location = new System.Drawing.Point(219, 486);
            this.lblEql.Name = "lblEql";
            this.lblEql.Size = new System.Drawing.Size(18, 20);
            this.lblEql.TabIndex = 7;
            this.lblEql.Text = "=";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(243, 486);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(18, 20);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "0";
            // 
            // lblCalc
            // 
            this.lblCalc.AutoSize = true;
            this.lblCalc.Location = new System.Drawing.Point(70, 457);
            this.lblCalc.Name = "lblCalc";
            this.lblCalc.Size = new System.Drawing.Size(80, 20);
            this.lblCalc.TabIndex = 9;
            this.lblCalc.Text = "Calculator";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(61, 15);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(152, 20);
            this.lblUrl.TabIndex = 10;
            this.lblUrl.Text = "Enter Web Address:";
            // 
            // lblEncrypt
            // 
            this.lblEncrypt.AutoSize = true;
            this.lblEncrypt.Location = new System.Drawing.Point(427, 457);
            this.lblEncrypt.Name = "lblEncrypt";
            this.lblEncrypt.Size = new System.Drawing.Size(190, 20);
            this.lblEncrypt.TabIndex = 11;
            this.lblEncrypt.Text = "Type message to encrypt:";
            // 
            // txtInputMessage
            // 
            this.txtInputMessage.Location = new System.Drawing.Point(345, 480);
            this.txtInputMessage.Name = "txtInputMessage";
            this.txtInputMessage.Size = new System.Drawing.Size(253, 26);
            this.txtInputMessage.TabIndex = 12;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(604, 480);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(82, 30);
            this.btnEncrypt.TabIndex = 13;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // lblEncrypted
            // 
            this.lblEncrypted.AutoSize = true;
            this.lblEncrypted.Location = new System.Drawing.Point(427, 520);
            this.lblEncrypted.Name = "lblEncrypted";
            this.lblEncrypted.Size = new System.Drawing.Size(0, 20);
            this.lblEncrypted.TabIndex = 14;
            this.lblEncrypted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 584);
            this.Controls.Add(this.lblEncrypted);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtInputMessage);
            this.Controls.Add(this.lblEncrypt);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.lblCalc);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblEql);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.cbOperator);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Jesus\' Browser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.ComboBox cbOperator;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblEql;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblCalc;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblEncrypt;
        private System.Windows.Forms.TextBox txtInputMessage;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label lblEncrypted;
    }
}

