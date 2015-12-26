using System;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace ipy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int result = (int)Calculate("2 * 3");
        }

        private static object Calculate(string expr)
        {
            ScriptEngine engine = Python.CreateEngine();
            return engine.Execute(expr);
        }
    }
}
