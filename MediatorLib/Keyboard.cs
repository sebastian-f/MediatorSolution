using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorLib
{
    public class Keyboard
    {
        ComputerSystem computerSystem;

        public Keyboard(ComputerSystem computerSystem)
        {
            this.computerSystem = computerSystem;
            computerSystem.RegisterKeyboard(this);
        }
        public void Enabled()
        {
            Debug.WriteLine("Keyboard.Enabled()");
        }
        public void Disabled()
        {
            Debug.WriteLine("Keyboard.Disabled()");
        }
        public void KeyPressed(char key)
        {
            computerSystem.KeyboardKeyPressed(key);
            Debug.WriteLine("Keyboard.KeyPressed()");
        }
            
    }
}
