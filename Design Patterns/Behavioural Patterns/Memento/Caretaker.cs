// Caretaker

// Caretaker
public class Caretaker
{
    private EditorMemento _memento;

    public void SaveState(TextEditor editor)
    {
        _memento = editor.Save();
    }

    public void RestoreState(TextEditor editor)
    {
        editor.Restore(_memento);
    }
}
