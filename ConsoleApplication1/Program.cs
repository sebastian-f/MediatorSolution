using MediatorLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputerSystem computerSystem = new ComputerSystem();
            Computer computer = new Computer(computerSystem);
            Keyboard keyboard = new Keyboard(computerSystem);
            Screen screen = new Screen(computerSystem);

            computer.SwitchOn();
            keyboard.KeyPressed('a');
        }
    }
}
