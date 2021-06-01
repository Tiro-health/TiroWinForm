using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Tiro.healthWinForm
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Form_Resize);
            InitializeAsync();
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            webView21.Size = this.ClientSize - new System.Drawing.Size(webView21.Location);
        }

        async void InitializeAsync()
        {
            await webView21.EnsureCoreWebView2Async(null);
            webView21.CoreWebView2.WebMessageReceived += processContent; 
            webView21.CoreWebView2.AddHostObjectToScript("bridge", new Bridge(this));

        }
        void processContent(object sender, CoreWebView2WebMessageReceivedEventArgs args)
        {
            String payload = args.TryGetWebMessageAsString();
            plainTextBox.Text = payload;

        }

        public string plainText
        {
            get { return this.plainTextBox.Text; }
            set { this.plainTextBox.Text = value; }
        }

        public string markdown
        {
            get { return this.markDownTextBox.Text; }
            set { this.markDownTextBox.Text = value; }
        }
        public string json
        {
            get { return this.JSONTextBox.Text; }
            set { this.JSONTextBox.Text = value; }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ComVisible(true)]
    public class Bridge
    {
        private Form1 _form;
        public Bridge(Form1 form)
        {
            this._form = form;
        }
        public void processPlainText(string param)
        {
            this._form.plainText = param;
        }
        public void processJSON(string param)
        {
            this._form.json = param;
        }

        public void processMarkDown(string param)
        {
            this._form.markdown = param;
        }

    }
}
