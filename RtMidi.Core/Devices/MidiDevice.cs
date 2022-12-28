﻿namespace RtMidi.Core.Devices
{
    using System;

    using Unmanaged.Devices;
    
    public abstract class MidiDevice : IMidiDevice 
    {
        private readonly IRtMidiDevice _rtMidiDevice;
        private bool _disposed;

        protected MidiDevice(IRtMidiDevice rtMidiDevice, string name)
        {
            _rtMidiDevice = rtMidiDevice ?? throw new ArgumentNullException(nameof(rtMidiDevice));
            Name = name;
        }

        public bool IsOpen => _rtMidiDevice.IsOpen;
        public string Name { get; }
        public bool Open() => _rtMidiDevice.Open();
        public void Close() => _rtMidiDevice.Close();
        
        public void Dispose()
        {
            if (_disposed) return;

            try
            {
                Disposing();
                _rtMidiDevice.Dispose();
            }
            finally
            {
                _disposed = true;
            }
        }

        protected virtual void Disposing()
        {
        }
    }
}
