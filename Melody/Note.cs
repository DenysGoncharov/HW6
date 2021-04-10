using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melody
{
    class Note
    {
        const int TWO = 2;
        int frequency;
        int duration;
        bool pause;
        public bool Pause { set; get; }
        public int Frequency { get;}
        public int Duration { get;}
       public  Note(int frequency, int duration)
        {
            this.frequency = frequency;
            this.duration = duration;
            this.pause = false;
        }
        public Note Do(int octava, int duration) 
        {
            int firstC = 261;
            int o = octava-1;
            int koeefOktav = (int)Math.Pow(TWO,o);
            frequency = firstC * koeefOktav;
            
            return new Note (frequency, duration);
            
        }
        public Note Re(int octava, int duration)
        {
            int firstD = 294;
            int o = octava - 1;
            int koeefOktav = (int)Math.Pow(TWO, o);
            frequency = firstD * koeefOktav;

            return new Note(frequency, duration);
        }
        public Note Mi(int octava, int duration)
        {
            int firstE = 330;
            int o = octava - 1;
            int koeefOktav = (int)Math.Pow(TWO, o);
            frequency = firstE * koeefOktav;

            return new Note(frequency, duration);
        }
        public Note Fa(int octava, int duration)
        {
            int firstF = 349;
            int o = octava - 1;
            int koeefOktav = (int)Math.Pow(TWO, o);
            frequency = firstF * koeefOktav;

            return new Note(frequency, duration);
        }
        public Note Sol(int octava, int duration)
        {
            int firstG = 392;
            int o = octava - 1;
            int koeefOktav = (int)Math.Pow(TWO, o);
            frequency = firstG * koeefOktav;

            return new Note(frequency, duration);
        }

        public Note La(int octava, int duration)
        {
            int firstA = 440;
            int o = octava - 1;
            int koeefOktav = (int)Math.Pow(TWO, o);
            frequency = firstA * koeefOktav;

            return new Note(frequency, duration);
        }
        public Note Si(int octava, int duration)
        {
            int firstB = 494;
            int o = octava - 1;
            int koeefOktav = (int)Math.Pow(TWO, o);
            frequency = firstB * koeefOktav;

            return new Note(frequency, duration);
        }

    }
}
