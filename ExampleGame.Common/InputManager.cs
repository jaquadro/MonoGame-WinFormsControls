using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;

namespace ExampleGame.Common
{
    public static class InputManager
    {
        private static InputManagerImplementation _implementation;

        public static void Initialize (InputManagerImplementation implementation)
        {
            _implementation = implementation;
        }

        public static KeyboardState GetKeyboardState ()
        {
            if (_implementation == null)
                return new KeyboardState();

            return _implementation.GetKeyboardState();
        }
    }

    public abstract class InputManagerImplementation 
    {
        public abstract KeyboardState GetKeyboardState ();
    }
}
