

namespace FW.UI
{
    /// <summary>
    /// Message box buttons
    /// </summary>
    public enum MessageBoxButtons : ushort
    {
        /// <summary>
        /// The message box contains an Accept button
        /// </summary>
        OK = 0,

        /// <summary>
        /// The message box contains an Accept button and a Cancel button
        /// </summary>
        OKCancel = 1,

        /// <summary>
        /// The message box contains Abort, Retry and Ignore buttons
        /// </summary>
        AbortRetryIgnore = 2,

        /// <summary>
        /// The message box contains Yes, No and Cancel button
        /// </summary>
        YesNoCancel = 3,

        /// <summary>
        /// The message box contains Yes and No button
        /// </summary>
        YesNo = 4,

        /// <summary>
        /// The message box contains Retry and Cancel button
        /// </summary>
        RetryCancel = 5
    }
}
