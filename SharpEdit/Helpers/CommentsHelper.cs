using SharpEditCore.TextEditor;
using SharpEditCore.TextEditor.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpEdit.Helpers
{
    public class CommentsHelper
    {
        public static void ApplySingleComment( Language language , TextEditorControl control )
        {
            var selectedText = control.SelectedText;
            if ( language==Language.Cpp||language==Language.CSharp||language==Language.Css||language==Language.JS||language==Language.Java||language==Language.ObjectiveC||language==Language.TypeScript
                ||language==Language.PHP )
            {
                control.SelectedText+="// insert your comment";
            }
            if ( language==Language.Lua||language==Language.VB )
            {
                control.SelectedText+="' insert your comment";
            }
            if ( language==Language.HTML||language==Language.XML )
            {
                control.SelectedText+="<!-- insert your comment-->";
            }
        }

        public static void ApplyCommentOnLine( Language language , TextEditorControl control )
        {
            var selectedText = control.SelectedText;
            if ( language==Language.Cpp||language==Language.CSharp||language==Language.Css||language==Language.JS||language==Language.Java||language==Language.ObjectiveC||language==Language.TypeScript
           ||language==Language.PHP )
            {
                control.SelectedText="/*" +selectedText+ "*/";
            }
            if ( language==Language.Lua||language==Language.VB )
            {
                control.SelectedText+="'''" +selectedText;
            }
            if ( language==Language.HTML||language==Language.XML )
            {
                control.SelectedText+="<!--" +selectedText + "-->";
            }
        }


        public static void ApplyMultilinedComment( Language language , TextEditorControl control )
        {
            var selectedText = control.SelectedText;
            if ( language==Language.Cpp||language==Language.CSharp||language==Language.Css||language==Language.JS||language==Language.Java||language==Language.ObjectiveC||language==Language.TypeScript
           ||language==Language.PHP )
            {
                control.SelectedText="/**/";
            }
            if ( language==Language.Lua||language==Language.VB )
            {
                control.SelectedText+="'''";
            }
            if ( language==Language.HTML||language==Language.XML )
            {
                control.SelectedText+="<!---->";
            }
        }
        public static void Uncomment( TextEditorControl control )
        {
            var selectedText = control.SelectedText;
            control.SelectedText=selectedText.Replace ("/*" , "")
                                               .Replace ("*/" , "")
                                               .Replace ("'''" , "")
                                               .Replace ("'" , "")
                                               .Replace ("<!--" , "")
                                               .Replace ("-->", "");
        }
    }
}
