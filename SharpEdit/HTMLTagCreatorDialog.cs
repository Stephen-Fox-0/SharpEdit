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
    public partial class HTMLTagCreatorDialog: Form
    {
        public HTMLTagCreatorDialog()
        {
            InitializeComponent ();
        }
        public new string Tag { get; private set; }
        private void materialFlatButton1_Click( object sender , EventArgs e )
        {
            var quote = @"""";
            if(materialRadioButton1.Checked)
            {
                Tag="<"+materialSingleLineTextField1.Text+" id="+quote+materialSingleLineTextField2.Text+quote+" class="+quote+materialSingleLineTextField3.Text+quote+"></"+materialSingleLineTextField1.Text+">";
            }
            else
            {
                Tag="<"+materialSingleLineTextField1.Text+" id="+quote+materialSingleLineTextField2.Text+quote+" class="+quote+materialSingleLineTextField3.Text+quote+">";
            }
            Close ();
        }

        private void materialFlatButton2_Click( object sender , EventArgs e )
        {
            Close ();
        }
    }
}
