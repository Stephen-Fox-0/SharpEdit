using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpEdit
{
    public partial class WebBrowser: UserControl
    {
        public WebBrowser()
        {
            InitializeComponent ();
        }

        private void textBox1_KeyDown( object sender , KeyEventArgs e )
        {
            if ( e.KeyCode==Keys.Enter )
                webBrowser1.Navigate (textBox1.Text);
        }

        private void webBrowser1_DocumentCompleted( object sender , WebBrowserDocumentCompletedEventArgs e )
        {
            textBox1.Text=e.Url.OriginalString;
        }

        private void panel1_Paint( object sender , PaintEventArgs e )
        {
            e.Graphics.FillRectangle (new SolidBrush (ColorTranslator.FromHtml ("#e3e3e3")) , 0 , panel1.Height-1 , panel1.Width-1 , 1);
        }
    }
}
