using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DesignPatterns.Behavioral.Memento
{
    //Originator
    public class Editor
    {
        public string Title { get; set; } = String.Empty;
        public string Content { get; set; } = String.Empty;

        public EditorState CreateState()
        {
            return new EditorState(Title, Content);
        }
        public void Restore(EditorState editorState)
        {
            Title = editorState.GetTitle();
            Content = editorState.GetContent();
        }
    }
}
