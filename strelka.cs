using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tortiki
{
    internal class strelka
    {
        public static int show(int minstrelka, int maxstrelka)
        {
            int pos = minstrelka;
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey();
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("  ");
                if (key.Key == ConsoleKey.UpArrow && pos != minstrelka)
                {
                    pos--;
                }
                if (key.Key == ConsoleKey.DownArrow && pos != maxstrelka)
                {
                    pos++;
                }
                
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");
            } while (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Escape);
            return pos;
        }

    }
}
