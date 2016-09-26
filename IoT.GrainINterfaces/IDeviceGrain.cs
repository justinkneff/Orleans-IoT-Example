using IoT.GrainInterfaces;
using IoT.GrainINterfaces;
using IoT.Models;
using Orleans;
using System.Threading.Tasks;

namespace IoT.GrainInterfaces
{
    /// <summary>
    /// </summary>
	public interface IDeviceGrain : IBaseGrain<DeviceModel>
    {
        Task SetTemperature(double value);
    }
}
