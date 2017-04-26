using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Screens
{
    /// <summary>
    /// Author: Alex
    /// Description: Manages all screen classes, creates screen
    /// classes and switches whixh screen is loaded and displayed.
    /// </summary>

    public class ScreenManager
    {
        private static ScreenManager instance;

        // The current screen that is loaded and dsplayed
        public static Screen currentScreen = new GameScreen();

        // ContentManager item
        public ContentManager content { get; private set; }

        // The public static ScreenManager instance that is used by the Game1 class
        //If the instance is not initialized then it will be initialized
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
            currentScreen.Initialize();
        }

        public void LoadContent(ContentManager Content)
        {
            content = Content;
            currentScreen.LoadContent();
        }

        public void UnloadContent()
        {
            currentScreen.UnloadContent();
        }

        public void Update(GameTime gameTime)
        {
            currentScreen.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            currentScreen.Draw(spriteBatch);
        }
    }
}
