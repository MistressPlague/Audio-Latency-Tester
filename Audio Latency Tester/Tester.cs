using NAudio.CoreAudioApi;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Audio_Latency_Tester
{
    public partial class Tester : Form
    {
        public Tester()
        {
            InitializeComponent();
        }

        private MMDeviceEnumerator AudioDeviceEnumerator = new MMDeviceEnumerator();

        private MMDevice Device;

        private MMDevice VACEndpoint;

        private void Tester_Load(object sender, EventArgs e)
        {
            foreach (var endpoint in AudioDeviceEnumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active))
            {
                PlaybackDevicesDropDown.Items.Add(endpoint.FriendlyName);
            }

            foreach (var endpoint in AudioDeviceEnumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active))
            {
                if (endpoint.DeviceFriendlyName.ToLower().Contains("virtual"))
                {
                    VACDevicesDropDown.Items.Add(endpoint.FriendlyName);
                }
            }

            if (PlaybackDevicesDropDown.Items.Count > 0)
            {
                PlaybackDevicesDropDown.SelectedIndex = 0;
            }

            VACDevicesDropDown.SelectedIndex = 0;

            Device = AudioDeviceEnumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active).First(o => o.FriendlyName == PlaybackDevicesDropDown.Text);
        }

        private Stopwatch stopwatch = new Stopwatch();

        private ISampleProvider Beep = new SignalGenerator()
        {
            Gain = 0.2,
            Frequency = 500,
            Type = SignalGeneratorType.Sin
        }.Take(TimeSpan.FromMilliseconds(50));

        private WasapiOut BeepEvent;

        private void TestButton_Click(object sender, EventArgs e)
        {
            //Retard Fix
            BeepEvent = new WasapiOut(Device, AudioClientShareMode.Shared, true, 50);

            var Volume = 0f;

            BeepEvent.Init(Beep);

            stopwatch.Start();

            BeepEvent.Play();

            //Wait Until The Sound Plays, Counting How Long It Takes
            while (Volume <= 0.1f)
            {
                Volume = VACEndpoint?.AudioMeterInformation.MasterPeakValue ?? Device.AudioMeterInformation.MasterPeakValue;
            }

            stopwatch.Stop();

            //Refresh Beep; Ready For Another Go.
            Beep = new SignalGenerator()
            {
                Gain = 0.2,
                Frequency = 500,
                Type = SignalGeneratorType.Sin
            }.Take(TimeSpan.FromMilliseconds(50));

            LatencyLabel.Text = "Latency: " + stopwatch.ElapsedMilliseconds + "ms";

            stopwatch.Reset();
        }

        private void PlaybackDevicesDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Device = AudioDeviceEnumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active).First(o => o.FriendlyName == PlaybackDevicesDropDown.Text);
        }

        private void VACDevicesDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            VACEndpoint = VACDevicesDropDown.Text == "None" ? null : AudioDeviceEnumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active).First(o => o.FriendlyName == VACDevicesDropDown.Text);
        }
    }
}
