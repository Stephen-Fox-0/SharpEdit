using SharpEdit.Helpers;
using SharpEditCore.Debugger;
using SharpEditCore.Text;
using SharpEditCore.TextEditor;
using SharpEditCore.Workspace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SharpEdit
{
    public partial class Form1: Form
    {
        string[] args = null;
        public Form1(string[] args)
        {
            this.args=args;
            InitializeComponent ();

            if ( args.Length>0 )
                for ( int i = 0; i<args.Length; i++ )
                    tabControlHelper1.AddTab (args[ i ]);
            tabControlHelper1.Form=this;
        }

        private void Form1_Load( object sender , EventArgs e )
        {
            panel1.Visible=false;
            splitter1.Visible=false;
            panel4.Visible=false;
            panel6.Visible=false;
            splitter4.Visible=false;
            splitter3.Visible=false;
            SharpEditCore.Docking.VS2015LightTheme theme = new SharpEditCore.Docking.VS2015LightTheme ();
            theme.ApplyTo (menuStrip1);
            tabControlHelper1.AddTab ("Untitled.txt");
        }
        public static string GetFileSizeInBytes( long TotalBytes )
        {
            if ( TotalBytes==1073741824 ) //Giga Bytes
            {
                Decimal FileSize = Decimal.Divide (TotalBytes , 1073741824);
                return String.Format ("{0:##.##} GB" , FileSize);
            }
            else if ( TotalBytes==1048576 ) //Mega Bytes
            {
                Decimal FileSize = Decimal.Divide (TotalBytes , 1048576);
                return String.Format ("{0:##.##} MB" , FileSize);
            }
            else if ( TotalBytes==1024 ) //Kilo Bytes
            {
                Decimal FileSize = Decimal.Divide (TotalBytes , 1024);
                return String.Format ("{0:##.##} KB" , FileSize);
            }
            else
            {
                return "0 Bytes";
            }


        }
        private void menuStrip1_Paint( object sender , PaintEventArgs e )
        {
            e.Graphics.FillRectangle (new SolidBrush (ColorTranslator.FromHtml ("233,233,233")) , new Rectangle (0 , 0 , menuStrip1.Width , menuStrip1.Height));
        }

        private void materialTabControl1_SelectedIndexChanged( object sender , EventArgs e )
        {
            if ( materialTabControl1.SelectedIndex==materialTabControl1.TabPages.Count-1 )
                tabControlHelper1.AddTab ("Untitled.txt");
            else
            {
                if ( materialTabControl1.SelectedTab.Text=="Web Browser" )
                    timer1.Stop ();
                else
                    timer1.Start ();
            }

            refreshTabContextMenu ();
            this.Text="SharpEdit - "+materialTabControl1.SelectedTab.Text;
        }

        private void menuStrip1_ItemClicked( object sender , ToolStripItemClickedEventArgs e )
        {

        }

        private void newToolStripMenuItem_Click( object sender , EventArgs e )
        {
            //CreateFile file = new CreateFile ();
            //file.ShowDialog ();

            //if ( !string.IsNullOrEmpty (file.fileName) )
            //    tabControlHelper1.AddTab (file.fileName);
            //else
            //    return;

            //tabControlHelper1.AddTab ("Untitled.txt");
            SharpEditCore.Controls.NewFileDialog fileDialog = new SharpEditCore.Controls.NewFileDialog ();
            fileDialog.Icon=this.Icon;
            fileDialog.Creation+=FileDialog_Creation;
            fileDialog.ShowDialog ();
        }

        private void FileDialog_Creation( SharpEditCore.Controls.NewFileDialog.FileResult eventArgs )
        {
            if ( eventArgs.SaveFile )
            {
                using ( var stream = new StreamWriter (eventArgs.SaveDestination+"\\"+eventArgs.FileName) )
                {
                    stream.Close ();
                }
                tabControlHelper1.AddTab (eventArgs.SaveDestination+"\\"+eventArgs.FileName);
            }

            tabControlHelper1.AddTab (eventArgs.FileName);
        }

        private void openToolStripMenuItem_Click( object sender , EventArgs e )
        {
            OpenFileDialog fileDialog = new OpenFileDialog ();
            if ( fileDialog.ShowDialog ()==DialogResult.OK )
                tabControlHelper1.AddTab (fileDialog.FileName);
        }

        private void saveToolStripMenuItem_Click( object sender , EventArgs e )
        {
            SaveFileDialog fileDialog = new SaveFileDialog ();
            if ( tabControlHelper1.TabControl.SelectedTab.Tag as string!="" )
            {
                if ( fileDialog.FileName=="" )
                {
                    if ( fileDialog.ShowDialog ()==DialogResult.OK )
                    {
                        using ( var streamWriter = new StreamWriter (fileDialog.FileName) )
                        {
                            streamWriter.WriteLine (tabControlHelper1.GetOpenedText ());
                            streamWriter.Close ();
                        }
                        tabControlHelper1.TabControl.SelectedTab.Tag=fileDialog.FileName;
                        tabControlHelper1.TabControl.SelectedTab.Text=Path.GetFileName (fileDialog.FileName);
                    }
                }
                else
                {
                    using ( var streamWriter = new StreamWriter (materialTabControl1.SelectedTab.Tag as string) )
                    {
                        streamWriter.WriteLine (tabControlHelper1.GetOpenedText ());
                        streamWriter.Close ();
                    }
                }
            }
            tabControlHelper1.TabControl.SelectedTab.Text=Path.GetFileName (tabControlHelper1.TabControl.SelectedTab.Tag as string);
            tabControlHelper1.TabControl.Refresh ();
        }

        private void saveAsToolStripMenuItem_Click( object sender , EventArgs e )
        {
            SaveFileDialog fileDialog = new SaveFileDialog ();
            if ( tabControlHelper1.TabControl.SelectedTab.Tag as string!="" )
            {
                if ( fileDialog.ShowDialog ()==DialogResult.OK )
                {
                    using ( var streamWriter = new StreamWriter (fileDialog.FileName) )
                    {
                        streamWriter.WriteLine (tabControlHelper1.GetOpenedText ());
                        streamWriter.Close ();
                    }
                    tabControlHelper1.TabControl.SelectedTab.Tag=fileDialog.FileName;
                    tabControlHelper1.TabControl.SelectedTab.Text=Path.GetFileName (fileDialog.FileName);
                }
            }
        }

        private void saveAllToolStripMenuItem_Click( object sender , EventArgs e )
        {

        }

        private void printToolStripMenuItem_Click( object sender , EventArgs e )
        {
            tabControlHelper1.GetEditor ().Print ();
        }

        private void pageSetupToolStripMenuItem_Click( object sender , EventArgs e )
        {
            tabControlHelper1.GetEditor ().Print (new SharpEditCore.TextEditor.Print.PrintDialogSettings  { ShowPrintPreviewDialog=false , ShowPageSetupDialog=true , ShowPrintDialog=false });
        }

        private void printPreviewToolStripMenuItem_Click( object sender , EventArgs e )
        {
            tabControlHelper1.GetEditor ().Print (new SharpEditCore.TextEditor.Print.PrintDialogSettings { ShowPrintPreviewDialog=true, ShowPageSetupDialog = false, ShowPrintDialog = false });
        }

        private void closeWindowToolStripMenuItem_Click( object sender , EventArgs e )
        {
            Close ();
        }

        private void newWindowToolStripMenuItem_Click( object sender , EventArgs e )
        {
            System.Diagnostics.Process.Start ("SharpEdit.exe");
        }

        private void closeToolStripMenuItem_Click( object sender , EventArgs e )
        {
            Close ();
        }

        private void undoToolStripMenuItem_Click( object sender , EventArgs e )
        {
            tabControlHelper1.GetEditor ().Undo ();
        }

        private void redoToolStripMenuItem_Click( object sender , EventArgs e )
        {
            tabControlHelper1.GetEditor ().Redo ();
        }

        private void cutToolStripMenuItem_Click( object sender , EventArgs e )
        {
            tabControlHelper1.GetEditor ().Cut ();
        }

        private void copyToolStripMenuItem_Click( object sender , EventArgs e )
        {
            tabControlHelper1.GetEditor ().Copy ();
        }

        private void pasteToolStripMenuItem_Click( object sender , EventArgs e )
        {
            tabControlHelper1.GetEditor ().Paste ();
        }

        private void deleteToolStripMenuItem_Click( object sender , EventArgs e )
        {
            tabControlHelper1.GetEditor ().Text="";
        }

        private void deleteSelectionToolStripMenuItem_Click( object sender , EventArgs e )
        {
            tabControlHelper1.GetEditor ().SelectedText="";
        }

        private void findToolStripMenuItem_Click( object sender , EventArgs e )
        {
            tabControlHelper1.GetEditor ().ShowFindDialog ();
        }

        private void findAndReplaceToolStripMenuItem_Click( object sender , EventArgs e )
        {
            tabControlHelper1.GetEditor ().ShowReplaceDialog ();
        }

        private void gotoToolStripMenuItem_Click( object sender , EventArgs e )
        {
            tabControlHelper1.GetEditor ().ShowGoToDialog ();
        }

        private void selectAllToolStripMenuItem_Click( object sender , EventArgs e )
        {
            tabControlHelper1.GetEditor ().SelectAll ();
        }

        private void autoCompleteToolStripMenuItem_Click( object sender , EventArgs e )
        {
            autoCompleteToolStripMenuItem.Checked = tabControlHelper1.GetEditor ().AutoCompleteBrackets=!tabControlHelper1.GetEditor ().AutoCompleteBrackets;
        }

        private void autoIndentToolStripMenuItem_Click( object sender , EventArgs e )
        {
            autoIndentToolStripMenuItem.Checked=tabControlHelper1.GetEditor ().AutoIndent=!tabControlHelper1.GetEditor ().AutoIndent;
        }

        private void bookmarkLineToolStripMenuItem_Click( object sender , EventArgs e )
        {
            tabControlHelper1.GetEditor ().BookmarkLine (tabControlHelper1.GetEditor ().Selection.Bounds.iStartLine);
        }

        private void unbookmarkToolStripMenuItem_Click( object sender , EventArgs e )
        {
            tabControlHelper1.GetEditor ().UnbookmarkLine (tabControlHelper1.GetEditor ().Selection.Bounds.iStartLine);
        }

        private void wordWrapToolStripMenuItem_Click( object sender , EventArgs e )
        {
            wordWrapToolStripMenuItem.Checked=tabControlHelper1.GetEditor ().WordWrap=!tabControlHelper1.GetEditor ().WordWrap;
        }

        private void fontColorToolStripMenuItem_Click( object sender , EventArgs e )
        {
            ColorDialog font = new ColorDialog ();
            if ( font.ShowDialog ()==DialogResult.OK )
                tabControlHelper1.GetEditor ().ForeColor=font.Color;
        }

        private void fontToolStripMenuItem_Click( object sender , EventArgs e )
        {
            FontDialog font = new FontDialog ();
            if ( font.ShowDialog ()==DialogResult.OK )
                tabControlHelper1.GetEditor ().Font=font.Font;
        }

        private void expandFoldingMarkersToolStripMenuItem_Click( object sender , EventArgs e )
        {
            tabControlHelper1.GetEditor ().ExpandAllFoldingBlocks ();
        }

        private void collapseFoldingMarkersToolStripMenuItem_Click( object sender , EventArgs e )
        {
            tabControlHelper1.GetEditor ().CollapseAllFoldingBlocks ();
        }

        private void foldingToolStripMenuItem_Click( object sender , EventArgs e )
        {
            foldingToolStripMenuItem.Checked=tabControlHelper1.GetEditor ().ShowFoldingLines=!tabControlHelper1.GetEditor ().ShowFoldingLines;
        }

        private void tagCreatorToolStripMenuItem_Click( object sender , EventArgs e )
        {
            HTMLTagCreatorDialog dialog = new HTMLTagCreatorDialog ();
            dialog.ShowDialog ();

            if ( !string.IsNullOrEmpty (dialog.Tag) )
                tabControlHelper1.GetEditor ().Text+=dialog.Tag;
            else
                return;
        }

        private void metaCreatorToolStripMenuItem_Click( object sender , EventArgs e )
        {
            using ( var form = new MetaTagCreator () )
            {
                form.ShowDialog ();

                if ( form.Meta!=null )
                {
                    var quote = @"""";
                    var stringHTML = "<meta name="+quote+form.Meta.Name+quote+" content="+quote+form.Meta.Context+quote+"/>";
                    tabControlHelper1.GetEditor ().Text+=stringHTML;
                }
            }
        }

        private void insertSingleCommentToolStripMenuItem_Click( object sender , EventArgs e )
        {
            CommentsHelper.ApplySingleComment (tabControlHelper1.GetEditor ().Language , tabControlHelper1.GetEditor ());
        }

        private void insertMultilinedCommentToolStripMenuItem_Click( object sender , EventArgs e )
        {
            CommentsHelper.ApplyMultilinedComment (tabControlHelper1.GetEditor ().Language , tabControlHelper1.GetEditor ());
        }

        private void uncommentToolStripMenuItem_Click( object sender , EventArgs e )
        {
            CommentsHelper.Uncomment (tabControlHelper1.GetEditor ());
        }

        private void commentLineToolStripMenuItem_Click( object sender , EventArgs e )
        {
            CommentsHelper.ApplyCommentOnLine (tabControlHelper1.GetEditor ().Language , tabControlHelper1.GetEditor ());
        }

        private void textToUpperToolStripMenuItem_Click( object sender , EventArgs e )
        {
            ConvertHelper.TextToUpper (tabControlHelper1.GetEditor ());
        }

        private void textToLowerToolStripMenuItem_Click( object sender , EventArgs e )
        {
            ConvertHelper.TextToLower (tabControlHelper1.GetEditor ());
        }

        private void textToTitleCaseToolStripMenuItem_Click( object sender , EventArgs e )
        {
            ConvertHelper.TextToTitle (tabControlHelper1.GetEditor ());
        }

        private void textToSentenceCaseToolStripMenuItem_Click( object sender , EventArgs e )
        {
            ConvertHelper.TextToSentence (tabControlHelper1.GetEditor ());
        }

        private void panel2_Paint( object sender , PaintEventArgs e )
        {
            //e.Graphics.FillRectangle (new SolidBrush (ColorTranslator.FromHtml ("#e3e3e3")) ,
            //    new Rectangle (0 , panel2.Height-2 , panel2.Width-1 , 2));
        }

        private void listBox1_DrawItem( object sender , DrawItemEventArgs e )
        {
            try
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
                                  new Rectangle (e.Bounds.X +10, e.Bounds.Y-6 , e.Bounds.Width , e.Bounds.Height) ,
                    new StringFormat ()
                    {
                        Alignment=StringAlignment.Near ,
                        LineAlignment=StringAlignment.Center
                    });
                FileInfo info = FileInfos[ e.Index ];
                e.Graphics.DrawString (
                   info.Length / 1024 + "KB",

                   new Font ("Segoe UI Light" , 8) ,
                   new SolidBrush (Color.Gray) ,
                   new Rectangle (e.Bounds.X +10 , e.Bounds.Y+8 , e.Bounds.Width , e.Bounds.Height) ,
                   new StringFormat ()
                   {
                       Alignment=StringAlignment.Near ,
                       LineAlignment=StringAlignment.Center
                   });
            }
            catch
            {
                ;
            }
        }

        public List<FileInfo> FileInfos = new List<FileInfo> ();
        private void openFolderToolStripMenuItem_Click( object sender , EventArgs e )
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog ();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                if ( string.IsNullOrWhiteSpace (dialog.SelectedPath) )
                    return;
                listBox1.Items.Clear ();
                FileInfos.Clear ();
                foreach ( FileInfo dir in new DirectoryInfo (dialog.SelectedPath).GetFiles () )
                {
                    listBox1.Items.Add (Path.GetFileName (dir.FullName));
                    FileInfos.Add (dir);
                    panel1.Visible=true;
                    splitter1.Visible=true;
                }
            }
        }

        private void folderExplorerToolStripMenuItem_Click( object sender , EventArgs e )
        {
            panel1.Visible=true;
            splitter1.Visible=true;
            panel4.Visible=false;
            splitter3.Visible=false;
        }

        private void label2_Click( object sender , EventArgs e )
        {
            panel1.Visible=false;
            splitter1.Visible=false;
            listBox1.Items.Clear ();
        }

        private void listBox1_SelectedIndexChanged( object sender , EventArgs e )
        {
            var fileInfo = FileInfos[ listBox1.SelectedIndex ];
            tabControlHelper1.AddTab (fileInfo.FullName);
        }

        private void splitter1_SplitterMoved( object sender , SplitterEventArgs e )
        {

        }

        private void panel3_Paint( object sender , PaintEventArgs e )
        {
           
        }

        private void timer1_Tick( object sender , EventArgs e )
        {
            try
            {
                toolStripStatusLabel4.Text="Line: "+tabControlHelper1.GetEditor ().LinesCount.ToString ()+" , Column: "+
              tabControlHelper1.GetEditor ().Selection.Bounds.iEndChar.ToString ();

                tabControlHelper1.GetEditor ().MouseMove+=( s , a ) =>
                {
                    toolStripStatusLabel5.Text="X: "+a.X+" , Y: "+a.Y;
                };
                toolStripStatusLabel6.Text="Char Start: "+tabControlHelper1.GetEditor ().Selection.Bounds.iStartChar+
                                             " , Char End: "+tabControlHelper1.GetEditor ().Selection.Bounds.iEndChar;
                toolStripStatusLabel1.Text=this.Text.Replace ("SharpEdit - " , "");

                tabControlHelper1.GetEditor ().ContextMenuStrip=materialContextMenuStrip1;
            }
            catch
            {
                ;
            }
        }

        private void statusStrip1_Paint( object sender , PaintEventArgs e )
        {
            e.Graphics.FillRectangle (new SolidBrush (ColorTranslator.FromHtml ("233,233,233")) , new Rectangle (0 , 0 , statusStrip1.Width , statusStrip1.Height));
            e.Graphics.FillRectangle (new SolidBrush (ColorTranslator.FromHtml ("#e3e3e3")) , new Rectangle (0 , 0 , statusStrip1.Width-1 , 1));
            e.Graphics.FillRectangle (new SolidBrush (ColorTranslator.FromHtml ("#d3d3d3")) , new Rectangle (toolStripStatusLabel4.Bounds.X , 0 , 1 , statusStrip1.Height));
            e.Graphics.FillRectangle (new SolidBrush (ColorTranslator.FromHtml ("#d3d3d3")) , new Rectangle (toolStripStatusLabel5.Bounds.X , 0 , 1 , statusStrip1.Height));
            e.Graphics.FillRectangle (new SolidBrush (ColorTranslator.FromHtml ("#d3d3d3")) , new Rectangle (toolStripStatusLabel6.Bounds.X , 0 , 1 , statusStrip1.Height));
        }

        private void statusStrip1_ItemClicked( object sender , ToolStripItemClickedEventArgs e )
        {

        }

        private void materialTabControl1_MouseMove( object sender , MouseEventArgs e )
        {
            
        }

        private void cMDToolStripMenuItem_Click( object sender , EventArgs e )
        {
            try
            {
                System.Diagnostics.Process.Start ("cmd.exe" , Path.GetDirectoryName (tabControlHelper1.TabControl.SelectedTab.Tag.ToString ()));
            }
            catch
            {
                ;
            }

        }

        private void explorerToolStripMenuItem_Click( object sender , EventArgs e )
        {
            try
            {
                System.Diagnostics.Process.Start (Path.GetDirectoryName (tabControlHelper1.TabControl.SelectedTab.Tag.ToString ()));
            }
            catch
            {
                ;
            }
        }

        private void rulerToolStripMenuItem_Click( object sender , EventArgs e )
        {
            rulerToolStripMenuItem.Checked=tabControlHelper1.GetRuler ().Visible=!tabControlHelper1.GetRuler ().Visible;
        }

        private void documentMapToolStripMenuItem_Click( object sender , EventArgs e )
        {
            documentMapToolStripMenuItem.Checked=tabControlHelper1.GetMap ().Visible=!tabControlHelper1.GetMap ().Visible;
            tabControlHelper1.GetEditor ().ShowScrollBars=!tabControlHelper1.GetMap ().Visible;
        }

        private void statusBarToolStripMenuItem_Click( object sender , EventArgs e )
        {
            statusBarToolStripMenuItem.Checked=statusStrip1.Visible=!statusStrip1.Visible;
        }

        private void closeTabToolStripMenuItem_Click( object sender , EventArgs e )
        {
            materialTabControl1.TabPages.Remove (tabControlHelper1.TabControl.SelectedTab);
            materialTabSelector1.Refresh ();
        }

        private void closeAllTabsToolStripMenuItem_Click( object sender , EventArgs e )
        {
            for(int i = 0; i <  materialTabControl1.TabPages.Count-1; i++)
            {
                materialTabControl1.TabPages.Remove (tabControlHelper1.TabControl.TabPages[ i ]);
                materialTabSelector1.Refresh ();
            }
        }

        private void addTabsToolStripMenuItem_Click( object sender , EventArgs e )
        {
            tabControlHelper1.AddTab ("Untitled.txt");
        }

        private void toolStripMenuItem20_Click( object sender , EventArgs e )
        {
            toolStripMenuItem20.Checked=tabControlHelper1.GetEditor ().ShowWhiteSpaces=!tabControlHelper1.GetEditor ().ShowWhiteSpaces;
        }

        private void emptyLineMarkerToolStripMenuItem_Click( object sender , EventArgs e )
        {
            emptyLineMarkerToolStripMenuItem.Checked=tabControlHelper1.GetEditor ().ShowEmptyLines=!tabControlHelper1.GetEditor ().ShowEmptyLines;
        }

        private void foldingToolStripMenuItem1_Click( object sender , EventArgs e )
        {
            foldingToolStripMenuItem1.Checked=tabControlHelper1.GetEditor ().ShowFoldingLines=!tabControlHelper1.GetEditor ().ShowFoldingLines;
        }

        private void lineNumbersToolStripMenuItem_Click( object sender , EventArgs e )
        {
            lineNumbersToolStripMenuItem.Checked=tabControlHelper1.GetEditor ().ShowLineNumbers=!tabControlHelper1.GetEditor ().ShowLineNumbers;
        }

        private void virtualSpacesToolStripMenuItem_Click( object sender , EventArgs e )
        {
            virtualSpacesToolStripMenuItem.Checked=tabControlHelper1.GetEditor ().VirtualSpace=!tabControlHelper1.GetEditor ().VirtualSpace;
        }

        private void applicationLogToolStripMenuItem_Click( object sender , EventArgs e )
        {
        }

        bool fullscreen = false;
        private void fullscreenToolStripMenuItem_Click( object sender , EventArgs e )
        {
            fullscreen=!fullscreen;

            if(fullscreen)
            {
                this.FormBorderStyle=FormBorderStyle.None;
                this.WindowState=FormWindowState.Maximized;
            }
            else
            {
                this.FormBorderStyle=FormBorderStyle.Sizable;
                this.WindowState=FormWindowState.Normal;
            }

            fullscreenToolStripMenuItem.Checked=fullscreen;
        }

        private void insertLineBeforeToolStripMenuItem_Click( object sender , EventArgs e )
        {
            var text = tabControlHelper1.GetEditor ().SelectedText;
            tabControlHelper1.GetEditor ().SelectedText="\n"+text;
        }

        private void insertLineAfterToolStripMenuItem_Click( object sender , EventArgs e )
        {
            tabControlHelper1.GetEditor ().SelectedText+="\n";
        }

        private void toolStripMenuItem26_Click( object sender , EventArgs e )
        {
                    }

        private void wordWrapToolStripMenuItem_Click_1( object sender , EventArgs e )
        {
           
        }

        private void charWrapControlWidthToolStripMenuItem_Click( object sender , EventArgs e )
        {
            charWrapPreferredWidthToolStripMenuItem.Checked=false;
            wordWrapPreferredWidthToolStripMenuItem.Checked=false;
            wordWrapControlWidthToolStripMenuItem.Checked=false;
            charWrapControlWidthToolStripMenuItem.Checked=true;
            tabControlHelper1.GetEditor ().WordWrapMode=SharpEditCore.TextEditor.WordWrapping.WordWrapMode.CharWrapControlWidth;
        }

        private void charWrapPreferredWidthToolStripMenuItem_Click( object sender , EventArgs e )
        {
            charWrapPreferredWidthToolStripMenuItem.Checked=true;
            wordWrapPreferredWidthToolStripMenuItem.Checked=false;
            wordWrapControlWidthToolStripMenuItem.Checked=false;
            charWrapControlWidthToolStripMenuItem.Checked=false;
            tabControlHelper1.GetEditor ().WordWrapMode=SharpEditCore.TextEditor.WordWrapping.WordWrapMode.CharWrapPreferredWidth;
        }

        private void wordWrapControlWidthToolStripMenuItem_Click( object sender , EventArgs e )
        {
            charWrapPreferredWidthToolStripMenuItem.Checked=false;
            wordWrapPreferredWidthToolStripMenuItem.Checked=false;
            wordWrapControlWidthToolStripMenuItem.Checked=true;
            charWrapControlWidthToolStripMenuItem.Checked=false;
            tabControlHelper1.GetEditor ().WordWrapMode=SharpEditCore.TextEditor.WordWrapping.WordWrapMode.WordWrapControlWidth;
        }

        private void wordWrapPreferredWidthToolStripMenuItem_Click( object sender , EventArgs e )
        {
            charWrapPreferredWidthToolStripMenuItem.Checked=false;
            wordWrapPreferredWidthToolStripMenuItem.Checked=true;
            wordWrapControlWidthToolStripMenuItem.Checked=false;
            charWrapControlWidthToolStripMenuItem.Checked=false;
            tabControlHelper1.GetEditor ().WordWrapMode=SharpEditCore.TextEditor.WordWrapping.WordWrapMode.WordWrapPreferredWidth;
        }

        private void wordWrapModeToolStripMenuItem_Click( object sender , EventArgs e )
        {
            wordWrapModeToolStripMenuItem.Checked=tabControlHelper1.GetEditor ().WordWrap=!tabControlHelper1.GetEditor ().WordWrap;
        }

        private void autoWrapIndentToolStripMenuItem_Click( object sender , EventArgs e )
        {
            autoWrapIndentToolStripMenuItem.Checked=tabControlHelper1.GetEditor ().WordWrapAutoIndent=!tabControlHelper1.GetEditor ().WordWrapAutoIndent;
        }

        private void jumpToNextLineToolStripMenuItem_Click( object sender , EventArgs e )
        {
            tabControlHelper1.GetEditor ().Selection=new SharpEditCore.TextEditor.Range (tabControlHelper1.GetEditor () , tabControlHelper1.GetEditor ().Selection.Bounds.iStartLine+1);
        }

        private void jumpToLastLineToolStripMenuItem_Click( object sender , EventArgs e )
        {
            tabControlHelper1.GetEditor ().Selection=new SharpEditCore.TextEditor.Range (tabControlHelper1.GetEditor () , tabControlHelper1.GetEditor().LinesCount-1);
        }

        private void jumpToPreviousLineToolStripMenuItem_Click( object sender , EventArgs e )
        {
            tabControlHelper1.GetEditor ().Selection=new SharpEditCore.TextEditor.Range (tabControlHelper1.GetEditor () , tabControlHelper1.GetEditor ().Selection.Bounds.iStartLine-1);
        }

        private void showGotoDialogToolStripMenuItem_Click( object sender , EventArgs e )
        {
            tabControlHelper1.GetEditor ().ShowGoToDialog ();
        }

        private void jumpToPreviousTabToolStripMenuItem_Click( object sender , EventArgs e )
        {
            try
            {
                tabControlHelper1.TabControl.SelectedIndex=tabControlHelper1.TabControl.SelectedIndex-1;
            }
            catch
            {
                ;
            }
        }

        private void jumpToNextTabToolStripMenuItem_Click( object sender , EventArgs e )
        {
            try
            {
                tabControlHelper1.TabControl.SelectedIndex=tabControlHelper1.TabControl.SelectedIndex+1;
            }
            catch
            {
                ;
            }
        }

        private void autoIndentToolStripMenuItem1_Click( object sender , EventArgs e )
        {
            autoIndentToolStripMenuItem1.Checked=tabControlHelper1.GetEditor ().AutoIndent=!tabControlHelper1.GetEditor ().AutoIndent;
        }

        private void autoIndentCharsToolStripMenuItem_Click( object sender , EventArgs e )
        {
            autoIndentCharsToolStripMenuItem.Checked=tabControlHelper1.GetEditor ().AutoIndentChars=!tabControlHelper1.GetEditor ().AutoIndentChars;
        }

        private void autoIndentExistingLinesToolStripMenuItem_Click( object sender , EventArgs e )
        {
            autoIndentExistingLinesToolStripMenuItem.Checked=tabControlHelper1.GetEditor ().AutoIndentExistingLines=!tabControlHelper1.GetEditor ().AutoIndentExistingLines;
        }

        private void openProjectToolStripMenuItem_Click( object sender , EventArgs e )
        {
            Loading loadingDialog = new SharpEdit.Loading ();
         
            FolderBrowserDialog browser = new FolderBrowserDialog ();
            if ( browser.ShowDialog ()==DialogResult.OK )
            {
                loadingDialog.Show();
                TreeNode node = new TreeNode (Path.GetFileName (browser.SelectedPath));
                node.Tag="DIR";
                ProjectDirectory projDirectory = new ProjectDirectory (browser.SelectedPath);
                foreach ( IProjectDirectoryEntry entry in projDirectory.Entrys )
                {
                    var node0 = new TreeNode (Path.GetFileName (entry.FullPath)) { Tag="DIR/" + entry.FullPath };
                    node.Nodes.Add (node0);

                    foreach ( ITextFile file in entry.Files )
                    {
                        var node1 = new TreeNode (Path.GetFileName (file.FullPath)) { Tag=file.FullPath };
                        node0.Nodes.Add (node1);
                        loadingDialog.materialLabel1.Text="Loading "+file.Name;
                        loadingDialog.Refresh ();
                    }
                }
                foreach ( ITextFile file in projDirectory.Files )
                {
                    var node1 = new TreeNode (Path.GetFileName (file.FullPath)) { Tag=file.FullPath };
                    node.Nodes.Add (node1);
                    loadingDialog.materialLabel1.Text="Loading "+file.Name;
                    loadingDialog.Refresh ();
                }
                loadingDialog.Close ();
                panel1.Visible=false;
                splitter1.Visible=false;
                panel4.Visible=true;
                splitter3.Visible=true;

                treeView1.Nodes.Add (node);
            }

        }

        private void treeView1_AfterSelect( object sender , TreeViewEventArgs e )
        {
            var node = e.Node;
            var file = (string)node.Tag;

            if ( !file.Contains ("DIR") )
            {
                tabControlHelper1.AddTab (file);
            }
        }

        private void panel5_Paint( object sender , PaintEventArgs e )
        {
            //e.Graphics.FillRectangle (new SolidBrush (ColorTranslator.FromHtml ("#e3e3e3")) ,
            //  new Rectangle (0 , panel5.Height-2 , panel5.Width-1 , 2));
        }

        private void projectExplorerToolStripMenuItem_Click( object sender , EventArgs e )
        {
            panel1.Visible=false;
            splitter1.Visible=false;
            panel4.Visible=true;
            splitter3.Visible=true;
        }

        private void label3_Click( object sender , EventArgs e )
        {
            panel1.Visible=false;
            splitter1.Visible=false;
            panel4.Visible=false;
            splitter3.Visible=false;

            treeView1.Nodes.Clear ();
        }
        void refreshTabContextMenu()
        {
            materialContextMenuStrip3.Items.Clear ();
            for(int i = 0; i <  materialTabControl1.TabPages.Count -1; i++ )
            {
                var page = materialTabControl1.TabPages[ i ];
              try
                {
                    materialContextMenuStrip3.Items.Add (
                  page.Text , Icon.ExtractAssociatedIcon (page.Tag.ToString ()).ToBitmap ());
                }
                catch ( Exception )
                {
                    materialContextMenuStrip3.Items.Add (
            page.Text);
                }
            }
        }
        private void zoomInToolStripMenuItem_Click( object sender , EventArgs e )
        {
            tabControlHelper1.GetEditor ().Zoom+=1;
        }

        private void zoomOutToolStripMenuItem_Click( object sender , EventArgs e )
        {
            tabControlHelper1.GetEditor ().Zoom-=1;
        }

        private void resetZoomToolStripMenuItem_Click( object sender , EventArgs e )
        {
            tabControlHelper1.GetEditor ().Zoom=new TextEditorControl ().Zoom;
        }

        private void wideCaretToolStripMenuItem_Click( object sender , EventArgs e )
        {
            wideCaretToolStripMenuItem.Checked= tabControlHelper1.GetEditor ().WideCaret=!tabControlHelper1.GetEditor ().WideCaret;
        }

        private void lineEndingMarkerToolStripMenuItem_Click( object sender , EventArgs e )
        {
            lineEndingMarkerToolStripMenuItem.Checked=tabControlHelper1.GetEditor ().ShowLineEndings=!tabControlHelper1.GetEditor ().ShowLineEndings;
        }

        private void aboutToolStripMenuItem_Click( object sender , EventArgs e )
        {
            new About ().ShowDialog ();
        }

        private void Form1_Shown( object sender , EventArgs e )
        {
            if ( Properties.Settings.Default.ShowWelcome )
            {
                WelcomeDialog dialog = new SharpEdit.WelcomeDialog (this);
                dialog.Show ();
            }
        }

        private void materialTabSelector1_Click( object sender , EventArgs e )
        {

        }

        private void webBrowserToolStripMenuItem_Click( object sender , EventArgs e )
        {
            if ( tabControlHelper1.TabControl.TabCount>0 )
                tabControlHelper1.TabControl.TabPages.Remove (tabControlHelper1.TabControl.TabPages[ tabControlHelper1.TabControl.TabPages.Count-1 ]);
            WebBrowser browser = new WebBrowser ();
            TabPage page = new TabPage ();
            browser.Dock=DockStyle.Fill;
            page.Text="Web Browser";
            page.Controls.Add (browser);
            tabControlHelper1.TabControl.TabPages.Add (page);
            tabControlHelper1.TabControl.TabPages.Add (new TabPage () { Text="+" });
            tabControlHelper1.TabControl.SelectedTab=page;
        }

        private void pictureBox1_Click( object sender , EventArgs e )
        {
            materialContextMenuStrip3.Show (pictureBox1, pictureBox1.Location);
        }

        private void iISViewerToolStripMenuItem_Click( object sender , EventArgs e )
        {
            panel6.Visible=true;
            splitter4.Visible=true;
        }

        private void label5_Click( object sender , EventArgs e )
        {
            panel6.Visible=false;
            splitter4.Visible=false;
        }

        private void welcomeDialogToolStripMenuItem_Click( object sender , EventArgs e )
        {
            WelcomeDialog dialog = new WelcomeDialog (this);
            dialog.ShowDialog ();
        }
    }
}
