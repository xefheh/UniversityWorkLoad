using UniversityWorkLoad.Infrastructure;

namespace UniversityWorkLoad.MainFormSettings;

public partial class MainForm
{
    private void ColorClickHandler(object sender, EventArgs e)
    {
        _lastColorCommand?.UndoAction();
        _lastColorCommand = new ToolColorCommand((ToolStripMenuItem)sender);
        _lastColorCommand.MakeAction();
    }

    private void ColorHoverHandler(object sender, EventArgs e)
    {
        if (sender is ToolStripMenuItem item) item.BackColor = Color.Goldenrod;
    }

    private void ColorLeaveHandler(object sender, EventArgs e)
    {
        if (sender is ToolStripMenuItem item) item.BackColor = Color.Empty;
    }
}