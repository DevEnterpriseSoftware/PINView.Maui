namespace PINView.Maui.Helpers
{
    public class PINCompletedEventArgs(string pin) : EventArgs
    {
    public string PIN { get; set; } = pin;
  }
}
