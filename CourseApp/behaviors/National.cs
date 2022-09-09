namespace CourseApp;
using System;

public class National : IHymnBehavior
{
    public void Hymn()
    {
        Console.WriteLine("National Hymn!");
    }
}