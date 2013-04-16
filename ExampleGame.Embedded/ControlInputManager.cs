using ExampleGame.Common;
using Microsoft.Xna.Framework.Input;
using MonoGameWinForms;

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
