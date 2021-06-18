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
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

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
            webView21.CoreWebView2.AddHostObjectToScript("bridge", new Bridge(this));

        }

        public string json
        {
            get { return this.JSONTextBox.Text; }
            set { this.JSONTextBox.Text = value; }
        }

    }

    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ComVisible(true)]
    public class Bridge
    {
        private QuestionnaireResponse _response;
        private Form1 _form;
        public Bridge(Form1 form)
        {
            this._form = form;
            this._form.json = "";
        }

        public string getBlockbyBlockId(string pid, string bid)
        {
            var serializer = new FhirJsonSerializer(new SerializerSettings()
            {
                Pretty = true
            });
            if(this._response == null)
            {
                return "";
            }
            return serializer.SerializeToString(this._response);
        }
        public string postBlockbyBlockId(string pid, string bid, string block)
        {
            var parser = new FhirJsonParser(new ParserSettings
            {
                AcceptUnknownMembers = true,
                AllowUnrecognizedEnums = true
            });

            try
            {
                this._response = parser.Parse<QuestionnaireResponse>(block);
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.ToString());
            }
            return this._form.json = block;
        }


    }
}
