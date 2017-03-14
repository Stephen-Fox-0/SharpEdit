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
    public partial class MetaTagCreator: Form
    {
        public MetaTagCreator()
        {
            InitializeComponent ();
        }

        private void materialFlatButton2_Click( object sender , EventArgs e )
        {
            Close ();
        }

        public MetaTag Meta = null;

        private void materialFlatButton1_Click( object sender , EventArgs e )
        {
            this.Meta=new SharpEdit.MetaTag ();
            this.Meta.Name=materialSingleLineTextField1.Text;
            this.Meta.Context=materialSingleLineTextField2.Text;
            Close ();
        }
    }
}
