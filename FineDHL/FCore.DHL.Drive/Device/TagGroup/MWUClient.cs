using DotNetty.Transport.Bootstrapping;
using DotNetty.Transport.Channels;
using DotNetty.Transport.Channels.Sockets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace FCore.DHL.Drive.Device.TagGroup
{
    public class MWUClient
    {
        
        private string _logTag;
        private Bootstrap _bootstrap;
        private Action<IChannel> _handlerInitAction;
        private string _ip;

        public MWUClient(string ip, Action<IChannel> action, string logTag)
        {
            _ip = ip;
            _handlerInitAction = action;
            _logTag = logTag;
        }

        /// <summary>
        /// 初始化
        /// </summary>
        public void Init()
        {
            var ip = _ip.Split(':');
            _bootstrap = new Bootstrap();
            _bootstrap.Group(new MultithreadEventLoopGroup());
            _bootstrap.Channel<TcpSocketChannel>()
                .Option(ChannelOption.SoBacklog, 128)
                .Option(ChannelOption.TcpNodelay, true)
                .Option(ChannelOption.SoKeepalive, true)
                .Handler(new ActionChannelInitializer<IChannel>(_handlerInitAction));
            var channel = _bootstrap.BindAsync(ip[0], Convert.ToInt32(ip[1])).Result;
            if (channel is { IsOpen: true })
            {
               // LogUnit.Info($"{_logTag}服务端开启成功");
            }
        }

    }
}

