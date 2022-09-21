namespace CourseApp;
using System;

public class Religic : IHymnBehavior
{
    public string HymnType { get => "Religic"; }

    public void Hymn()
    {
        Console.WriteLine("Religic Hymn!");
    }
}