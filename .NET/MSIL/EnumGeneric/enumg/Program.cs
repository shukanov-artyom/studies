using System;
using EnumGenericModified;

namespace enumg
{
    

    public enum EnumerationReal
    {
        One = 1,
        Two = 2,
        Three = 3 
    }

    class Program
    {
        static void Main(string[] args)
        {
            var modified = new EnumReceiver<MockTurtle>();
            var gmo = new EnumReceiver<EnumerationReal>();
        }
    }
}
