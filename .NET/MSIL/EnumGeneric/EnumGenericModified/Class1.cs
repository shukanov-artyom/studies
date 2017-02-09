using System;

namespace EnumGenericModified
{
    public class EnumReceiverSimple<T>
        where T: struct, IConvertible
    {
    }
}
