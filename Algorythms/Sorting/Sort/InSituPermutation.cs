using System;

namespace Sort
{
    internal class InSituPermutation
    {
        private int[] a = new[]
                          {
                              2,4,5,0,1,3
                          };
        private double[] data = new double[]
                                {
                                    2.5,
                                    3.5,
                                    1.1,
                                    5.3,
                                    1.7,
                                    2.1
                                };

        public void Sort()
        {
            for (int i = 0; i < 6; i++)
            {
                double v = data[i];
                // запускаем цикл по k, который начинает с элемента i, идёт по массиву пока a[k] != i, и вставляет в предыдущее освободившееся место нужный элемент
                int k;
                int j;
                for (k = i; a[k] != i; k = a[k], a[j] = j) // в конце операции надо установить k в следующий индекс пустого места
                {
                    j = k;
                    data[k] = data[a[k]];
                }
                data[k] = v;
                a[k] = k;
            }
        }
    }
}
