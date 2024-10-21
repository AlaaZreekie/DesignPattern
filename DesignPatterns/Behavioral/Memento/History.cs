using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DesignPatterns.Behavioral.Memento
{
    public class History
    {
        private List<EditorState> _state = new List<EditorState>();
        private Editor _editor;

        public History(Editor editor)
        {
            _editor = editor;
        }

        public void Backup()
        {
            _state.Add(_editor.CreateState());
        }

        public void Undo() 
        {
            if (_state.Count == 0)
                return;

            EditorState prevState = _state.Last();
            _state.Remove(prevState);
            _editor.Restore(prevState);
        }

        public void ShowHistory()
        {
            _state.Select(state => state.GetName());
        }
    }
}
