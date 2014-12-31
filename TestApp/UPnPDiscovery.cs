using ManagedUPnP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class UPnPDiscovery
    {
        public event EventHandler<EventArgs> OnSearchComplete;

        Devices deviceList;
        
        public Devices DeviceList
        {
            get
            {
                return deviceList;
            }
        }
        /// <summary>
        /// Time out in milliseconds, default is 30000;
        /// </summary>
        int Timeout
        { get; set; }

        /// <summary>
        /// Max devices to search for, default is int.MaxValue
        /// </summary>
        int MaxDevices
        { get; set; }
        public UPnPDiscovery()
        {
            Timeout = 30000;
            MaxDevices = int.MaxValue;
        }

        void OnDevicesFound(Devices devices, bool searchCompleted)
        {
            // Enumerate devices here, searchCompleted is true if 
            // all currently connected devices have been found
            if(searchCompleted == true)
            {
                deviceList = devices;

                EventHandler<EventArgs> temp = OnSearchComplete;
                if(temp != null)
                {
                    temp(this, new EventArgs());
                }
            }
        }

        public void Start()
        {
            Discovery.FindDevicesAsync(null, Timeout, MaxDevices, new Discovery.DevicesFoundDelegate(OnDevicesFound),AddressFamilyFlags.IPvBoth, false);
        }
    }
}
