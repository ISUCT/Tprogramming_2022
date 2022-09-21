namespace CourseApp;
using System;

public class Literary : IHymnBehavior
{
    public string HymnType { get => "Literary"; }

    public void Hymn()
    {
        Console.WriteLine("Literary Hymn!");
    }
}