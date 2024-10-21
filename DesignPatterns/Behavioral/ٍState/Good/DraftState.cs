using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DesignPatterns.Behavioral._ٍState.Good
{
    public class DraftState : IState
    {
        private Document _document;

        public DraftState(Document document)
        {
            _document = document;
        }
        public void Publish()
        {
            _document.State = new ModerationState(_document);
        }
    }
}
