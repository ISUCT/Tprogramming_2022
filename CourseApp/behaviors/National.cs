namespace CourseApp;
using System;

public class National : IHymnBehavior
{
    public string HymnType { get => "National"; }

    public void Hymn()
    {
        Console.WriteLine("National Hymn!");
    }
}