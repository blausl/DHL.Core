using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCore.DHL.Drive.DriveModel
{
    public interface IDirveLogger
    {
        Task Info(int deviceId, string message);

        Task Warning(int deviceId, string message);

        Task Error(int deviceId, string message);
    }
}
