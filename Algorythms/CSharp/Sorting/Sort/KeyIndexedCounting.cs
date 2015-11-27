using System;

namespace Sort
{
    /// <summary>
    /// Метод распределяющей сортировки (распределяющего подсчёта)
    /// </summary>
    public class KeyIndexedCounting
    {
        public void Do()
        {
            DoBinary();
            DoUsual();
        }

        private void DoBinary()
        {
            int[] data = new[] { 1, 0, 0, 1, 0, 0, 0, 1, 1, 0 };
            int N = data.Length;

            // temporary array b
            int[] b = new int[N];

            // build a counters array
            int[] cnt = new int[2];
            cnt[0] = 0;
            cnt[1] = 0;

            for (int i = 0; i < N; i++)
            {
                if (data[i] == 0)
                {
                    cnt[1]++;
                }
            }
            // расставляем элементы в выходном массиве
            for (int i = 0; i < N; i++)
            {
                b[cnt[data[i]]++] = data[i];
            }
        }

        private void DoUsual()
        {
            int[] data = new[] {1, 56, 23, 56, 78, 4, 6, 8, 4, 67, 56, 11, 11, 23, 45, 22, 11, 78, 112, 67, 112, 56};
            int N = data.Length;
            int maxKey = data[0];
            foreach (int i in data)
            {
                if (i > maxKey)
                {
                    maxKey = i;
                }
            }
            int[] b = new int[N]; // временный массив
            int[] cnt1 = new int[maxKey+1]; // массив-счётчик

            // подсчитаем число ключей для каждого значения
            for (int i = 0; i < N; i++)
            {
                cnt1[data[i]]++;
            }

            // выделим массив для частичных сумм 
            // частичная сумма - количество ключей со значением, меньше некоторого значения (меньше нуля их 0)
            int[] cnt = new int[maxKey+1];

            //  подсчитаем частичные суммы
            /*for (int i = 0; i < maxKey; i++)
            {
                int sum = 0;
                for (int j = i; j > 0; j--)
                {
                    sum += cnt1[j];
                }
                cnt[i+1] = sum;
            }*/

            // более быстрый способ подсчёта частичных сумм (только один цикл, больший расход памяти на доп. переменную)
            int sum2 = 0;
            int[] cnt2 = new int[maxKey + 1];
            for (int i = 1; i < maxKey; i++)
            {
                sum2 += cnt1[i];
                cnt2[i+1] = sum2;
            }

            // расставляем элементы в выходном массиве
            for (int i = 0; i < N; i++)
            {
                int outputIndex = cnt[data[i]]++; // заметь: инкрементим уже после присваивания
                b[outputIndex] = data[i];
            }
        }
    }
}
