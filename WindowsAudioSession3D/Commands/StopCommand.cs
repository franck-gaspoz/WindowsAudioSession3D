using System.Windows.Input;

using WPFUtilities.Commands;

namespace WindowsAudioSession3D.Commands
{
    /// <summary>
    /// stop audio plug engine command
    /// </summary>
    public class StopCommand : AbstractCommand<StopCommand>, ICommand
    {
        /// <inheritdoc/>
        public override bool CanExecute(object parameter)
            => true;

        /// <summary>
        /// stop audio plug engine command
        /// </summary>
        /// <param name="parameter">not used</param>
        public override void Execute(object parameter)
        {
            // ...
        }
    }
}