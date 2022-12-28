namespace RtMidi.Core.Devices.Infos
{
    using System;

    using Unmanaged.Devices.Infos;

    public class MidiDeviceInfo<TRtMidiDeviceInfo> : IMidiDeviceInfo
        where TRtMidiDeviceInfo : RtMidiDeviceInfo
    {
        protected readonly TRtMidiDeviceInfo RtMidiDeviceInfo;

        public MidiDeviceInfo(TRtMidiDeviceInfo rtMidiDeviceInfo)
        {
            RtMidiDeviceInfo = rtMidiDeviceInfo ?? throw new ArgumentNullException(nameof(rtMidiDeviceInfo));
        }

        public string Name => RtMidiDeviceInfo.Name;
    }
}
