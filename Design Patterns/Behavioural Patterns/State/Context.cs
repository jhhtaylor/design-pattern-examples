// Context Class

public class Document
{
    private IDocumentState _state;

    public Document(IDocumentState state)
    {
        _state = state;
    }

    public void SetState(IDocumentState state)
    {
        _state = state;
    }

    public void Publish()
    {
        _state.Publish();
        if (_state is Draft)
        {
            SetState(new Moderation());
        }
        else if (_state is Moderation)
        {
            SetState(new Published());
        }
    }
}
