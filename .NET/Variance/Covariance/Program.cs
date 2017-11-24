using System;
using System.Collections.Generic;

namespace Covariance
{
    class Program
    {
        static void Main(string[] args)
        {
            // usual (invariant) assignment works 
            List<Keyboard> list = new List<Keyboard>();
            
            // Covariant assignment does not work for System.Collections.Generic.List! 
            IList<Device> listOfDevices = new List<Keyboard>();
            IEnumerable<Device> devcs = new List<Keyboard>();
            Acceptor(list);

            IEnumerable<Keyboard> kbds = new List<Keyboard>() { new Keyboard() };
            IEnumerable<Device> enDevices = kbds;

            Action<Device> deviceAction = Top;
            //Action<Device> kbdAction = Bottom; // Contravariant assigment does not work!

            //Active(new Device()); // контравариантные входные параметры не поддерживаются

            Device[] devices = new Keyboard[] // ковариантное присваивание массивов поддерживается!
            {
                new Keyboard(),
                new Keyboard()
            };

            // Contravariant assignment does not work for arrays
            // Keyboard[] kbds = new Device[] 
            // {
            //     new Device(),
            //     new Device()
            // };

            // Try to use our own covariant container 
            ISomeContainer<Device> dc = new KeyboardContainer();
             // it works! as long as we have out specified for generic parameter

        }

        // covariant method accepting list of subclasses
        private static void Acceptor(List<Device> devices)
        {
            Console.WriteLine($"Accepted type: {devices.GetType()}");
        }

        private static void Top(Device dev)
        {
        }

        private static void Bottom(Keyboard kbd)
        {
        }

        private static Device Active(Keyboard kbd) 
        // исследуем входные и выходные параметры на вариантность
        {
            return new Keyboard();
        }
    }

    public class Device 
    {
        public string Name { get; set; }
    }

    public class Keyboard : Device 
    {
        public string Type { get; set; }
    }

    public interface ISomeContainer<out TItem> // add some covariance!
        where TItem : Device
    {
    }

    public class DeviceContainer : ISomeContainer<Device>
    {
    }

    public class KeyboardContainer : ISomeContainer<Keyboard>
    {
    }
}
