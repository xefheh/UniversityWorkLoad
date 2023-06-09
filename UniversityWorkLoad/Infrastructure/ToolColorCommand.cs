namespace UniversityWorkLoad.Infrastructure;

public class ToolColorCommand
{
    private readonly ToolStripMenuItem _item;

    public ToolColorCommand(ToolStripMenuItem item) => _item = item;

    public void MakeAction() => _item.BackColor = Color.Khaki;

    public void UndoAction() => _item.BackColor = Color.Empty;
}