using System;

namespace appdom
{
    public class DomainObjectFactory : MarshalByRefObject
    {
        public DomainObjectWindowKeeper Generate()
        {
            return new DomainObjectWindowKeeper();
        }
    }
}
