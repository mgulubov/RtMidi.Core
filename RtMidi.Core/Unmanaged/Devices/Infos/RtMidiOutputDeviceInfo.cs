namespace RtMidi.Core.Unmanaged.Devices.Infos
{
    public class RtMidiOutputDeviceInfo : RtMidiDeviceInfo
    {
        public RtMidiOutputDeviceInfo(uint port, string name) : base(port, name)
        {
        }

        public IRtMidiOutputDevice CreateDevice()
        {
            return new RtMidiOutputDevice(Port);
        }
    }
}
