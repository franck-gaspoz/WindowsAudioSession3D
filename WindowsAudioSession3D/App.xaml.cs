using WindowsAudioSession3D.Commands;
using WindowsAudioSession3D.Components.Appl;
using WindowsAudioSession3D.Components.UI;

using WPFUtilities.Components.Appl;
using WPFUtilities.Helpers;

namespace WindowsAudioSession3D
{
    /// <summary>
    /// app launcher
    /// </summary>
    public partial class App : ApplicationBase
    {
        #region properties

        /// <summary>
        /// application view model
        /// </summary>
        public static IAppViewModel ViewModel { get; set; }

        /// <summary>
        /// application components
        /// </summary>
        public static AppComponents AppComponents { get; set; }

        #endregion

        /// <summary>
        /// creates an application instance and show main window
        /// </summary>
        public App()
        {
            var settings = new ApplicationBaseSettings()
            {
                MainWindowType = typeof(MainWindow),
                Initialize = () => Initialize()
            };
            Start(settings);
        }

        /// <summary>
        /// initialize application
        /// </summary>
        void Initialize()
        {
            ViewModel = new AppViewModel();
            AppComponents = new AppComponents();
            AppComponents
                .AudioPluginEngine
                .DispatcherTimerEventHandlerError +=
                    (sender, eventArgs) =>
                    {
                        UIHelper.ShowError(eventArgs.Exception);
                        StopCommand.Instance.Execute(null);
                    };
        }

    }
}
