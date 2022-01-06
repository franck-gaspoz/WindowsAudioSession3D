using System.ComponentModel;

using Un4seen.BassWasapi;

using WPFUtilities.ComponentModels;

namespace WindowsAudioSession3D.Components.Appl
{
    /// <summary>
    /// application view model
    /// </summary>
    public interface IAppViewModel : IModelBase
    {
        /// <summary>
        /// FFT resolution
        /// </summary>
        int FFTResolution { get; set; }

        /// <summary>
        /// sampling frequency
        /// </summary>
        int SamplingFrequency { get; set; }

        /// <summary>
        /// sample length
        /// </summary>
        int SampleBufferLength { get; set; }

        /// <summary>
        /// fft bars count
        /// </summary>
        int FFTBarsCount { get; set; }

        /// <summary>
        /// selected sound device (BassNet)
        /// </summary>
        BASS_WASAPI_DEVICEINFO SelectedDevice { get; set; }

        /// <summary>
        /// listenables devices
        /// </summary>
        BindingList<BASS_WASAPI_DEVICEINFO> ListenableDevices { get; }

        /// <summary>
        /// indicates if audio engine is started or not
        /// </summary>
        bool IsStarted { get; set; }

    }
}
