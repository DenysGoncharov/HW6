using System;

namespace Melody
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter melody:");
            string melody = Console.ReadLine();
            Note[] music = MelodyParser.ParseMelody(melody);
            Player.Play(music);

            Console.ReadKey();
        }

    }
}
