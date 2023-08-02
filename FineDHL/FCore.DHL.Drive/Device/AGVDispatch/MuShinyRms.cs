using FCore.DHL.Drive.DriveModel;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FCore.DHL.Drive.Device.AGVDispatch
{
    public class MuShinyRms
    {
        private HttpClient _httpClient;
        
        private IInteractiveLogger _logger;
        
        public MuShinyRms(int deviceId, string deviceIp, IInteractiveLogger logger)
        {
            _logger = logger;
            _httpClient = new HttpClient() { BaseAddress = new Uri(deviceIp)};
         
            
        }

        public async Task<DriveResult> CancelTask(int sectionId,string taskId)
        {
            return DriveResultUnit.Success();
        }
    }
}
