using System;
using System.Security.Cryptography.X509Certificates;

namespace AppDomainTestInterfaces
{
    public interface IExport
    {
        IVisualExport Visual { get; }

        IEventsExport EventStarter { get; }

        void InHere();
    }
}
