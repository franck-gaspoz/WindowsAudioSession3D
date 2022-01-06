using WASApiBassNet.Components.AudioCapture;
using WASApiBassNet.Components.FFT;

namespace WindowsAudioSession3D.Components.Appl
{
    /// <summary>
    /// application components
    /// </summary>
    public class AppComponents
    {
        #region properties

        // <summary>
        /// audio plugin interactor
        /// </summary>
        public IAudioPluginEngine AudioPluginEngine { get; protected set; } = new AudioPluginEngine();

        /// <summary>
        /// wasapi facade
        /// </summary>
        public IWASApi WASApi { get; protected set; } = new WASApi();

        /// <summary>
        /// fft data provider
        /// </summary>
        public IFFTProvider FFTProvider { get; protected set; } = new FFTProvider();

        /// <summary>
        /// fft analyzer
        /// </summary>
        public IFFTAnalyzer FFTAnalyser { get; protected set; } = new FFTAnalyzer();

        #endregion

        /// <summary>
        /// add and setup required components, connect them together and activate the sound capture engine
        /// </summary>
        /// <param name="viewModel">main window view model</param>
        public void BuildComponents(IAppViewModel viewModel)
        {
            // WASApi facade

            AudioPluginEngine.WASApi = WASApi;

            // chain manager

            AudioPluginEngine.Reset();

            // FFT

            FFTProvider.FFTLength = viewModel.FFTResolution.ToSampleLength();

            // FFT component 1

            FFTAnalyser.FFTProvider = FFTProvider;
            FFTAnalyser.BarsCount = viewModel.FFTBarsCount;

            // audio capture handlers components chain

            _ = AudioPluginEngine
                .AddAudioPlugHandler(FFTProvider)
                .AddAudioPlugHandler(FFTAnalyser);
        }

    }
}
