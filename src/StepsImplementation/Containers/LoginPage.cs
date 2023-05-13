namespace StepsImplementation.Containers;

public partial class LoginPage
{
    public void SetLoginTextBox(string value)
    {
        LoginTextBox.Text = value; //TODO: this should be done as .Perform.SetText()
    }
}