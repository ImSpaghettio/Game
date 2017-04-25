using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Game1.Tools;
using System.Xml.Serialization;

namespace Game1
{
    /// <summary>
    /// Author: Alex
    /// 
    /// Description: stores all the games settings and constant
    /// variables.
    /// </summary>
    public class GameSettings
    {
        [XmlIgnore]
        public const int SCALE = 1;

        private static int screen_height;
        private static int screen_width;

        [XmlIgnore]
        public Type Type;

        public GameSettings()
        {
            Type = this.GetType();
        }

        #region Getters and Setters

        public int Screen_Height
        {
            get { return screen_height; }
            set
            {
                if (value > 0)
                    screen_height = value;
                else throw new ArgumentException("Screen height must be greater than 0");
            }
        }

        public int Screen_Width
        {
            get { return screen_width; }
            set
            {
                if (value > 0)
                    screen_width = value;
                else throw new ArgumentException("Screen height must be greater than 0");
            }
        }

        #endregion

    }
}
