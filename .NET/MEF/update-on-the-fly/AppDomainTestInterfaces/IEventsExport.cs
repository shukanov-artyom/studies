using System;

namespace AppDomainTestInterfaces
{
    public interface IEventsExport
    {
        event EventHandler SomeEvent;

        event EventHandler SomeOtherEvent;
    }
}
