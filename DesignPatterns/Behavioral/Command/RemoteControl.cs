using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DesignPatterns.Behavioral.Command
{
    internal class RemoteControl
    {
        private ICommand _command;
        public RemoteControl(ICommand command)
        {
            _command = command;
        }

        public void SetCommand(ICommand command) 
        {
            _command = command;
        }

        public void PressBtn()
        {
            _command.Execute();
        }
    }
}
