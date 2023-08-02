using FCore.DHL.Drive.DriveModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCore.DHL.Drive.Builder.TagGroup
{
    public class MWUTagGroupBuilder: IBuilder
    {
        public IDirveLogger Logger { get; set; }
        public IInteractiveLogger InteractiveLogger { get; set; }
        public int DeviceID { get; set; }
        public string DeviceIP { get; set; }

    }
}
