

namespace FW.UI
{
    /// <summary>
    /// The different information types of message box
    /// </summary>
    public enum MessageBoxType : ushort 
    {
        /// <summary>
        /// The message box does not contain any symbol
        /// </summary>
        None = 0,

        /// <summary>
        /// The message box contains a symbol with a white X and an red background circle
        /// </summary>
        Error = 16,
        
        /// <summary>
        /// The message box contains a symbol with a white X and an red background circle
        /// </summary>
        Hand = 16,
        
        /// <summary>
        /// The message box contains a symbol with a white X and an red background circle
        /// </summary>
        Stop = 16,

        /// <summary>
        /// The message box contains a question symbol with inside a circle
        /// </summary>
        Question = 32,
        
        /// <summary>
        /// The message box contains an exclamation symbol inside a yellow background triangle
        /// </summary>
        Exclamation = 48,

        /// <summary>
        /// The message box contains an exclamation symbol inside a yellow background triangle
        /// </summary>
        Warning = 48,
        
        /// <summary>
        /// The message box contains a symbol with a lowercase 'i' inside a circle
        /// </summary>
        Information = 64,

        /// <summary>
        /// The message box contains a symbol with a lowercase 'i' inside a circle
        /// </summary>
        Asterisk = 64,
    }
}
