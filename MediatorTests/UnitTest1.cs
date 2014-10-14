using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediatorLib;

namespace MediatorTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestComputerAndKeyboardMethods()
        {
            ComputerSystem computerSystem = new ComputerSystem();
            Computer computer = new Computer(computerSystem);
            Keyboard keyboard = new Keyboard(computerSystem);
            Screen screen = new Screen(computerSystem);

            computer.SwitchOn();
            keyboard.KeyPressed('g');
        }
    }
}
