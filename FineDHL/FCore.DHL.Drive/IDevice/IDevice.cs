using FCore.DHL.Drive.Builder;
using FCore.DHL.Drive.DriveModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCore.DHL.Drive.IDevice
{
    public interface IDevice<Builder> where Builder : IBuilder
    {
        /// <summary>
        /// 构建设备
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        DriveResult Build(Builder builder);

        /// <summary>
        /// 开机
        /// </summary>
        /// <returns></returns>
        DriveResult Open();

        /// <summary>
        /// 关机
        /// </summary>
        /// <returns></returns>
        DriveResult Close();
    }
}
