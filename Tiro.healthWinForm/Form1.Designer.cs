
namespace Tiro.healthWinForm
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
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.apiKeyText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ageText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sexText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // webView21
            // 
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.webView21.Location = new System.Drawing.Point(12, 158);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1749, 647);
            this.webView21.Source = new System.Uri("http://10.37.129.2:3000/embedded/templates", System.UriKind.Absolute);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            // 
            // apiKeyText
            // 
            this.apiKeyText.Location = new System.Drawing.Point(106, 16);
            this.apiKeyText.Name = "apiKeyText";
            this.apiKeyText.Size = new System.Drawing.Size(642, 31);
            this.apiKeyText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "API Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Age";
            // 
            // ageText
            // 
            this.ageText.Location = new System.Drawing.Point(106, 53);
            this.ageText.Name = "ageText";
            this.ageText.Size = new System.Drawing.Size(90, 31);
            this.ageText.TabIndex = 3;
            this.ageText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sex";
            // 
            // sexText
            // 
            this.sexText.Location = new System.Drawing.Point(106, 91);
            this.sexText.Name = "sexText";
            this.sexText.Size = new System.Drawing.Size(90, 31);
            this.sexText.TabIndex = 5;
            this.sexText.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(767, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1773, 817);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sexText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ageText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.apiKeyText);
            this.Controls.Add(this.webView21);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.TextBox apiKeyText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ageText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sexText;
        private System.Windows.Forms.Button button1;
    }
}

