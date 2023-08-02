using FCore.DHL.Drive.DriveModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCore.DHL.Drive.Builder.AGVDispatch
{
    public class MuShinyAGVDispatchBuilder : IBuilder
    {
        #region delegate
        public delegate void DispatchTaskBeginEvent(long taskId);

        public delegate void DispatchTaskEndEvent(long taskId);
        #endregion

        public event DispatchTaskBeginEvent TaskBeginEvent;

        public event DispatchTaskEndEvent TaskEndEvent;
        public IDirveLogger Logger { get; set ; }
        public IInteractiveLogger InteractiveLogger { get ; set ; }
        public int DeviceID { get ; set ; }
        public string DeviceIP { get ; set ; }
    }
}
