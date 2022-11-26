namespace CourseApp.Interfaces
{
    using System;
    using System.Collections.Generic;

    public class UserInterface
    {
        public void Have(IDrawable obj)
        {
            Console.WriteLine(obj.Have());
        }

        public void Have(List<IDrawable> objects)
        {
            foreach (IDrawable obj in objects)
            {
                this.Have(obj);
            }
        }
    }
}
