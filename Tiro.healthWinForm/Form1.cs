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
            webView21.Size = this.ClientSize - new System.Drawing.Size(webView21.Location) - new Size(0, 100);
            tabControl1.Size = this.ClientSize - new System.Drawing.Size(tabControl1.Location);
        }

        async void InitializeAsync()
        {
            await webView21.EnsureCoreWebView2Async(null);
            webView21.CoreWebView2.AddHostObjectToScript("bridge", new Bridge(this));

        }

        private void requestSubmit()
        {
            this.webView21.CoreWebView2.PostWebMessageAsJson("{\"action\": \"submit\"}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var uri = "https://write.tiro.health/embedded/notes?";
            if(this.age.TextLength > 0)
            {
                uri += "age=" + this.age.Text+"&";
            }
            if(this.sex.TextLength > 0)
            {
                uri += "sex=" + this.sex.Text+"&";
            }
            if(this.apiKey.TextLength > 0)
            {
                uri += "apiKey=" + this.apiKey.Text+"&";
            }
            if(this.patient.TextLength > 0)
            {
                uri += "patient=" + this.patient.Text+"&";
            }
            if(this.encounter.TextLength > 0)
            {
                uri += "encounter=" + this.encounter.Text+"&";
            }
            if(this.template.TextLength > 0)
            {
                uri += "template=" + this.template.Text+"&";
            }

            Uri uri1 = new System.Uri(uri);
            this.webView21.Source = uri1;
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.requestSubmit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
    // This class should be added to your project. The form here is used to display the received variables
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
                AcceptUnknownMembers = false,
                AllowUnrecognizedEnums = true
            });

            try
            {
                this._response = parser.Parse<Bundle>(fhirJsonDocument);
                var composition =(Composition)this._response.Entry.First().Resource;
                foreach(var section in composition.Section)
                {
                    var code = section.Code.Coding.Find((c) => c.System == "http://tce.tiro.health/fhir/DocumentSections").Code;
                    Console.WriteLine(code);
                    Console.WriteLine(section.Title);
                    Console.WriteLine(section.Text.Div);
                }
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
