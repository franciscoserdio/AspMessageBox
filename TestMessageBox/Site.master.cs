using System;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

using FW.UI;

public partial class SiteMaster : MasterPage, IMessageBox
{
    private const string AntiXsrfTokenKey = "__AntiXsrfToken";
    private const string AntiXsrfUserNameKey = "__AntiXsrfUserName";
    private string _antiXsrfTokenValue;

    protected void Page_Init(object sender, EventArgs e)
    {
        // The code below helps to protect against XSRF attacks
        var requestCookie = Request.Cookies[AntiXsrfTokenKey];
        Guid requestCookieGuidValue;
        if (requestCookie != null && Guid.TryParse(requestCookie.Value, out requestCookieGuidValue))
        {
            // Use the Anti-XSRF token from the cookie
            _antiXsrfTokenValue = requestCookie.Value;
            Page.ViewStateUserKey = _antiXsrfTokenValue;
        }
        else
        {
            // Generate a new Anti-XSRF token and save to the cookie
            _antiXsrfTokenValue = Guid.NewGuid().ToString("N");
            Page.ViewStateUserKey = _antiXsrfTokenValue;

            var responseCookie = new HttpCookie(AntiXsrfTokenKey)
            {
                HttpOnly = true,
                Value = _antiXsrfTokenValue
            };
            if (FormsAuthentication.RequireSSL && Request.IsSecureConnection)
            {
                responseCookie.Secure = true;
            }
            Response.Cookies.Set(responseCookie);
        }

        Page.PreLoad += master_Page_PreLoad;
    }

