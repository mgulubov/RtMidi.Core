namespace RtMidi.Core.Unmanaged.Devices.Infos
{
    public class RtMidiInputDeviceInfo : RtMidiDeviceInfo
    {
        public RtMidiInputDeviceInfo(uint port, string name) : base(port, name)
        {
        }

        public IRtMidiInputDevice CreateDevice()
        {
            return new RtMidiInputDevice(Port);
        }
    }
}
