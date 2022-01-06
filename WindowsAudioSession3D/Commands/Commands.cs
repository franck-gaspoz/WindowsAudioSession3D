using System.Windows.Input;

namespace WindowsAudioSession3D.Commands
{
    public static class Commands
    {
        /// <summary>
        /// start command
        /// </summary>
        public static ICommand Start { get; } = StartCommand.Instance;


        /// <summary>
        /// stop command
        /// </summary>
        public static ICommand Stop { get; } = StopCommand.Instance;

    }
}
