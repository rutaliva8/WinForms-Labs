using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    static class BinaryContainer
    {
        public delegate void TextCallback(string text);
        public static event TextCallback OnTextCanged;
        public static System.Windows.Forms.RichTextBox output;

        static private string binary = String.Empty;
        public static string Binary
        {
            get { return binary; }
            set { binary = value; OnText(); }
        }

        public static void OnText()
        {
            output.Text = BinaryContainer.Binary;
            OnTextCanged?.Invoke(binary);
        }
    }
}
