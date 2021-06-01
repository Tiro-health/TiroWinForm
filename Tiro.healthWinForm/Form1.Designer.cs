
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
            this.plainTextBox = new System.Windows.Forms.RichTextBox();
            this.JSONTextBox = new System.Windows.Forms.RichTextBox();
            this.markDownTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // webView21
            // 
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(15, 12);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1212, 364);
            this.webView21.Source = new System.Uri("http://10.211.55.2:3000/textarea-export", System.UriKind.Absolute);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            // 
            // plainTextBox
            // 
            this.plainTextBox.Location = new System.Drawing.Point(15, 448);
            this.plainTextBox.Name = "plainTextBox";
            this.plainTextBox.Size = new System.Drawing.Size(400, 360);
            this.plainTextBox.TabIndex = 1;
            this.plainTextBox.Text = "";
            // 
            // JSONTextBox
            // 
            this.JSONTextBox.Location = new System.Drawing.Point(421, 448);
            this.JSONTextBox.Name = "JSONTextBox";
            this.JSONTextBox.Size = new System.Drawing.Size(400, 360);
            this.JSONTextBox.TabIndex = 2;
            this.JSONTextBox.Text = "";
            // 
            // markDownTextBox
            // 
            this.markDownTextBox.Location = new System.Drawing.Point(827, 448);
            this.markDownTextBox.Name = "markDownTextBox";
            this.markDownTextBox.Size = new System.Drawing.Size(400, 360);
            this.markDownTextBox.TabIndex = 3;
            this.markDownTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "PlainText";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(416, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Raw JSON";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(829, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(398, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Markdown with SNOMED CT hyperlinks";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1239, 817);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.markDownTextBox);
            this.Controls.Add(this.JSONTextBox);
            this.Controls.Add(this.plainTextBox);
            this.Controls.Add(this.webView21);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.RichTextBox plainTextBox;
        private System.Windows.Forms.RichTextBox JSONTextBox;
        private System.Windows.Forms.RichTextBox markDownTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

