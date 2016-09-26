using System.Threading.Tasks;
using Orleans;
using IoT.GrainInterfaces;
using System;
using IoT.Models;

namespace IoT.GrainClasses
{
    /// <summary>
    /// </summary>
    public class DeviceGrain : Grain, IDeviceGrain
    {

        double lastValue;

        public Task Delete()
        {
            throw new NotImplementedException();
        }

        public Task<DeviceModel> Get()
        {
            throw new NotImplementedException();
        }

        public override Task OnActivateAsync()
        {
            var id = this.GetPrimaryKeyLong();
            Console.WriteLine("Activated {0}", id);

            return base.OnActivateAsync();
        }

        public Task Set(DeviceModel grain)
        {
            throw new NotImplementedException();
        }

        public async Task SetTemperature(double value)
        {
            if( lastValue < 100 && value >= 100)
            {
                Console.WriteLine("High temperature recorded {0}", value);
            }
            lastValue = value; 
        }
    }
}
