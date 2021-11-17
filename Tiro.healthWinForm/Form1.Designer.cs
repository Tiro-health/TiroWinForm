
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.apiKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.JSONTextBox = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.XMLTextBox = new System.Windows.Forms.RichTextBox();
            this.template = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.patient = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.encounter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // webView21
            // 
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.webView21.Location = new System.Drawing.Point(0, 0);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1762, 477);
            this.webView21.Source = new System.Uri("http://10.37.129.2:3000/embedded/templates", System.UriKind.Absolute);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            // 
            // apiKey
            // 
            this.apiKey.Location = new System.Drawing.Point(106, 16);
            this.apiKey.Name = "apiKey";
            this.apiKey.Size = new System.Drawing.Size(642, 31);
            this.apiKey.TabIndex = 1;
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
            // age
            // 
            this.age.Location = new System.Drawing.Point(106, 53);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(90, 31);
            this.age.TabIndex = 3;
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
            // sex
            // 
            this.sex.Location = new System.Drawing.Point(106, 91);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(90, 31);
            this.sex.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1308, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-3, 144);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1778, 676);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webView21);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1762, 629);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "NoteEditor";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1341, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.JSONTextBox);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1762, 629);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "FHIR Document (JSON)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // JSONTextBox
            // 
            this.JSONTextBox.Location = new System.Drawing.Point(0, 3);
            this.JSONTextBox.Name = "JSONTextBox";
            this.JSONTextBox.Size = new System.Drawing.Size(1762, 626);
            this.JSONTextBox.TabIndex = 0;
            this.JSONTextBox.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.XMLTextBox);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1762, 629);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "FHIR Document (XML)";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // XMLTextBox
            // 
            this.XMLTextBox.Location = new System.Drawing.Point(3, 0);
            this.XMLTextBox.Name = "XMLTextBox";
            this.XMLTextBox.Size = new System.Drawing.Size(1759, 629);
            this.XMLTextBox.TabIndex = 0;
            this.XMLTextBox.Text = "";
            // 
            // template
            // 
            this.template.Location = new System.Drawing.Point(897, 16);
            this.template.Name = "template";
            this.template.Size = new System.Drawing.Size(344, 31);
            this.template.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(783, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "template";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(783, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "patient";
            // 
            // patient
            // 
            this.patient.Location = new System.Drawing.Point(897, 53);
            this.patient.Name = "patient";
            this.patient.Size = new System.Drawing.Size(344, 31);
            this.patient.TabIndex = 12;
            this.patient.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(783, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "encounter";
            // 
            // encounter
            // 
            this.encounter.Location = new System.Drawing.Point(897, 91);
            this.encounter.Name = "encounter";
            this.encounter.Size = new System.Drawing.Size(344, 31);
            this.encounter.TabIndex = 14;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1773, 817);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.encounter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.patient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.template);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.age);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.apiKey);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tiro.health - WebView2 Embedded NoteEditor";
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.TextBox apiKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sex;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox JSONTextBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox XMLTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox template;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox patient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox encounter;
    }
}

