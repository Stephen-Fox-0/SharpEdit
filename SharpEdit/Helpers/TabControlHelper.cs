using SharpEditCore.TextEditor;
using SharpEditCore.TextEditor.Syntax;
using SharpMaterialControl.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpEdit.Helpers
{
    public class TabControlHelper : Component
    {
        public MaterialTabControl TabControl
        {
            get;
            set;
        }

        public Form1 Form
        {
            get;
            set;
        }

        public void AddTab(string fileName)
        {
            Form.LogWindow.AppendText ("\nCreating new material tab...");
            if ( TabControl.TabCount>0 )
                TabControl.TabPages.Remove (TabControl.TabPages[ TabControl.TabPages.Count-1 ]);
            var ruler = new Ruler ();
            var map = new DocumentMap ();
            var textBox = new TextEditorControl ();
            var page = new TabPage ();

            Form.LogWindow.AppendText ("\nCreate control layout, bounds, and themes..");

            ruler.Dock=System.Windows.Forms.DockStyle.Top;
            ruler.Target=textBox;
            ruler.BackColor=ColorTranslator.FromHtml ("#f8f8f8");
            ruler.BackColor2=ColorTranslator.FromHtml ("#f8f8f8");
            ruler.Visible=false;

            map.Dock=System.Windows.Forms.DockStyle.Right;
            map.Target=textBox;
            map.Width=100;
            map.BackColor=Color.White;
            map.Visible=false;
            map.MapBackground=ColorTranslator.FromHtml ("#e3e3e3");
            map.ScrollbarVisible=false;
            textBox.Dock=System.Windows.Forms.DockStyle.Fill;
            textBox.AutoCompleteBrackets=true;
            textBox.AutoIndent=true;
            textBox.LeftPadding=25;
            textBox.IndentBackColor=Color.White;
            textBox.ServiceLinesColor=Color.White;
            textBox.LineNumberColor=Color.Teal;
            textBox.Font=new Font ("Consolas" , 9);
            textBox.Language=detectLang (fileName);
            textBox.FoldingIndicatorColor=Color.FromArgb (156 , 156 , 156);
            if ( File.Exists (fileName) )
            {
                textBox.OpenFile (fileName);

                Properties.Settings.Default.Recent+=fileName+"|";
                Properties.Settings.Default.Save ();
            }
            page=new TabPage
            {
                Text=Path.GetFileName (fileName) ,
                Tag=fileName
            };
            textBox.AllowSeveralTextStyleDrawing=true;
            textBox.DragEnter+=TextBox_DragEnter;
            textBox.DragDrop+=TextBox_DragDrop;
            textBox.AllowDrop=true;
            FindTextTemplate find = new FindTextTemplate (textBox);
            find.Dock=DockStyle.Top;
            ReplaceTextTemplate replace = new ReplaceTextTemplate (textBox);
            replace.Dock=DockStyle.Top;
            //  page.Controls.Add (find);
            //page.Controls.Add (replace);
            Form.LogWindow.AppendText ("\nAdding new themed controls to tabs..");
            page.Controls.Add (ruler);
            page.Controls.Add (map);
            page.Controls.Add (textBox);
            textBox.BringToFront ();
            TabControl.TabPages.Add (page);
            Form.LogWindow.AppendText ("\nCreating a new instance of new tab button");
            TabControl.TabPages.Add (new TabPage () { Text="+" });
            TabControl.SelectedTab=page;
            Form.LogWindow.AppendText ("\nTab created: ["+fileName+", TabIndex: "+Convert.ToString(TabControl.TabPages.Count-1)+"]");
        }

        private void TextBox_DragDrop( object sender , DragEventArgs e )
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var data = (string[])e.Data.GetData (DataFormats.FileDrop);
                for ( int i = 0; i<data.Length; i++ )
                    AddTab (data[ i ]);
            }
        }

        private void TextBox_DragEnter( object sender , DragEventArgs e )
        {
            if ( e.Data.GetDataPresent (DataFormats.FileDrop) )
            {
                e.Effect=DragDropEffects.Copy;
            }
        }

        Language detectLang( string fileName )
        {
            var extention = Path.GetExtension (fileName);
            if ( extention.Contains ("c")||extention.Contains ("#") )
                return Language.CSharp;
            if ( extention.Contains ("java")||extention.Contains ("json")||extention.Contains ("ts") )
                return Language.Java;
            if ( extention.Contains ("js") )
                return Language.JS;
            if ( extention.Contains ("xml")||extention.Contains ("htm"))
                return Language.HTML;
            if ( extention.Contains ("php") )
                return Language.PHP;
            if ( extention.Contains ("vb") )
                return Language.VB;
            return Language.Custom;
        }

        public string GetOpenedText()
        {
            var tab = TabControl.SelectedTab;
            var control = new Control ();

            foreach ( Control t in tab.Controls )
                if ( t is TextEditorControl )
                    control=t;
            return control.Text;
        }
        public TextEditorControl GetEditor()
        {
            var tab = TabControl.SelectedTab;

            foreach ( Control t in tab.Controls )
                if ( t is TextEditorControl )
                    return (TextEditorControl)t;

            return null;
        }
        public Ruler GetRuler()
        {
            var tab = TabControl.SelectedTab;

            foreach ( Control t in tab.Controls )
                if ( t is Ruler )
                    return (Ruler)t;

            return null;
        }
        public DocumentMap GetMap()
        {
            var tab = TabControl.SelectedTab;

            foreach ( Control t in tab.Controls )
                if ( t is DocumentMap )
                    return (DocumentMap)t;

            return null;
        }
    }
}
