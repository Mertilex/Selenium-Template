namespace TestBase.Interfaces.Actions;

public interface IClickAction : IAction
{
    /// <summary>Click the current Web Component (button / link).</summary>
    /// <param name="clickType">Defines the way how the Web Component should be clicked.</param>
    /// <returns>Value indicating whether the action has been performed.</returns>
    bool Click(ClickType clickType = ClickType.Mouse);
}