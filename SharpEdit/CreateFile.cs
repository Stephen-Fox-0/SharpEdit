using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpEdit
{
    public partial class CreateFile: Form
    {
        public CreateFile()
        {
            InitializeComponent ();
        }

        private void CreateFile_Load( object sender , EventArgs e )
        {
        }

        private void materialFlatButton2_Click( object sender , EventArgs e )
        {
            Close ();
        }

        private void listBox1_SelectedIndexChanged( object sender , EventArgs e )
        {
            materialSingleLineTextField1.Text="Untitled"+listBox1.Items[ listBox1.SelectedIndex ].ToString ();
        }

        private void materialTabSelector1_Click( object sender , EventArgs e )
        {

        }

        private void materialTabControl1_SelectedIndexChanged( object sender , EventArgs e )
        {
            if ( materialTabControl1.SelectedIndex==0 )
                    this.Height=402;
            else
                    this.Height=159;
        }

        public string fileName { get; set; }
        private void materialFlatButton1_Click( object sender , EventArgs e )
        {
            this.fileName=materialSingleLineTextField1.Text;
            this.Close ();
        }

        private void materialFlatButton4_Click( object sender , EventArgs e )
        {
            this.fileName=materialSingleLineTextField2.Text;
            this.Close ();
        }

        private void listBox1_DrawItem( object sender , DrawItemEventArgs e )
        {


            if ( e.State.ToString ().Contains ("Selected") )
            {
                e.Graphics.FillRectangle (new SolidBrush (ColorTranslator.FromHtml ("#f8f8f8")) ,
                    e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle (new SolidBrush (ColorTranslator.FromHtml ("white")) ,
                   e.Bounds);
            }

            e.Graphics.DrawString (
                listBox1.Items[ e.Index ].ToString () ,
                new Font ("Segoe UI Light" , 11) ,
                new SolidBrush (Color.Black) ,
                              new Rectangle (e.Bounds.X , e.Bounds.Y-6 , e.Bounds.Width , e.Bounds.Height) ,
                new StringFormat ()
                {
                    Alignment=StringAlignment.Near ,
                    LineAlignment=StringAlignment.Center
                });
            e.Graphics.DrawString (
               "Untitled" + listBox1.Items[ e.Index ].ToString () ,
               new Font ("Segoe UI Light" , 8) ,
               new SolidBrush (Color.Gray) ,
               new Rectangle(e.Bounds.X, e.Bounds.Y + 8, e.Bounds.Width, e.Bounds.Height) ,
               new StringFormat ()
               {
                   Alignment=StringAlignment.Near ,
                   LineAlignment=StringAlignment.Center
               });
        }
    }
}
