using SharpEditCore.Text;
using SharpEditCore.Workspace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpEdit
{
    public partial class WelcomeDialog: Form
    {
        List<FileInfo> FileInfos = new List<FileInfo> ();
        Form1 form;
        public WelcomeDialog(Form1 form)
        {
            InitializeComponent ();
            this.form=form;
            label1.Text="Hey, "+Environment.UserName;
        }

        private void WelcomeDialog_Load( object sender , EventArgs e )
        {
            foreach ( string t in Properties.Settings.Default.Recent.Split ('|') )
            {
                if(!string.IsNullOrWhiteSpace(t))
                {
                    if ( !listBox1.Items.Contains (t) )
                    {
                        listBox1.Items.Add (Path.GetFileName (t));
                        FileInfos.Add (new FileInfo (t));
                    }
                }
            }
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
                                  new Rectangle (e.Bounds.X+10 , e.Bounds.Y-6 , e.Bounds.Width , e.Bounds.Height) ,
                    new StringFormat ()
                    {
                        Alignment=StringAlignment.Near ,
                        LineAlignment=StringAlignment.Center
                    });
                FileInfo info = FileInfos[ e.Index ];
                e.Graphics.DrawString (
                   info.Length/1024+"KB" ,

                   new Font ("Segoe UI Light" , 8) ,
                   new SolidBrush (Color.Gray) ,
                   new Rectangle (e.Bounds.X+10 , e.Bounds.Y+8 , e.Bounds.Width , e.Bounds.Height) ,
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

        private void listBox1_SelectedIndexChanged( object sender , EventArgs e )
        {
            form.tabControlHelper1.AddTab (FileInfos[ listBox1.SelectedIndex ].FullName);
            Close ();
        }

        private void materialFlatButton1_Click( object sender , EventArgs e )
        {
            SharpEditCore.Controls.NewFileDialog fileDialog = new SharpEditCore.Controls.NewFileDialog ();
            fileDialog.Icon=this.Icon;
            fileDialog.Creation+=( a ) =>
            {
                if ( a.SaveFile )
                {
                    using ( var stream = new StreamWriter (a.SaveDestination+"\\"+a.FileName) )
                    {
                        stream.Close ();
                    }
                    form.tabControlHelper1.AddTab (a.SaveDestination+"\\"+a.FileName);
                }

                form.tabControlHelper1.AddTab (a.FileName);
                Close ();
            };
            fileDialog.ShowDialog ();
        }

        private void materialFlatButton2_Click( object sender , EventArgs e )
        {
            OpenFileDialog fileDialog = new OpenFileDialog ();
            if ( fileDialog.ShowDialog ()==DialogResult.OK )
                form.tabControlHelper1.AddTab (fileDialog.FileName);
            Close ();
        }

        private void materialFlatButton4_Click( object sender , EventArgs e )
        {
            Loading loadingDialog = new SharpEdit.Loading ();

            FolderBrowserDialog browser = new FolderBrowserDialog ();
            if ( browser.ShowDialog ()==DialogResult.OK )
            {
                loadingDialog.Show ();
                TreeNode node = new TreeNode (Path.GetFileName (browser.SelectedPath));
                node.Tag="DIR";
                ProjectDirectory projDirectory = new ProjectDirectory (browser.SelectedPath);
                foreach ( IProjectDirectoryEntry entry in projDirectory.Entrys )
                {
                    var node0 = new TreeNode (Path.GetFileName (entry.FullPath)) { Tag="DIR/"+entry.FullPath };
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
                form.panel1.Visible=false;
                form.splitter1.Visible=false;
                form.panel4.Visible=true;
                form.splitter3.Visible=true;

                form.treeView1.Nodes.Add (node);
            }
            Close ();
        }

        private void materialFlatButton3_Click( object sender , EventArgs e )
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog ();
            if ( dialog.ShowDialog ()==DialogResult.OK )
            {
                if ( string.IsNullOrWhiteSpace (dialog.SelectedPath) )
                    return;
                form.listBox1.Items.Clear ();
                form.FileInfos.Clear ();
                foreach ( FileInfo dir in new DirectoryInfo (dialog.SelectedPath).GetFiles () )
                {
                    form.listBox1.Items.Add (Path.GetFileName (dir.FullName));
                    form.FileInfos.Add (dir);
                    form.panel1.Visible=true;
                    form.splitter1.Visible=true;
                }
            }
            Close ();
        }

        private void materialCheckBox1_CheckedChanged( object sender , EventArgs e )
        {
            Properties.Settings.Default.ShowWelcome=materialCheckBox1.Checked;
            Properties.Settings.Default.Save ();
        }

        private void label3_Click( object sender , EventArgs e )
        {
            Close ();
        }

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        const int CS_DROPSHADOW = 0x20000;
        //        CreateParams cp = base.CreateParams;
        //        cp.ClassStyle|=CS_DROPSHADOW;
        //        return cp;
        //    }
        //}
    }
}
