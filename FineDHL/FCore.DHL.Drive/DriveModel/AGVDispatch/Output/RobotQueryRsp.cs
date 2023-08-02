using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCore.DHL.Drive.DriveModel.AGVDispatch.Output
{
    public class RobotQueryRsp
    {
        /// <summary>
        /// 主键 
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 小车id
        /// </summary>
        public string robotId { get; set; }
        /// <summary>
        /// 货架id 
        /// </summary>
        public string podId { get; set; }
        /// <summary>
        /// 当前方向，0, 90, 180, 270 地图上方为0
        /// </summary>
        public int direction { get; set; }
        /// <summary>
        /// 区域id 
        /// </summary>
        public int sectionId { get; set; }
        /// <summary>
        /// 所在RCS服务器标识
        /// </summary>
        public string clusterIndex { get; set; }
        /// <summary>
        /// 当前所在位置 
        /// </summary>
        public int currentCellId { get; set; }
        /// <summary>
        /// 当前方向
        /// </summary>
        public int currentDirection { get; set; }
        /// <summary>
        /// 当前速度 
        /// </summary>
        public int speed { get; set; }
        /// <summary>
        /// 维护标志位 
        /// </summary>
        public bool disabled { get; set; }
        /// <summary>
        /// 小车类型，3:天马三代，1:模拟小车
        /// </summary>
        public int robotType { get; set; }
        /// <summary>
        /// agv 状态，[Offline:离线, StandBy:待命, Working:执行任务 具体执行的任务用其他字段标识,Charging:充电, Error:异常, Connecting:连接中
        /// </summary>
        public string agvStatus { get; set; }
        /// <summary>
        /// 判断是否是模拟器 还是真实的小车充电 
        /// </summary>
        public bool isDummy { get; set; }
        /// <summary>
        /// 小车电量
        /// </summary>
        public int battery { get; set; }
        /// <summary>
        /// 小车电压
        /// </summary>
        public int batteryVoltage { get; set; }
        /// <summary>
        /// 固件版本号
        /// </summary>
        public string version { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime createDate { get; set; }
        /// <summary>
        /// 当前举升Pod的Id 
        /// </summary>
        public string upliftPodId { get; set; }
        /// <summary>
        /// 当前举升Pod的朝向 
        /// </summary>
        public int upliftPodDirection { get; set; }
        /// <summary>
        /// 当前AGV绑定的任务Id
        /// </summary>
        public string currentTaskId { get; set; }
        /// <summary>
        /// 当前AGV绑定的任务类型
        /// </summary>
        public string currentTaskType { get; set; }
        /// <summary>
        /// 当前AGV绑定的PodId
        /// </summary>
        public string lockedPodId { get; set; }
        /// <summary>
        /// 当前AGV绑定的充电桩Id 
        /// </summary>
        public string lockedChargerId { get; set; }
        /// <summary>
        /// 当前AGV锁定的临时不可走点集合
        /// </summary>
        public List<string> lockedTemporaryCells { get; set;}
        /// <summary>
        /// 当前AGV锁定的目标点集合 
        /// </summary>
        public List<string> lockedTargetCells { get; set; }
        /// <summary>
        /// 文件升级状态，0：升级成功，1：升级中，2，升级失败
        /// </summary>
        public int agvUpgradeFileStatus { get; set; }
        /// <summary>
        /// 文件下载状态，0：下载成功，1：下载中，2，下载失败
        /// </summary>
        public int agvDownLoadFileStatus { get; set;}
        /// <summary>
        /// IP 地址 
        /// </summary>
        public string ip { get; set; }
        /// <summary>
        /// 端口号 
        /// </summary>
        public string port { get; set; }

    }
}
