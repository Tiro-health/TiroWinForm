
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
            this.JSONTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // webView21
            // 
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(15, 12);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1212, 550);
            this.webView21.Source = new System.Uri("https://tiroapp-4cb17.web.app/patients/ddca2e15-6310-4873-8f30-a1d6920ee69f/file/" +
        "medical-history-embedded", System.UriKind.Absolute);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            // 
            // JSONTextBox
            // 
            this.JSONTextBox.Location = new System.Drawing.Point(15, 596);
            this.JSONTextBox.Name = "JSONTextBox";
            this.JSONTextBox.Size = new System.Drawing.Size(1212, 209);
            this.JSONTextBox.TabIndex = 2;
            this.JSONTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 565);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Raw JSON";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1239, 817);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.JSONTextBox);
            this.Controls.Add(this.webView21);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.RichTextBox JSONTextBox;
        private System.Windows.Forms.Label label2;
    }
}

