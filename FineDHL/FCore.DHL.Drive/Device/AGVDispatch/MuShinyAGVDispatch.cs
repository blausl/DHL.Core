using FCore.DHL.Drive.Builder.AGVDispatch;
using FCore.DHL.Drive.DriveModel;
using FCore.DHL.Drive.DriveModel.AGVDispatch.Input;
using FCore.DHL.Drive.DriveModel.AGVDispatch.Output;
using FCore.DHL.Drive.IDevice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCore.DHL.Drive.Device.AGVDispatch
{
    public class MuShinyAGVDispatch : IDevice<MuShinyAGVDispatchBuilder>, IAGVDispatch
    {
        public MuShinyAGVDispatchBuilder _builder;
        MuShinyRms _geekRms;


        /// <summary>
        /// 设备构建
        /// </summary>
        public DriveResult Build(MuShinyAGVDispatchBuilder builder)
        {
            _builder = builder;
            _builder.Logger.Info(this._builder.DeviceID, "设备初始化成功");
            _geekRms = new MuShinyRms(builder.DeviceID, builder.DeviceIP, _builder.InteractiveLogger);
            return DriveResultUnit.Success();
        }

        public Task<DriveResult> CancellationPriority(long dispatchTaskId)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 设备关机
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public DriveResult Close()
        {
            throw new NotImplementedException();
        }

        public Task<DriveResult<List<RobotQueryRsp>>> GetRobotList(int sectionId, string robotId)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 设备开机
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public DriveResult Open()
        {
            throw new NotImplementedException();
        }

        public Task<DriveResult<RobotTaskRsp>> PushDispatchTask(RobotTaskDO dispatchTask, bool isLoad = true)
        {
            throw new NotImplementedException();
        }

        public Task<DriveResult> UpdatePriority(long dispatchTaskId, int priority)
        {
            throw new NotImplementedException();
        }


    }
}
