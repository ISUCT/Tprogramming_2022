namespace CourseApp;

public interface IHymnBehavior
{   
    public string HymnType { get; }
    public void Hymn();
}