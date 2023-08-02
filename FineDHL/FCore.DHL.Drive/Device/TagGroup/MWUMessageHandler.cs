using DotNetty.Buffers;
using DotNetty.Transport.Channels;
using FCore.DHL.Drive.DriveModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCore.DHL.Drive.Device.TagGroup
{
    //public class MWUMessageHandler : SimpleChannelInboundHandler<IByteBuffer>
    //{


    //    private IDeviceCodec Codec;

    //    // 唯一客户端
    //    private bool IsAdd = true;
    //    private SingleChannelHandler _singleChannelHandler = new();
    //    public MWUMessageHandler(IDeviceCodec codec)
    //    {
    //        Codec = codec;
    //    }

    //    public override bool IsSharable => true;

    //    public bool IsAlive()
    //    {
    //        return _singleChannelHandler.CurrentChannel() != null && _singleChannelHandler.CurrentChannel().IsActive;
    //    }

    //    public override void ChannelActive(IChannelHandlerContext context)
    //    {
    //        base.ChannelActive(context);
    //        IsAdd = true;
    //    }

    //    protected override void ChannelRead0(IChannelHandlerContext ctx, IByteBuffer msg)
    //    {
    //        var data = new byte[msg.ReadableBytes];
    //        msg.ReadBytes(data);

    //        // 解码成功并且是第一个报文
    //        if (Codec.Decode(data) && IsAdd)
    //        {
    //            _singleChannelHandler.AddChannel(ctx.Channel);
    //            IsAdd = false;
    //        }
    //    }

    //    public override void ChannelReadComplete(IChannelHandlerContext context) => context.Flush();

    //    public override void ExceptionCaught(IChannelHandlerContext context, Exception exception)
    //    {
    //        context.Channel.Pipeline.Remove(this);
    //        context.CloseAsync();
    //    }

    //    public override void ChannelInactive(IChannelHandlerContext context)
    //    {
    //        base.ChannelInactive(context);
            
    //    }

    //    /// <summary>
    //    /// 发送消息
    //    /// </summary>
    //    /// <param name="data"></param>
    //    /// <returns></returns>
    //    public IDriveResult SendMessage(Object data)
    //    {
    //        try
    //        {
    //            var channel = _singleChannelHandler.CurrentChannel();
    //            if (channel == null)
    //            {
    //                return new DriveResult(false, "500", "消息发送失败", Codec.DeviceID);
    //            }

    //            var buffer = Unpooled.WrappedBuffer(Codec.Encode(data));
    //            var task = channel.WriteAndFlushAsync(buffer);
    //            if (task.Exception != null)
    //            {
    //                LogUnit.Error(task.Exception);
    //                return new DriveResult(false, "500", "发送数据异常", Codec.DeviceID);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            LogUnit.Error(e);
    //            return new DriveResult(false, "500", "发送数据异常", Codec.DeviceID);
    //        }

    //        return new DriveResult(true);
    //    }
    //}
}
