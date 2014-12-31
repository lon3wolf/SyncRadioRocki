using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class Channel
    {
        public string ChannelName, ChannelUrl;
        public Channel(string name, string URL)
        {
            ChannelName = name;
            ChannelUrl = URL;
        }

        public override string ToString()
        {
            return ChannelName;
        }
    }

    public static class ChannelsCollection
    {
        public static List<Channel> channels;
        static ChannelsCollection()
        {
            channels = new List<Channel>();

            channels.Add(new Channel("rockXradio", "http://67.213.213.143:8040")); 
            channels.Add(new Channel("3FM (NL)", "http://icecast.omroep.nl/3fm-bb-mp3"));
            channels.Add(new Channel("3FM Alternative (NL)", "http://icecast.omroep.nl/3fm-alternative-mp3"));
            channels.Add(new Channel("StuBru (BE)", "http://mp3.streampower.be/stubru-high.mp3"));
            channels.Add(new Channel("Radio 2 Top 2000 (NL)", "http://icecast.omroep.nl/radio2-top2000-mp3"));
            channels.Add(new Channel("KX Radio (NL)", "http://icecast.omroep.nl/3fm-serioustalent-mp3"));
        }
    }
}
