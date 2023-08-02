using FCore.DHL.Drive.DriveModel;
using FCore.DHL.Drive.DriveModel.AGVDispatch.Input;
using FCore.DHL.Drive.DriveModel.AGVDispatch.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCore.DHL.Drive.IDevice
{
    public interface IAGVDispatch
    {


        /// <summary>
        /// AGV调度
        /// </summary>
        Task<DriveResult<RobotTaskRsp>> PushDispatchTask(RobotTaskDO dispatchTask, bool isLoad = true);

        /// <summary>
        /// 更新任务优先级
        /// </summary>
        Task<DriveResult> UpdatePriority(long dispatchTaskId, int priority);

        /// <summary>
        /// 取消任务
        /// </summary>
        Task<DriveResult> CancellationPriority(long dispatchTaskId);

        /// <summary>
        /// 获取机器人列表
        /// </summary>
        Task<DriveResult<List<RobotQueryRsp>>> GetRobotList(int sectionId,string robotId);
    }
}
