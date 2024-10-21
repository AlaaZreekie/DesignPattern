using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DesignPatterns.Behavioral.Command
{
    public interface ICommand
    {
        void Execute();
    }
}

//this maybe different from the theory
//because the invoker and the reciver
//are implemented inside the file not in seperated files so we have to implement the code from scratch to folow the theory
