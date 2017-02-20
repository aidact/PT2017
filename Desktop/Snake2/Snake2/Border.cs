using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Border
    {
        public static void border()
        {
            for (int i = 0; i < 59; i++) // прорисовываем границы по ширине
            {
                Console.SetCursorPosition(i, 24);
                Console.Write('■');
                Console.SetCursorPosition(i, 0);
                Console.Write('■');
            }
            for (int i = 0; i < 24; i++) // прорисовывем границы по высоте
            {
                Console.SetCursorPosition(0, i);
                Console.Write('■');
                Console.SetCursorPosition(59 , i);
                Console.Write('■'); 
            }

            for (int i = 6; i <= 17; i++) // прорисовываем стены
            {
                Console.SetCursorPosition(19, i);
                Console.Write('■');
                Console.SetCursorPosition(38, i);
                Console.Write('■');
            }
        }
    }
}
