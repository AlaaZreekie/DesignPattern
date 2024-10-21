using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DesignPatterns.Behavioral._ٍState.Good
{
    public class PublishedState : IState
    {
        private Document _document;
        public PublishedState(Document document)
        {
            _document = document;
        }
        public void Publish()
        {
            //we are already published
            return;
        }
    }
}
