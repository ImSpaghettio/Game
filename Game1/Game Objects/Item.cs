using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Game_Objects
{
    public class Item
    {
        public static int max_id = 0;

        private ItemStruct item;

        public Item(ItemStruct item)
        {
            this.item = item;
            max_id++;
            item.id = max_id;
        }

        public Item()
        {
            max_id++;
            item.id = max_id;
            item.uses = 0;
            item.damage = 0;
            item.armor = 0;
            item.name = "";
            item.description = "";
            item.texture = "";
            item.positionX = 0;
            item.positionY = 0;
        }

        public ItemStruct GetItemElement()
        {
            return item;
        }

        public void ShowItem(SpriteBatch sprite_batch)
        {

        }
    }

    public struct ItemStruct
    {
        public int id;
        public int uses;
        public int damage;
        public int armor;
        public string name;
        public string description;
        public string texture;
        public int positionX, positionY;
    }
}
