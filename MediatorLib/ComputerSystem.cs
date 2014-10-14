using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorLib
{
    public class ComputerSystem
    {
        Computer computer;
        Keyboard keyboard;
        Screen screen;

        public void RegisterComputer(Computer computer)
        {
            this.computer = computer;
        }

        public void RegisterKeyboard(Keyboard keyboard)
        {
            this.keyboard = keyboard;
        }

        public void RegisterScreen(Screen screen)
        {
            this.screen = screen;
        }

        public void ComputerSwitchedOn()
        {
            keyboard.Enabled();
            screen.TurnOn();
        }

        public void ComputerSwitchedOff()
        {
            keyboard.Disabled();
            screen.TurnOff();
        }

        public void KeyboardKeyPressed(char key)
        {
            screen.DisplayCharacter(key);
        }
    }
}
