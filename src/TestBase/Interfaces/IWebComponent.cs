namespace TestBase.Interfaces;

public interface IWebComponent
{
    /// <summary>
    /// Perform an action (like set text, click, etc.) on the current Web Component.
    /// </summary>
    IWebComponentActions Perform { get; }
}