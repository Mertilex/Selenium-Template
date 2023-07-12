namespace TestBase.Interfaces.Actions;

/// <summary>
/// Defines the way how the Web Component should be clicked.
/// </summary>
public enum ClickType
{
    /// <summary>Click with left mouse button.</summary>
    Mouse,
    /// <summary>Click by using Java Script events.</summary>
    Script,
    /// <summary>Click with right mouse button.</summary>
    Right,
}