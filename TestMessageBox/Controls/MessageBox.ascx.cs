using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FW.UI;

namespace FW.UI
{
    public partial class MessageBox : System.Web.UI.UserControl
    {
        private static class INFO
        {
            public const string Title = "Information";
            public const string Img_Url = "/Content/Images/dialog-information.jpg";
        }

        private static class EXCLAMATION
        {
            public const string Title = "Warning";
            public const string Img_Url = "/Content/Images/dialog-warning.jpg";
        }

        private static class ERROR
        {
            public const string Title = "Error";
            public const string Img_Url = "/Content/Images/dialog-error.jpg";
        }

        private static class QUESTION
        {
            public const string Title = "Question";
            public const string Img_Url = "/Content/Images/dialog-question.jpg";
        }


        #region [ Event handlers ]

        /// <summary>
        /// Response Delegate
        /// </summary>
        public delegate MessageBoxEventHandler OnResponse(object sender, MessageBoxEventArgs e);

        /// <summary>
        /// Occurs when [response].
        /// </summary>
        public new event MessageBoxEventHandler Response;

        #endregion

        /// <summary>
        /// Provoca el evento <see cref="E:System.Web.UI.Control.PreRender"></see>.
        /// </summary>
        /// <param name="e">Objeto <see cref="T:System.EventArgs"></see> que contiene los datos del evento.</param>
        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            this.pnl_msg_box.Visible = (!string.IsNullOrEmpty(this.Message));

            // Title + Icon
            switch (this.Icon)
            {
                case MessageBoxType.None:
                    this.lbl_msg_title.Text = (string.IsNullOrEmpty(this.Title)) ? INFO.Title : this.Title;
                    this.img_msg_icon.ImageUrl =  INFO.Img_Url;
                    break;

                case MessageBoxType.Error:
                    this.lbl_msg_title.Text = (string.IsNullOrEmpty(this.Title)) ? ERROR.Title : this.Title;
                    this.img_msg_icon.ImageUrl = ERROR.Img_Url;
                    break;

                case MessageBoxType.Question:
                    this.lbl_msg_title.Text = (string.IsNullOrEmpty(this.Title)) ? QUESTION.Title : this.Title;
                    this.img_msg_icon.ImageUrl = QUESTION.Img_Url;
                    break;

                case MessageBoxType.Exclamation:
                    this.lbl_msg_title.Text = (string.IsNullOrEmpty(this.Title)) ? EXCLAMATION.Title : this.Title;
                    this.img_msg_icon.ImageUrl = EXCLAMATION.Img_Url;
                    break;

                case MessageBoxType.Information:
                    this.lbl_msg_title.Text = (string.IsNullOrEmpty(this.Title)) ? INFO.Title : this.Title;
                    this.img_msg_icon.ImageUrl = INFO.Img_Url;
                    break;

                default:
                    this.lbl_msg_title.Text = (string.IsNullOrEmpty(this.Title)) ? INFO.Title : this.Title;
                    this.img_msg_icon.ImageUrl = INFO.Img_Url;
                    break;
            }

            // Message text
            this.lbt_msg_text.Text = this.Message;

            // Buttons
            this.btn_Yes.Visible = ((this.Buttons == MessageBoxButtons.YesNo) || (this.Buttons == MessageBoxButtons.YesNoCancel));
            this.btn_No.Visible = ((this.Buttons == MessageBoxButtons.YesNo) || (this.Buttons == MessageBoxButtons.YesNoCancel));
            this.btn_Abort.Visible = (this.Buttons == MessageBoxButtons.AbortRetryIgnore);
            this.btn_Retry.Visible = ((this.Buttons == MessageBoxButtons.AbortRetryIgnore) || (this.Buttons == MessageBoxButtons.RetryCancel));
            this.btn_Ignore.Visible = (this.Buttons == MessageBoxButtons.AbortRetryIgnore);
            this.btn_Ok.Visible = ((this.Buttons == MessageBoxButtons.OK) || (this.Buttons == MessageBoxButtons.OKCancel));
            this.btn_Cancel.Visible = ((this.Buttons == MessageBoxButtons.OKCancel) || (this.Buttons == MessageBoxButtons.RetryCancel) || (this.Buttons == MessageBoxButtons.YesNoCancel));

            // Message key for the response
            this.btn_Yes.CommandName = this.MessageBoxKey;
            this.btn_Yes.CommandArgument = MessageBoxResponse.Yes.ToString();

            this.btn_No.CommandName = this.MessageBoxKey;
            this.btn_No.CommandArgument = MessageBoxResponse.No.ToString();

            this.btn_Abort.CommandName = this.MessageBoxKey;
            this.btn_Abort.CommandArgument = MessageBoxResponse.Abort.ToString();

            this.btn_Retry.CommandName = this.MessageBoxKey;
            this.btn_Retry.CommandArgument = MessageBoxResponse.Retry.ToString();

            this.btn_Ignore.CommandName = this.MessageBoxKey;
            this.btn_Ignore.CommandArgument = MessageBoxResponse.Ignore.ToString();

            this.btn_Ok.CommandName = this.MessageBoxKey;
            this.btn_Ok.CommandArgument = MessageBoxResponse.OK.ToString();

            this.btn_Cancel.CommandName = this.MessageBoxKey;
            this.btn_Cancel.CommandArgument = MessageBoxResponse.Cancel.ToString();

            this.mpe_msg_box.Show();
        }


        /// <summary>
        /// Handles the Click event of the response control.
        /// </summary>
        /// <param name="sender">La fuente del evento</param>
        /// <param name="e">La instancia de <see cref="System.EventArgs"/> que contiene los datos del evento.</param>
        protected void response_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            if (Enum.IsDefined(
                    typeof(MessageBoxResponse),
                    (sender as Button).CommandArgument))
            {
                if (null != this.Response)
                {
                    this.Response(
                        this,
                        new MessageBoxEventArgs(
                            (sender as Button).CommandName,
                            (MessageBoxResponse)Enum.Parse(
                                typeof(MessageBoxResponse),
                                (sender as Button).CommandArgument)));
                }
                else
                {
                    // No response
                }
            }
            else
            {
                // TODO: write a log
            }
        }

        #region [ Properties ]

        private string _messageBoxKey = string.Empty;

        /// <summary>
        /// Gets or sets the message box key.
        /// </summary>
        /// <value>El Message box key.</value>
        public string MessageBoxKey
        {
            get { return _messageBoxKey; }
            set { _messageBoxKey = value; }
        }

        private string _title = string.Empty;

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>El Title.</value>
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private string _message = string.Empty;

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>El Message.</value>
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        private MessageBoxType _icon = MessageBoxType.None;

        /// <summary>
        /// Gets or sets the icon.
        /// </summary>
        /// <value>El Icon.</value>
        public MessageBoxType Icon
        {
            get { return _icon; }
            set { _icon = value; }
        }

        private MessageBoxButtons _buttons = MessageBoxButtons.OK;

        /// <summary>
        /// Gets or sets the buttons.
        /// </summary>
        /// <value>El Buttons.</value>
        public MessageBoxButtons Buttons
        {
            get { return _buttons; }
            set { _buttons = value; }
        }

        #endregion
    }
}
