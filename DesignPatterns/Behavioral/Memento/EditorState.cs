using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DesignPatterns.Behavioral.Memento
{
    public class EditorState
    {
        private readonly string _title;
        private readonly string _content;

        //State meta data when we backup data
        private readonly DateTime _stateCreatedAt;

        public EditorState(string title, string content)
        {
            _content = content;
            _title = title;
            _stateCreatedAt = DateTime.Now;
        }

        public string GetTitle() => _title;
        public string GetContent() => _content;
        public DateTime GetStateCreatedAt() => _stateCreatedAt;
        public string GetName()
        {
            return $"{_stateCreatedAt} / { _title}";
        }
    }
}
