using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpEdit.Helpers
{
    public class MaterialRenderer : ToolStripRenderer
    {
        protected override void OnRenderMenuItemBackground( ToolStripItemRenderEventArgs e )
        {
            e.Graphics.Clear (Color.FromArgb (233 , 233 , 233));
            e.Item.ForeColor=ColorTranslator.FromHtml ("122,122,122");
            if (e.Item.Selected)
            {
                e.Graphics.FillRectangle (new SolidBrush (ColorTranslator.FromHtml ("white")) , e.Item.Bounds);
                e.Item.ForeColor=Color.Black;
            }
            else
            {
            }
 
        }

        protected override void OnRenderButtonBackground( ToolStripItemRenderEventArgs e )
        {
            e.Graphics.Clear (Color.FromArgb (233 , 233 , 233));

            if ( e.Item.Selected )
            {
                e.Graphics.FillRectangle (new SolidBrush (ColorTranslator.FromHtml ("#white")) , e.Item.Bounds);
                e.Item.ForeColor=Color.Black;
            }
            else
            {
                e.Item.ForeColor=ColorTranslator.FromHtml ("122,122,122");
                //e.Graphics.FillRectangle (new SolidBrush (ColorTranslator.FromHtml ("white")) , e.Item.Bounds);
            }
        }

        protected override void OnRenderItemBackground( ToolStripItemRenderEventArgs e )
        {
            if ( e.Item.Selected )
            {
                e.Graphics.FillRectangle (new SolidBrush (ColorTranslator.FromHtml ("#white")) , e.Item.Bounds);
                e.Item.ForeColor=Color.Black;
            }
        }
        protected override void OnRenderToolStripBackground( ToolStripRenderEventArgs e )
        {
            e.Graphics.FillRectangle (new SolidBrush (Color.White) , e.AffectedBounds);
            base.OnRenderToolStripBackground (e);
        }
    }
}
