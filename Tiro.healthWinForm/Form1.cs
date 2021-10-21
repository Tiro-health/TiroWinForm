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
            tabControl1.Size = this.ClientSize - new System.Drawing.Size(tabControl1.Location);
        }

        async void InitializeAsync()
        {
            await webView21.EnsureCoreWebView2Async(null);
            webView21.CoreWebView2.AddHostObjectToScript("bridge", new Bridge(this));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.webView21.Source = new System.Uri("http://write.tiro.health/embedded/templates?age=" + this.ageText.Text + "&sex=" + this.sexText.Text + "&apiKey=" + this.apiKeyText.Text);
        }

        public string FhirJSONDocument {
            get
            {
                return this.JSONTextBox.Text;
            }
            set
            {
                this.JSONTextBox.Text = value;
            }

        }
        public string FhirXMLDocument
        {
            get
            {
                return this.XMLTextBox.Text;
            }
            set
            {
                this.XMLTextBox.Text = value;
            }

        }
    }

    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ComVisible(true)]
    public class Bridge
    {
        private Bundle _response;
        private Form1 _form;
        public Bridge(Form1 form)
        {
            this._form = form;
        }

        public string getFhirDocument()
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
        public void setFhirDocument(string fhirJsonDocument)
        {
            var parser = new FhirJsonParser(new ParserSettings
            {
                AcceptUnknownMembers = true,
                AllowUnrecognizedEnums = true
            });

            try
            {
                this._response = parser.Parse<Bundle>(fhirJsonDocument);
                this._form.FhirJSONDocument = this._response.ToJson(new FhirJsonSerializationSettings()
                {Pretty = true}
                    );

                this._form.FhirXMLDocument = this._response.ToXml(new FhirXmlSerializationSettings() 
                { Pretty = true}
                );
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.ToString());
            }
        }


    }
}
