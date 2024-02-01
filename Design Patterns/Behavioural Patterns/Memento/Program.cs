//Client Code

class Program
{
    static void Main(string[] args)
    {
        TextEditor editor = new TextEditor();
        Caretaker caretaker = new Caretaker();

        editor.Content = "First line of text";
        caretaker.SaveState(editor);

        editor.Content = "Second line of text";

        Console.WriteLine("Current content: " + editor.Content);

        caretaker.RestoreState(editor);
        Console.WriteLine("Content after restore: " + editor.Content);
    }
}
