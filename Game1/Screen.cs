using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class Screen
    {
        protected ContentManager content;

        public virtual void Initialize() { }
        public virtual void LoadContent()
        {
            content = new ContentManager(ScreenManager.Instance.content.ServiceProvider, "Content");
        }
        public virtual void UnloadContent() { }
        public virtual void Update(GameTime gameTime) { }
        public virtual void Draw(SpriteBatch spriteBatch) { }
    }
}
