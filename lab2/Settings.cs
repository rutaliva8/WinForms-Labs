using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Settings
    {
        private static Settings instance;
        public static Settings inst {
            get
            {
                return instance ?? (instance = new Settings());
            }
            set
            {
                throw new Exception("Tried to change Settings.inst");
            }
        }

        public string TextColor = "FFFFFFF"; // HEX
        public string Font = "Comic Sans MS";
        public float TextSize = 16;
    }
}
