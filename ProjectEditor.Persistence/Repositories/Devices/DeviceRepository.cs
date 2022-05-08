using ProjectEditor.Common.Attributes;
using ProjectEditor.Core.Repositories.Devices;
using ProjectEditor.Persistence.Repositories.Base;

namespace ProjectEditor.Persistence.Repositories.Devices
{
    [MapServiceDependency(nameof(DeviceRepository))]
    public class DeviceRepository : BaseRepository, IDeviceRepository
    {
    }
}
