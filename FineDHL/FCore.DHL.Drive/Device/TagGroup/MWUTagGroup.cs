using FCore.DHL.Drive.Builder.AGVDispatch;
using FCore.DHL.Drive.Builder.TagGroup;
using FCore.DHL.Drive.DriveModel;
using FCore.DHL.Drive.IDevice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCore.DHL.Drive.Device.TagGroup
{
    public class MWUTagGroup : IDevice<MWUTagGroupBuilder>, ITagGroupDevice
    {
        private MWUTagGroupBuilder _builder;
        MWUClient _client;
        private MWUMessageHandler _messageHandler;
        /// <summary>
        /// 设备构建
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public DriveResult Build(MWUTagGroupBuilder builder)
        {
            _builder = builder;
            _builder.Logger.Info(_builder.DeviceID, "设备初始化成功");
            _client = new MWUClient(_builder.DeviceIP, channel =>
            {
                var pipeline = channel.Pipeline;
                //pipeline.AddLast("frame",
                //    new TcpDynamicLengthFrameDecoder(this._builder.BytesHeadLength, this._builder.BytesMinLength, 0x5A,
                //        0xA5));
                pipeline.AddLast(_messageHandler);
            }, "JJY分拣机");
            return DriveResultUnit.Success();

        }
        public DriveResult Close()
        {
            throw new NotImplementedException();
        }

        public DriveResult Open()
        {
            throw new NotImplementedException();
        }
    }
}
