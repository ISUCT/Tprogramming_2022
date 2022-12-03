namespace CourseApp;

using System;

public abstract class Document
{
    public Document(string name, string type, double size)
    {
        this.Name = name;
        this.Type = type;
        this.Size = size;
    }

    public string Name { get; set; }

    public string Type { get; set; }

    public double Size { get; set; }

    public void Print()
    {
        Console.Write($"Название документа: {Name}  Тип документа: {Type}  Размер документа: {Size} Мб");
    }

    public virtual string DocumentSize()
    {
        return "200 Мб";
    }

    public virtual string Way()
    {
        return "sss";
    }

    public virtual string NameOfEl()
    {
        return "3";
    }
}