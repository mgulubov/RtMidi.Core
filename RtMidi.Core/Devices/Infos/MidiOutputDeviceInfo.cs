namespace RtMidi.Core.Devices.Infos
{
    using Unmanaged.Devices.Infos;

    public class MidiOutputDeviceInfo : MidiDeviceInfo<RtMidiOutputDeviceInfo>, IMidiOutputDeviceInfo
    {
        public MidiOutputDeviceInfo(RtMidiOutputDeviceInfo rtMidiDeviceInfo) : base(rtMidiDeviceInfo)
        {
        }

        public IMidiOutputDevice CreateDevice()
        {
            return new MidiOutputDevice(RtMidiDeviceInfo.CreateDevice(), Name);
        }
    }
}
