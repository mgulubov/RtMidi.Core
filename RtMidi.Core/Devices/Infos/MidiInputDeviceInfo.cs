namespace RtMidi.Core.Devices.Infos
{
    using Unmanaged.Devices.Infos;

    public class MidiInputDeviceInfo : MidiDeviceInfo<RtMidiInputDeviceInfo>, IMidiInputDeviceInfo
    {
        public MidiInputDeviceInfo(RtMidiInputDeviceInfo rtMidiDeviceInfo) : base(rtMidiDeviceInfo)
        {
        }

        public IMidiInputDevice CreateDevice()
        {
            return new MidiInputDevice(RtMidiDeviceInfo.CreateDevice(), Name);
        }
    }
}
