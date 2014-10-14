using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorLib
{
    public class Computer
    {
        ComputerSystem computerSystem;
        bool computerOn;

        public Computer(ComputerSystem computerSystem)
        {
            this.computerSystem = computerSystem;
            computerOn = false;
            computerSystem.RegisterComputer(this);
        }
        public void SwitchOn()
        {
            computerSystem.ComputerSwitchedOn();
            computerOn = true;
            Debug.WriteLine("Computer.SwitchOn()");
        }

        public void SwitchOff()
        {
            computerSystem.ComputerSwitchedOff();
            computerOn = false;
            Debug.WriteLine("Computer.SwitchOff()");
        }
    }
}
