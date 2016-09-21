using System.Runtime.InteropServices;

namespace FW.UI
{
    /// <summary>
    /// Message box responses returned
    /// </summary>
    [ComVisible(true)]
    public enum MessageBoxResponse : ushort
    {
        /// <summary>
        /// The message box returns Nothing. That means that modal dialog continues running
        /// </summary>
        None = 0,

        /// <summary>
        /// The message box returns Ok (Use to be the Accept button)
        /// </summary>
        OK = 1,

        /// <summary>
        /// The message box returns Cancel (Use to be the Cancel button)
        /// </summary>
        Cancel = 2,

        /// <summary>
        /// The message box returns Abort (Use to be the Abort button)
        /// </summary>
        Abort = 3,
        
        /// <summary>
        /// The message box returns Retry (Use to be the Retry button)
        /// </summary>
        Retry = 4,

        /// <summary>
        /// The message box returns Ignore (Use to be the Ignore button)
        /// </summary>
        Ignore = 5,
        
        /// <summary>
        /// The message box returns Yes (Use to be the Yes button)
        /// </summary>
        Yes = 6,

        /// <summary>
        /// The message box returns No (Use to be the No button)
        /// </summary>
        No = 7,
    }
}
