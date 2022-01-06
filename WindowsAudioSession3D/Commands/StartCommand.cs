using System;
using System.Windows.Input;

using WPFUtilities.Commands;
using WPFUtilities.Helpers;

namespace WindowsAudioSession3D.Commands
{
    /// <summary>
    /// start audio plug engine command
    /// </summary>
    public class StartCommand : AbstractCommand<StartCommand>, ICommand
    {
        /// <inheritdoc/>
        public override bool CanExecute(object parameter)
            => true;

        /// <summary>
        /// start audio plug engine command
        /// </summary>
        /// <param name="parameter">not used</param>
        public override void Execute(object parameter)
        {
            try
            {
                if (App.ViewModel.SelectedDevice == null)
                {
                    // no device selected -> can't start
                    return;
                }
                App.AppComponents.BuildComponents(App.ViewModel);
                var deviceId = Convert.ToInt32(App.ViewModel.SelectedDevice.id);
                App.AppComponents.AudioPluginEngine.Start(deviceId, App.ViewModel.SamplingFrequency);
            }
            catch (Exception exception)
            {
                UIHelper.ShowError(exception);
            }

        }
    }
}