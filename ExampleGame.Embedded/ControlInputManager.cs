using ExampleGame.Common;
using Microsoft.Xna.Framework.Input;
using MGWinForms;

namespace ExampleGame
{
    class ControlInputManager : InputManagerImplementation
    {
        public override KeyboardState GetKeyboardState ()
        {
            return ControlKeyboard.GetState();
        }
    }
}
