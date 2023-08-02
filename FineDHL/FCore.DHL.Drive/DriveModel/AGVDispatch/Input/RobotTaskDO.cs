using FCore.DHL.Drive.DriveModel.AGVDispatch.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCore.DHL.Drive.DriveModel.AGVDispatch.Input
{
    public class RobotTaskDO
    {
        /// <summary>
        /// 区域id(必选)
        /// </summary>
        public int sectionId { get; set; }
        /// <summary>
        /// 指定的agv的id
        /// </summary>
        public string robotId { get; set; }
        /// <summary>
        /// 货架id
        /// </summary>
        public string podId { get; set; }
        /// <summary>
        /// 货架在目标点的朝向，0: A面，1:B面，2：C面，3:D 面
        /// </summary>
        public int targetDirection { get; set; }
        /// <summary>
        /// 目标点 ，目标点和目标区域必须要传一个，如果都传，后台也会校验目标点是否在目标区域
        /// </summary>
        public int targetCellId { get; set; }
        /// <summary>
        /// 目标点朝向（相当于工作站在目标点的朝向）
        /// </summary>
        public int direction { get; set; }
        /// <summary>
        /// 旋转区
        /// </summary>
        public Object rotateArea { get; set; }
        /// <summary>
        /// 入口点
        /// </summary>
        public int inCellId { get; set; }
        /// <summary>
        /// 旋转点 
        /// </summary>
        public int rotateCellId { get; set; }
        /// <summary>
        /// 出口点
        /// </summary>
        public int outCellId { get; set; }
        /// <summary>
        /// 放回区域 All:代码可以选择其他区域
        /// </summary>
        public List<string> backZone { get; set; }
        /// <summary>
        /// 作用域 
        /// </summary>
        public List<string> scopeCodes { get; set; }
        /// <summary>
        /// 小车行为
        /// </summary>
        public AgvActionEnum agvAction { get; set; }
        /// <summary>
        /// 是否回休息点，true：会休息点，false：不回休息点，不传默认是false
        /// </summary>
        public bool isBackToRestCellId { get; set; }=false;
        /// <summary>
        /// 工作站模式,不会锁目标点, true:使用,false:不使用
        /// </summary>
        public bool stationSchema { get; set; }
    }
}
