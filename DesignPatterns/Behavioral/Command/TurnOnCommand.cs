using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DesignPatterns.Behavioral.Command
{
    public class TurnOnCommand:ICommand
    {
        private Light _light;
        public TurnOnCommand(Light light)
        {
            _light = light;
        }
    

        public void Execute()
        {
            _light.TurnOn();
        }
    }
}
