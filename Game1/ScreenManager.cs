using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class ScreenManager
    {
        private static ScreenManager instance;
        private static Screen currentScreen;
        public ContentManager content { get; set; }

        public Screen CurrentScreen
        {
            get
            {
                return currentScreen;
            }

            set
            {
                currentScreen = value;
            }
        }

        public static ScreenManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new ScreenManager();

                    return instance;
            }
        }

        public void Initialize()
        {

        }

        public void LoadContent()
        {

        }

        public void UnloadContent()
        {

        }

        public void Update(GameTime gameTime)
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {

        }
    }
}
