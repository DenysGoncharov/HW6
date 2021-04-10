using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melody
{
   static  class MelodyParser
    {
        const int DURATION = 500;
        public static Note[] ParseMelody(string melody)
        {
            
            Note[] music = new Note[melody.Length];
          
            
            for (int i = 0; i < melody.Length; i++)
            {
                switch (melody[i])
                {
                    case '0':
                        {
                            music[i].Do(1, DURATION);
                            break;
                        }
                    case '1':
                        {
                            music[i].Re(1, DURATION);
                            break;
                        }
                    case '2':
                        {
                            music[i].Mi(1, DURATION);
                            break;
                        }
                    case '3':
                        {
                            music[i].Fa(1, DURATION);
                            break;
                        }
                    case '4':
                        {
                            music[i].Sol(1, DURATION);
                            break;
                        }
                    case '5':
                        {
                            music[i].La(1, DURATION);
                            break;
                        }
                    case '6':
                        {
                            music[i].Si(1, DURATION);
                            break;
                        }
                    case '7':
                        {
                            music[i].Do(2, DURATION);
                            break;
                        }
                    case '8':
                        {
                            music[i].Re(2, DURATION);
                            break;
                        }
                    case '9':
                        {
                            music[i].Mi(2,DURATION);
                            break;
                        }
                    case ' ':
                        {
                            music[i].Pause = true;
                            break;
                        }
                }
            }

            return music;
        } 
    }
}
