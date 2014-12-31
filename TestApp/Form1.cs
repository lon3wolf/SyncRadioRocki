using ManagedUPnP;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Form
    {
        List<Device> list;

        Devices selectedDevices;
        delegate void UpdateList();
        public Form1()
        {
            InitializeComponent();
            list = new List<Device>();
            Devices.DataSource = list;

            selectedDevices = new Devices();
            Channels.DataSource = new BindingSource(ChannelsCollection.channels, null);
            Channels.DisplayMember = "ChannelName";

            int vol = volume.Value;
            VolLabel.Text = (string.Format("volume: {0,2}%", vol));
        }

        private void Search_Click(object sender, EventArgs e)
        {
            Status.Style = ProgressBarStyle.Marquee;
            list.Clear();
            UPnPDiscovery discovery = new UPnPDiscovery();
            discovery.OnSearchComplete += discovery_OnSearchComplete;
            discovery.Start();
        }
        void UpdateReceiver()
        {
            Devices.ValueMember = "UniqueDeviceName";
            Devices.DisplayMember = "FriendlyName";
            Devices.DataSource = list;
            Status.Style = ProgressBarStyle.Continuous;
        }

        void discovery_OnSearchComplete(object sender, EventArgs e)
        {
            UPnPDiscovery discovery = sender as UPnPDiscovery;
            foreach (Device dev in discovery.DeviceList)
            {
                list.Add(dev);
            }
            if (Devices.InvokeRequired)
            {
                UpdateList updater = new UpdateList(UpdateReceiver);
                Devices.Invoke(updater);
            }
        }

        private void Play_Click(object sender, EventArgs e)
        {
            if (selectedDevices.Count == 0) { return; }
            int vol = volume.Value;

            if (vol >= 0 && vol <= 100)
            {
                foreach (Device player in selectedDevices)
                {
                    Service renderingControl = player.Services[2];
                    Debug.WriteLine(renderingControl.Name);
                    try { var result = renderingControl.InvokeAction("SetVolume", 0, "Master", vol); }
                    catch
                    {
                        // do nothing
                    }
                }
            }

            foreach (Device player in selectedDevices)
            {
                Service avtransport = player.Services[0];
                Debug.WriteLine(avtransport.Name);
                var result = avtransport.InvokeAction("SetAVTransportURI", 0, mediaURL.Text, "");
            }
            foreach (Device player in selectedDevices)
            {
                Service avtransport = player.Services[0];
                var result = avtransport.InvokeAction("Play", 0, 1);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (list.Count != 0 && Devices.SelectedValue != null)
            {
                selectedDevices.Add(list[Devices.SelectedIndex]);
                selectedPlayers.Items.Clear();
                foreach (Device dev in selectedDevices)
                {
                    selectedPlayers.Items.Add(dev.FriendlyName);
                }
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            selectedDevices.Clear();
            selectedPlayers.Items.Clear();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            foreach (Device player in selectedDevices)
            {
                Service avtransport = player.Services[0];
                Debug.WriteLine(avtransport.Name);
                var result = avtransport.InvokeAction("Stop", 0);
            }
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            foreach (Device player in selectedDevices)
            {
                Service avtransport = player.Services[0];
                Debug.WriteLine(avtransport.Name);
                var result = avtransport.InvokeAction("Pause", 0);
            }
        }

        private void volume_ValueChanged(object sender, EventArgs e)
        {
            int vol = (sender as TrackBar).Value;

            if (vol < 0 || vol > 100) { return; }
            VolLabel.Text = (string.Format("volume: {0,2}%", vol));
        }

        private void volume_MouseUp(object sender, MouseEventArgs e)
        {
            int vol = (sender as TrackBar).Value;

            if (vol < 0 || vol > 100) { return; }

            foreach (Device player in selectedDevices)
            {
                Service renderingControl = player.Services[2];
                Debug.WriteLine(renderingControl.Name);
                try { var result = renderingControl.InvokeAction("SetVolume", 0, "Master", vol); }
                catch
                {
                    // do nothing
                }
            }
        }

        private void Channels_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Channels.SelectedValue != null)
            {
                mediaURL.Text = ((Channel)Channels.SelectedValue).ChannelUrl;
            }
        }
    }
}
