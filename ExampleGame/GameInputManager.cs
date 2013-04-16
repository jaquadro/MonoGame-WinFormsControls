using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExampleGame.Common;
using Microsoft.Xna.Framework.Input;

namespace ExampleGame
{
    class GameInputManager : InputManagerImplementation
    {
        public override KeyboardState GetKeyboardState ()
        {
            return Keyboard.GetState();
        }
    }
}
