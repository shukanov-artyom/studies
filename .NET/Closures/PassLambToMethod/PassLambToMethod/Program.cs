using System;

namespace PassLambToMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string arg = "some string";
            string arg2 = "another string";
            Result r = ProcessHandled(() => ProcessingMethod(arg2));
        }

        private static Result ProcessingMethod(string processingString)
        {
            if (processingString.Equals("some string"))
            {
                throw new ArgumentException();
            }
            return new Result(0);
        }

        private static Result ProcessHandled(Func<Result> fun)
        {
            try
            {
                return fun();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("onmomo");
                throw;
            }
        }
    }

    internal class Result
    {
        private int code = -1;

        public Result(int code)
        {
            this.code = code;
        }

        public int Code => code;
    }
}
