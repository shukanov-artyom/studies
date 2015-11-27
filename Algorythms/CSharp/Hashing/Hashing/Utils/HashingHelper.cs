using System;

namespace Hashing.Utils
{
    public static class HashingHelper
    {
        /// <summary>
        /// Мультипликативная хеш-функция.
        /// Числа с плавающей точкой от 1 до 0.
        /// </summary>
        public static int HashDoubleLessThanOne(double n, int M)
        {
            if (n > 1 || n < 0)
            {
                throw new ArgumentException("This hashing method is for <=0 n <=1");
            } 
            return (int)n/M;
        }

        /// <summary>
        /// Хэшируем 32-битный инт, нормализуя по максимальному значению инта.
        /// Надеемся, что этот инт достаточно случайный.
        /// </summary>
        public static int HashInt(Int32 n, int M)
        {
            double normalized = (double)n/Int32.MaxValue;
            return HashDoubleLessThanOne(normalized, M);
        }
    }
}
