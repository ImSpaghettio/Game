using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Game1.Tools;
using Game1.Game_Objects;
using System.Xml.Serialization;
using Microsoft.Xna.Framework.Content;

namespace Game1.Managing_Classes
{
    public class Inventory
    {
        [XmlIgnore]
        public Type type;

        [XmlElement("inventory")]
        public List<ItemStruct> item_struct;

        [XmlIgnore]
        public Item[,] inventory;

        public int hi = 3;

        public Inventory()
        {
            type = GetType();
        }

        public void Initialize()
        {
            item_struct = new List<ItemStruct>();
            inventory = new Item[10,5];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    inventory[i,j] = new Item();
                    item_struct.Add(inventory[i,j].GetItemElement());
                }
            }  
        }

        public void LoadContent(ContentManager Content)
        {

        }

        public void AddItem(Item item)
        {

        }
    }

    public class Array100<T>
    {
        public T[] Data = new T[5];
    }
}
