using System;
using System.Collections.Generic;
using System.Globalization;

namespace Study
{
    public class Msd
    {
        public static void Do()
        {
            List<string> data = new List<string>()
                                {
                                    "raff",
                                    "ruse",
                                    "lold",
                                    "gtfo",
                                    "azaz",
                                    "pron",
                                    "tits",
                                    "boob"
                                };


        }

        private static void RadixMsd(List<string> data, int l, int r, int d = 0)
        {
            int R = 26;
            // 1. let's distribute all strings between their buckets
            var aux = new List<string>(data.Count);
            var count = new List<int>(26);
            for (int i = l; i < r; i++)
            {
                int countIndex = Digit(data[i], d);
                count[countIndex]++;
            } // распределили количества по вёдрам, теперь надо получить сдвиги
            for ()
            {
                
            }
        }

        private static void Distribute(List<string> data, int l, int r, int d, List<string> aux)
        {
            
        }

        private static int Digit(string line, int position)
        {
            return line[position];
        }

        private int DigitToInt(char a)
        {
            switch (a)
            {
                case 'a' : return 1;
                case 'b': return 2;
                case 'c': return 3;
                case 'd': return 4;
                case 'e': return 5;
                case 'f': return 6;
                case 'g': return 7;
                case 'h': return 8;
                case 'i': return 9;
                case 'j': return 10;
                case 'k': return 11;
                case 'l': return 12;
                case 'm': return 13;
                case 'n': return 14;
                case 'o': return 15;
                case 'p': return 16;
                case 'q': return 17;
                case 'r': return 18;
                case 's': return 19;
                case 't': return 20;
                case 'u': return 21;
                case 'v': return 22;
                case 'w': return 23;
                case 'x': return 24;
                case 'y': return 25;
                case 'z': return 26;
                default:
                    throw null;
            }
        }
    }
}
