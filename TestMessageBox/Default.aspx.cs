using System;
using FW.UI;

public partial class _Default : TestWeb.BasePage
{
    private struct Codes
    {
        public const string OK = "ACTION #1";
        public const string OK_CANCEL = "ACTION #2";
        public const string OK_error = "ACTION #3";
        public const string YES_NO = "ACTION #4";
        public const string YES_NO_CANCEL = "ACTION #5";
        public const string ABORT_RETRY_IGNORE = "ACTION #6";
        public const string OK_stop = "ACTION #7";
    }

    protected void btn_OK_Click(object sender, EventArgs e)
    {
        this.txt_response.Text = string.Empty;
        this.MessageBox.ShowMessage(
            Codes.OK,
            Codes.OK,
            MessageBoxType.Information, 
            MessageBoxButtons.OK);
    }

    protected void btn_OK_CANCEL_Click(object sender, EventArgs e)
    {
        this.txt_response.Text = string.Empty;
        this.MessageBox.ShowMessage(
            Codes.OK_CANCEL,
            Codes.OK_CANCEL,
            MessageBoxType.Warning,
            MessageBoxButtons.OKCancel);
    }

    protected void btn_OK_error_Click(object sender, EventArgs e)
    {
        this.txt_response.Text = string.Empty;
        this.MessageBox.ShowMessage(
            Codes.OK_error,
            Codes.OK_error,
            MessageBoxType.Error,
            MessageBoxButtons.OK);
    }

    protected void btn_YES_NO_Click(object sender, EventArgs e)
    {
        this.txt_response.Text = string.Empty;
        this.MessageBox.ShowMessage(
            Codes.YES_NO,
            Codes.YES_NO,
            MessageBoxType.Question,
            MessageBoxButtons.YesNo);
    }

    protected void btn_YES_NO_CANCEL_Click(object sender, EventArgs e)
    {
        this.txt_response.Text = string.Empty;
        this.MessageBox.ShowMessage(
            Codes.YES_NO_CANCEL,
            Codes.YES_NO,
            MessageBoxType.Question,
            MessageBoxButtons.YesNoCancel);
    }

    protected void btn_ABORT_RETRY_IGNORE_Click(object sender, EventArgs e)
    {
        this.txt_response.Text = string.Empty;
        this.MessageBox.ShowMessage(
            Codes.ABORT_RETRY_IGNORE,
            Codes.ABORT_RETRY_IGNORE,
            MessageBoxType.Warning,
            MessageBoxButtons.AbortRetryIgnore);
    }

    protected void btn_OK_stop_Click(object sender, EventArgs e)
    {
        this.txt_response.Text = string.Empty;
        this.MessageBox.ShowMessage(
            Codes.OK_stop,
            Codes.OK_stop,
            MessageBoxType.Stop,
            MessageBoxButtons.OK);
    }

    /// <summary>
    /// Called when [response message box].
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="MessageBoxEventArgs"/> instance containing the event data.</param>
    protected override void OnResponseMessageBox(object sender, MessageBoxEventArgs e)
    {
        //TODO: This is suitable for a table driven method. This is only one example
        this.txt_response.Text = string.Format("MessageBoxKey: {0}. Response: {1}", e.MessageBoxKey, e.Response);
    }
}