// Memento and Originator

using System;

// Memento
public class EditorMemento
{
    public string Content { get; private set; }

    public EditorMemento(string content)
    {
        Content = content;
    }
}

// Originator
public class TextEditor
{
    public string Content { get; set; }

    public EditorMemento Save()
    {
        return new EditorMemento(Content);
    }

    public void Restore(EditorMemento memento)
    {
        Content = memento.Content;
    }
}
