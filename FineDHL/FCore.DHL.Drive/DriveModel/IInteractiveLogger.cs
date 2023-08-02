using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCore.DHL.Drive.DriveModel
{
    public interface IInteractiveLogger
    {
        /// <summary>
        /// 接收信息记录
        /// </summary>
        /// <returns></returns>
        Task Receive(int deviceId, string request, string response);

        /// <summary>
        /// 推送信息记录
        /// </summary>
        /// <returns></returns>
        Task Push(int deviceId, string request, string response);
    }
}
