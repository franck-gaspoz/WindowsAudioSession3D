using System.ComponentModel;

namespace WindowsAudioSession3D.Components.Messaging
{
    /// <summary>
    /// messages view model
    /// </summary>
    public interface IMessagesViewModel
    {
        /// <summary>
        /// messages
        /// </summary>
        BindingList<string> Messages { get; set; }
    }
}