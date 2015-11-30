using System;

namespace Study
{
    public class Harmonic
    {
        private const double gamma = 0.57721;

        public static double Calculate(int N)
        {
            return Math.Log(N, Math.E) + gamma + 1.0/(12.0*N);
        }

        public static double CalculateNative(int N)
        {
            double result = 0.0;
            for (int i = 1; i <= N; i++)
            {
                result += 1.0/i;
            }
            return result;
        }
    }
}
