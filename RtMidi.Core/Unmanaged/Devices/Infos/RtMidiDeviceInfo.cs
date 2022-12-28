﻿namespace RtMidi.Core.Unmanaged.Devices.Infos
{
    using System;

    public class RtMidiDeviceInfo
    {
        public RtMidiDeviceInfo(uint port, string name)
        {
            Port = port;

            // RtMidi may add port number to end of name to ensure uniqueness
            Name = name.EndsWith(port.ToString())
                ? name.Substring(0, name.LastIndexOf(port.ToString(), StringComparison.Ordinal))
                : name;
        }

        public uint Port { get; }

        public string Name { get; }
    }
}
