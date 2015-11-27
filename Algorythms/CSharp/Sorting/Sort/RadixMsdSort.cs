using System;
using System.Collections.Generic;

namespace Sort
{
    public class RadixMsdSort
    {
        private const int M = 3;

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
                                    "boob",
                                    "gags",
                                    "para",
                                    "xdrt",
                                    "dmrp",
                                    "nasa",
                                    "goog",
                                    "leco",
                                    "mail",
                                    "guns",
                                    "rose",
                                    "xart",
                                    "zorr",
                                    "ange",
                                    "doge"
                                };
            RadixMsd(data, 0, data.Count);
        }

        private static void RadixMsd(List<string> data, int l, int r, int d = 0)
        {
            if (r <= l)
            {
                return;
            }

            // если входных даных мало - сортируем вставками
            if (r - l < M)
            {
                InsertionSort(data, l, r, d);
                return;
            }

            int R = 26;
            // 1. распределяем количества по вёдрам
            var aux = new List<string>(data.Count);
            var count = new int[26];
            for (int i = l; i < r; i++)
            {
                int countIndex = DigitToInt(Digit(data[i], d))-1;
                count[countIndex]++;
            }
            
            // теперь надо получить сдвиги (частичные суммы)
            int sum = 0;
            var partialSum = new int[count.Length + 1];
            for (int i=0; i<count.Length; i++)
            {
                sum += count[i];
                partialSum[i + 1] = sum;
            }

            // бэкапим массив частичных сумм
            int[] partialSum2 = new int[count.Length + 1];
            Array.Copy(partialSum, partialSum2, partialSum.Length);

            // расставляем элементы во временном массиве согласно частичным суммам
            List<string> tmp = new List<string>(new string[data.Count]);
            for (int i = 0; i < data.Count; i++)
            {
                int digit = DigitToInt(Digit(data[i], d))-1;
                int indexInTemp = partialSum2[digit]++;
                tmp[indexInTemp] = data[i];
            }

            // переносим временные данные в исходный массив
            for (int i = 0; i < tmp.Count; i++)
            {
                data[i] = tmp[i];
            }

            // рекурсивные вызовы для всех (непустых) контейнеров
            for (int i = 1; i < partialSum2.Length-1; i++)
            {
                int left = partialSum2[i];
                int right = partialSum2[i + 1] - 1;
                RadixMsd(data, left, right);
            }
        }

        private static char Digit(string line, int position)
        {
            return line[position];
        }

        private static int DigitToInt(char a)
        {
            switch (a)
            {
                case 'a': return 1;
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

        private static void InsertionSort(List<string> data, int l, int r, int d)
        {
            for (int i = l + 1; i <= r; i++) // внешний цикл от первого до последнего
            {
                for (int j = i; j > l; j--) // проходим от i-го до левой границы массива
                {
                    CompareExchange(data, j - 1, j, d);
                }
            }
        }

        private static void CompareExchange(List<string> data, int a, int b, int d)
        {
            // если d-я цифра строки а меньше d-й цифры строки b, то обменяем строки местами
            int digitA = DigitToInt(Digit(data[a], d));
            int digitB = DigitToInt(Digit(data[b], d));
            if (digitA < digitB)
            {
                string s = data[a];
                data[a] = data[b];
                data[b] = s;
            }
        }
    }
}
