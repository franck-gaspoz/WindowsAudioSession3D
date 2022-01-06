
using System.ComponentModel;

using WPFUtilities.ComponentModels;

namespace WindowsAudioSession3D.Components.Messaging
{
    /// <summary>
    /// messages view model
    /// </summary>
    public class MessagesViewModel : ModelBase, IModelBase, IMessagesViewModel
    {
        /// <inheritdoc/>
        public BindingList<string> Messages { get; set; } = new BindingList<string>();

        /// <summary>
        /// build a new instance
        /// </summary>
        public MessagesViewModel()
        {

        }
    }
}
