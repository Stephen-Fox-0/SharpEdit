using SharpEditCore.TextEditor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpEdit.Helpers
{
    public class ConvertHelper
    {
        public static void TextToUpper( TextEditorControl control )
        {
            var text = control.Text;
            control.Text=text.ToUpper ();
        }

        public static void TextToLower( TextEditorControl control )
        {
            var text = control.Text;
            control.Text=text.ToLower ();
        }

        public static void TextToTitle(TextEditorControl control)
        {
            control.TitleCase ();
        }

        public static void TextToSentence(TextEditorControl control)
        {
            control.SentenceCase ();
        }
    }
}
