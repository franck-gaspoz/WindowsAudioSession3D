
using System.ComponentModel;

using Un4seen.BassWasapi;

using WASApiBassNet.Components.AudioCapture;

using WPFUtilities.ComponentModels;

namespace WindowsAudioSession3D.Components.Appl
{
    /// <summary>
    /// application view model
    /// </summary>
    public class AppViewModel : ModelBase, IAppViewModel
    {
        /// <inheritdoc/>
        public int FFTResolution { get; set; } = 8192;

        /// <inheritdoc/>
        public int SamplingFrequency { get; set; } = 44100;

        /// <inheritdoc/>
        public int SampleBufferLength { get; set; } = 16384;

        /// <inheritdoc/>
        public int FFTBarsCount { get; set; } = 512;

        /// <inheritdoc/>
        public BASS_WASAPI_DEVICEINFO SelectedDevice { get; set; }

        /// <inheritdoc/>
        public BindingList<BASS_WASAPI_DEVICEINFO> ListenableDevices { get; protected set; }
            = new BindingList<BASS_WASAPI_DEVICEINFO>();

        bool _isStarted = false;
        /// <inheritdoc/>
        public bool IsStarted
        {
            get => _isStarted;
            set
            {
                _isStarted = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// creates and initialize an application view model
        /// </summary>
        public AppViewModel()
        {
            new ListenableSoundDevices().DevicesList.ForEach(x => ListenableDevices.Add(x));
        }

    }
}
