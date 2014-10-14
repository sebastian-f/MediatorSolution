using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorLib
{
    public class Screen
    {
        ComputerSystem computerSystem;
        bool screenOn;

        public Screen(ComputerSystem computerSystem)
        {
            this.computerSystem = computerSystem;
            screenOn = false;
            computerSystem.RegisterScreen(this);
        }
        public void TurnOn()
        {
            screenOn = true;
            Debug.WriteLine("Screen.TurnOn()");
        }
        public void TurnOff()
        {
            screenOn = false;
            Debug.WriteLine("Screen.TurnOff()");
        }
        public void DisplayCharacter(char key)
        {
            Console.WriteLine(key);
            Debug.WriteLine("Screen.DisplayCharacter()");
        }

    }
}
