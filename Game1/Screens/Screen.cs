using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace Game1.Screens
{
    /// <summary>
    /// Author: Alex
    /// Description: Parent class of all screen classes.
    /// </summary>

    public class Screen
    {
        // ContentManager to be used by all the screens
        protected ContentManager content;

        // Virtual Methods
        public virtual void Initialize() { }
        public virtual void LoadContent()
        {
            // Gets the ContentManager from ScreenManager
            content = new ContentManager(ScreenManager.Instance.content.ServiceProvider, "Content");
        }
        public virtual void UnloadContent() { }
        public virtual void Update(GameTime gameTime) { }
        public virtual void Draw(SpriteBatch spriteBatch) { }
    }
}
