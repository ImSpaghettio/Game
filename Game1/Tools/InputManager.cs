using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

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

        public static string KeyTyped()
        {
            string Typed = "";

            foreach(Keys k in KeyPress())
            {
                Typed += k.ToString();
            }

            return Typed;
        }

        public static void Update()
        {
            prev_key_state = key_state;
            key_state = Keyboard.GetState();
        }
    }
}
