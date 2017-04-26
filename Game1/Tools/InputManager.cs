using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework.Input;

using System.Windows.Input;

namespace Game1.Tools
{
    public static class InputManager
    {
        private static KeyboardState key_state;
        private static KeyboardState prev_key_state;

        public static Keys[] KeyDown()
        {
            return key_state.GetPressedKeys();
        }

        // Returns an array of all pressed keys
        public static Keys[] KeyPress()
        {
            List<Keys> list_pressed_keys = new List<Keys>();

            foreach (Keys k in key_state.GetPressedKeys())
            {
                if (prev_key_state.IsKeyUp(k))
                {
                    list_pressed_keys.Add(k);
                }
            }

            return list_pressed_keys.ToArray();
        }

        // Checks if the key sent is pressed and returns true of false
        public static bool IsKeyPressed(Keys k)
        {
            if (KeyPress().ToList().Exists(key => key == k))
                return true;

            return false;
        }

        // Checks if the key sent is down and returns true or false
        public static bool IsKeyDown(Keys k)
        {
            if (KeyDown().ToList().Exists(key => key == k))
                return true;

            return false;
        }

        // Returns a string of the keys typed
        public static string KeyTyped()
        {
            string Typed = "";

            foreach(Keys k in KeyPress())
            {
                if (IsKeyDown(Keys.LeftShift) || IsKeyDown(Keys.RightShift))
                    Typed += k.ToString();
                else Typed += k.ToString().ToLower();
            }

            return Typed;
        }

        // Updates inputmanager class
        public static void Update()
        {
            prev_key_state = key_state;
            key_state = Keyboard.GetState();
        }
    }
}
