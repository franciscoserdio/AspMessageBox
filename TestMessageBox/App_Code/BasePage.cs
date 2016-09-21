using System;
using System.Web.UI;
using FW.UI;

namespace TestWeb
{
    public class BasePage : Page
    {
        /// <summary>
        /// Gets the message box.
        /// </summary>
        /// <value>El Message box.</value>
        public IMessageBox MessageBox
        {
            get
            {
                MasterPage currentMaster = this.Master;
                while (null != currentMaster)
                {
                    if (currentMaster is IMessageBox)
                    {
                        return (currentMaster as IMessageBox);
                    }
                    else
                    {
                        currentMaster = currentMaster.Master;
                    }
                }
                return null;
            }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Web.UI.Page.InitComplete" /> event after page initialization.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnInitComplete(EventArgs e)
        {
            if (null != this.MessageBox)
                this.MessageBox.ResponseMessageBox += new MessageBoxEventHandler(OnResponseMessageBox);

            base.OnInitComplete(e);
        }

        /// <summary>
        /// Called when [response message box].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="MessageBoxEventArgs"/> instance containing the event data.</param>
        protected virtual void OnResponseMessageBox(object sender, MessageBoxEventArgs e)
        {
        }
    }
}