    protected void master_Page_PreLoad(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Set Anti-XSRF token
            ViewState[AntiXsrfTokenKey] = Page.ViewStateUserKey;
            ViewState[AntiXsrfUserNameKey] = Context.User.Identity.Name ?? String.Empty;
        }
        else
        {
            // Validate the Anti-XSRF token
            if ((string)ViewState[AntiXsrfTokenKey] != _antiXsrfTokenValue
                || (string)ViewState[AntiXsrfUserNameKey] != (Context.User.Identity.Name ?? String.Empty))
            {
                throw new InvalidOperationException("Validation of Anti-XSRF token failed.");
            }
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Unnamed_LoggingOut(object sender, LoginCancelEventArgs e)
    {
        Context.GetOwinContext().Authentication.SignOut();
    }

    #region Miembros de IMessageBox

    /// <summary>
    /// The message box OnResponse CommandEventHandler
    /// </summary>
    public delegate MessageBoxEventHandler OnResponseMessageBox(object sender, MessageBoxEventArgs e);

    /// <summary>
    /// The message box response event
    /// </summary>
    public event MessageBoxEventHandler ResponseMessageBox;

    /// <summary>
    /// Handles the OnResponse event of the ctlMessageBox control.
    /// </summary>
    /// <param name="sender">La fuente del evento</param>
    /// <param name="e">La instancia de <see cref="Expectra.Framework.UI.MessageBoxEventArgs"/> que contiene los datos del evento.</param>
    protected void ctlMessageBox_OnResponse(object sender, MessageBoxEventArgs e)
    {
        if (null != this.ResponseMessageBox)
        {
            this.ResponseMessageBox(
                sender,
                e);
        }
        else
        {
            // Loosing the user response
        }
    }

    /// <summary>
    /// Show a message to the user
    /// </summary>
    /// <param name="message">The message to show</param>
    public void ShowMessage(string message)
    {
        this.ShowMessage(
            string.Empty,
            message,
            string.Empty,
            MessageBoxType.None,
            MessageBoxButtons.OK);
    }

    /// <summary>
    /// Show a message to the user
    /// </summary>
    /// <param name="messageBoxKey">The message box key to receive in the response event.</param>
    /// <param name="message">The message to show</param>
    public void ShowMessage(
        string messageBoxKey,
        string message)
    {
        this.ShowMessage(
            messageBoxKey,
            message,
            string.Empty,
            MessageBoxType.None,
            MessageBoxButtons.OK);
    }

    /// <summary>
    /// Show a message to the user
    /// </summary>
    /// <param name="messageBoxKey">The message box key to receive in the response event.</param>
    /// <param name="message">The message to show</param>
    /// <param name="buttons">The buttons to answer the message</param>
    public void ShowMessage(
        string messageBoxKey,
        string message,
        MessageBoxButtons buttons)
    {
        this.ShowMessage(
            messageBoxKey,
            message,
            string.Empty,
            MessageBoxType.None,
            buttons);
    }

    /// <summary>
    /// Show a message to the user
    /// </summary>
    /// <param name="messageBoxKey">The message box key to receive in the response event.</param>
    /// <param name="message">The message to show</param>
    /// <param name="title">The title of the message</param>
    public void ShowMessage(
        string messageBoxKey,
        string message,
        string title)
    {
        this.ShowMessage(
            messageBoxKey,
            message,
            title,
            MessageBoxType.None,
            MessageBoxButtons.OK);
    }

    /// <summary>
    /// Show a message to the user
    /// </summary>
    /// <param name="messageBoxKey">The message box key to receive in the response event.</param>
    /// <param name="message">The message to show</param>
    /// <param name="title">The title of the message</param>
    /// <param name="buttons">The buttons to answer the message</param>
    public void ShowMessage(
        string messageBoxKey,
        string message,
        string title,
        MessageBoxButtons buttons)
    {
        this.ShowMessage(
            messageBoxKey,
            message,
            title,
            MessageBoxType.None,
            buttons);
    }

    /// <summary>
    /// Show a message to the user
    /// </summary>
    /// <param name="messageBoxKey">The message box key to receive in the response event.</param>
    /// <param name="message">The message to show</param>
    /// <param name="messageBoxType">The type of the message</param>
    public void ShowMessage(
        string messageBoxKey,
        string message,
        MessageBoxType messageBoxType)
    {
        this.ShowMessage(
            messageBoxKey,
            message,
            string.Empty,
            messageBoxType,
            MessageBoxButtons.OK);
    }

    /// <summary>
    /// Show a message to the user
    /// </summary>
    /// <param name="messageBoxKey">The message box key to receive in the response event.</param>
    /// <param name="message">The message to show</param>
    /// <param name="messageBoxType">The type of the message</param>
    /// <param name="buttons">The buttons to answer the message</param>
    public void ShowMessage(
        string messageBoxKey,
        string message,
        MessageBoxType messageBoxType,
        MessageBoxButtons buttons)
    {
        this.ShowMessage(
            messageBoxKey,
            message,
            string.Empty,
            messageBoxType,
            buttons);
    }

    /// <summary>
    /// Show a message to the user with type 'MessageBoxType'
    /// </summary>
    /// <param name="messageBoxKey">The message box key to receive in the response event.</param>
    /// <param name="message">The message to show</param>
    /// <param name="title">The title of the message</param>
    /// <param name="messageBoxType">The type of the message</param>
    public void ShowMessage(
        string messageBoxKey,
        string message,
        string title,
        MessageBoxType messageBoxType)
    {
        this.ShowMessage(
            messageBoxKey,
            message,
            title,
            messageBoxType,
            MessageBoxButtons.OK);
    }


    /// <summary>
    /// Show a message to the user with type 'messageType'
    /// </summary>
    /// <param name="messageBoxKey">The message box key to receive in the response event.</param>
    /// <param name="message">The message to show</param>
    /// <param name="log">The log to show.</param>
    /// <param name="title">The title of the message</param>
    /// <param name="messageType">The type of the message</param>
    /// <param name="buttons">The buttons to answer the message</param>
    public void ShowMessage(
        string messageBoxKey,
        string message,
        string title,
        MessageBoxType messageBoxType,
        MessageBoxButtons buttons)
    {
        this.ctlMessageBox.MessageBoxKey = messageBoxKey;
        this.ctlMessageBox.Message = message;
        this.ctlMessageBox.Title = title;
        this.ctlMessageBox.Icon = messageBoxType;
        this.ctlMessageBox.Buttons = buttons;

        this.ctlMessageBox.Visible = true;

        this.upMessages.Update();
    }

    #endregion

}