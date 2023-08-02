using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCore.DHL.Drive.DriveModel.AGVDispatch.Enum
{
    /// <summary>
    /// 小车行为
    /// </summary>
    public enum AgvActionEnum
    {
        /// <summary>
        /// 放下
        /// </summary>
        DOWN_POD,
        /// <summary>
        /// 驮着货架
        /// </summary>
        CARRY_POD,
        /// <summary>
        /// 放下货架等待
        /// </summary>
        DOWN_POD_WAIT
    }
}
