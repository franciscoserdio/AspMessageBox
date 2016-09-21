

namespace FW.UI
{
    /// <summary>
    /// Interface to implement in objects dedicated to show message box
    /// </summary>
    public interface IMessageBox
    {
        /// <summary>
        /// Show a message to the user
        /// </summary>
        /// <param name="message">The message to show</param>
        void ShowMessage(string message);

        /// <summary>
        /// Show a message to the user
        /// </summary>
        /// <param name="messageBoxKey">The message box key to receive in the response event.</param>
        /// <param name="message">The message to show</param>
        void ShowMessage(
            string messageBoxKey,
            string message);


        /// <summary>
        /// Show a message to the user
        /// </summary>
        /// <param name="messageBoxKey">The message box key to receive in the response event.</param>
        /// <param name="message">The message to show</param>
        /// <param name="buttons">The buttons to answer the message</param>
        void ShowMessage(
            string messageBoxKey,
            string message, 
            MessageBoxButtons buttons);


        /// <summary>
        /// Show a message to the user with type 'messageType'
        /// </summary>
        /// <param name="messageBoxKey">The message box key to receive in the response event.</param>
        /// <param name="message">The message to show</param>
        /// <param name="title">The title of the message</param>
        void ShowMessage(
            string messageBoxKey,
            string message,
            string title);


        /// <summary>
        /// Show a message to the user with type 'messageType'
        /// </summary>
        /// <param name="messageBoxKey">The message box key to receive in the response event.</param>
        /// <param name="message">The message to show</param>
        /// <param name="title">The title of the message</param>
        /// <param name="buttons">The buttons to answer the message</param>
        void ShowMessage(
            string messageBoxKey,
            string message,
            string title,
            MessageBoxButtons buttons);


        /// <summary>
        /// Show a message to the user with type 'messageType'
        /// </summary>
        /// <param name="messageBoxKey">The message box key to receive in the response event.</param>
        /// <param name="message">The message to show</param>
        /// <param name="messageType">The type of the message</param>
        void ShowMessage(
            string messageBoxKey,
            string message,
            MessageBoxType messageType);


        /// <summary>
        /// Show a message to the user with type 'messageType'
        /// </summary>
        /// <param name="messageBoxKey">The message box key to receive in the response event.</param>
        /// <param name="message">The message to show</param>
        /// <param name="messageType">The type of the message</param>
        /// <param name="buttons">The buttons to answer the message</param>
        void ShowMessage(
            string messageBoxKey,
            string message,
            MessageBoxType messageType,
            MessageBoxButtons buttons);

        /// <summary>
        /// Show a message to the user with type 'messageType'
        /// </summary>
        /// <param name="messageBoxKey">The message box key to receive in the response event.</param>
        /// <param name="message">The message to show</param>
        /// <param name="title">The title of the message</param>
        /// <param name="messageType">The type of the message</param>
        void ShowMessage(
            string messageBoxKey,
            string message,
            string title,
            MessageBoxType messageType);


        /// <summary>
        /// Show a message to the user with type 'messageType'
        /// </summary>
        /// <param name="messageBoxKey">The message box key to receive in the response event.</param>
        /// <param name="message">The message to show</param>
        /// <param name="title">The title of the message</param>
        /// <param name="messageType">The type of the message</param>
        /// <param name="buttons">The buttons to answer the message</param>
        void ShowMessage(
            string messageBoxKey,
            string message,
            string title,
            MessageBoxType messageType,
            MessageBoxButtons buttons);


        /// <summary>
        /// The message box response event
        /// </summary>
        event MessageBoxEventHandler ResponseMessageBox;
    }
}
