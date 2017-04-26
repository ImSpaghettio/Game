using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Game1.Managing_Classes;
using Game1.Tools;

namespace Game1.Screens
{
    public class GameScreen : Screen
    {
        private Inventory inv;
        XmlManager<Inventory> inv_xml;

        public override void Initialize()
        {
            inv = new Inventory();
            inv.Initialize();
            inv_xml = new XmlManager<Inventory>();
            inv_xml.Type = inv.type;
            inv_xml.Save("../../../../Xml/Inventory.xml", inv);
            base.Initialize();
        }

        public override void LoadContent()
        {
            base.LoadContent();
        }

        public override void UnloadContent()
        {
            base.UnloadContent();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }
    }
}
