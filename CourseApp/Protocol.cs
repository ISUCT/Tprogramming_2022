namespace CourseApp;

using System;

public class Protocol : Document
{
    public Protocol(string name, string type, double size)
        : base(name, type, size)
    {
    }

    public override string DocumentSize()
    {
        return $"{Size} Мб ";
    }

    public override string Way()
    {
        return "D:/files/documents";
    }

    public override string NameOfEl()
    {
        return "ProtocolDocument: ";
    }

    public override string ToString()
    {
        return $"{Name}; {Size} Мб; {Type}";
    }
}