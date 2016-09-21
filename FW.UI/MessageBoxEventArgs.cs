using System;

namespace FW.UI
{
    /// <summary>
    /// Class for message box response events
    /// </summary>
    public class MessageBoxEventArgs : EventArgs
    {
        /// <summary>
        /// Creates a new instance of the class - <see cref="MessageBoxEventArgs"/>.
        /// </summary>
        /// <param name="response">The message box response.</param>
        public MessageBoxEventArgs(MessageBoxResponse response)
            :this(string.Empty, response)
        {
        }

        /// <summary>
        /// Creates a new instance of the class - <see cref="MessageBoxEventArgs"/>.
        /// </summary>
        /// <param name="messageBoxKey">The message box key to receive in the response event.</param>
        /// <param name="response">The message box response.</param>
        public MessageBoxEventArgs(string messageBoxKey, MessageBoxResponse response)
        {
            _messageBoxKey = messageBoxKey;
            _response = response;
        }

        private string _messageBoxKey;
        /// <summary>
        /// Gets or sets the message box key.
        /// </summary>
        /// <value>El Message box key.</value>
        public string MessageBoxKey
        {
            get { return _messageBoxKey; }
            set { _messageBoxKey = value; }
        }

        private MessageBoxResponse _response;
        /// <summary>
        /// Gets or sets the response.
        /// </summary>
        /// <value>El Response.</value>
        public MessageBoxResponse Response
        {
            get { return _response; }
            private set { _response = value; }
        }
	
    }
}
