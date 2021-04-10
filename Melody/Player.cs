using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melody
{
    static class Player
    {
       
        public static void Play(Note[]notes)
        {
            for (int i = 0; i < notes.Length; i++)
            {
                if (notes[i].Pause == false)
                    Console.Beep(notes[i].Frequency, notes[i].Duration);
                else Console.Beep(0, notes[i].Duration);
            }
        }
    }
}
