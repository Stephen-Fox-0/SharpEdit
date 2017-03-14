using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpEditCore.TextEditor;
using System.Text.RegularExpressions;

namespace SharpEdit
{
    public partial class ReplaceTextTemplate: UserControl
    {
        Place startPlace;
        TextEditorControl editor;
        bool firstSearch = false;
        public ReplaceTextTemplate( TextEditorControl editorControl )
        {
            InitializeComponent ();
            this.editor=editorControl;
        }

        private void FindTextTemplate_Load( object sender , EventArgs e )
        {

        }
        public virtual void FindNext( string pattern )
        {
            try
            {
                RegexOptions opt = RegexOptions.IgnoreCase;
                //
                Range range = editor.Selection.Clone ();
                range.Normalize ();
                //
                if ( firstSearch )
                {
                    startPlace=range.Start;
                    firstSearch=false;
                }
                //
                range.Start=range.End;
                if ( range.Start>=startPlace )
                    range.End=new Place (editor.GetLineLength (editor.LinesCount-1) , editor.LinesCount-1);
                else
                    range.End=startPlace;
                //
                foreach ( var r in range.GetRangesByLines (pattern , opt) )
                {
                    editor.Selection=r;
                    editor.DoSelectionVisible ();
                    editor.Invalidate ();
                    return;
                }
                //
                if ( range.Start>=startPlace&&startPlace>Place.Empty )
                {
                    editor.Selection.Start=new Place (0 , 0);
                    FindNext (pattern);
                    return;
                }
                MessageBox.Show ("Not found");
            }
            catch ( Exception ex )
            {
                MessageBox.Show (ex.Message);
            }
        }
        private void FindTextTemplate_Paint( object sender , PaintEventArgs e )
        {
            e.Graphics.SmoothingMode=System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.FillRectangle (new SolidBrush (ColorTranslator.FromHtml ("#e3e3e3")) , new Rectangle (0 , this.Height-1 , this.Width , 1));
        }

        private void materialFlatButton1_Click( object sender , EventArgs e )
        {
            FindNext (textBox2.Text);
            editor.SelectedText=textBox1.Text;
        }

        private void materialFlatButton2_Click( object sender , EventArgs e )
        {
            this.Visible=false;
        }
    }
}
