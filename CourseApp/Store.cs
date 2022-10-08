namespace CourseApp
{
    using System;

    public class Store
    {
        private IDisplayable[] storage;
        private int index;
        public Store()
        {
            storage = new IDisplayable[5];
        } 

        public void AddItem(IDisplayable item)
        {
            storage[index] = item;
            index++;
        }

        public void Show()
        {
            for(int i=0; i<index; i++)
            {
                Console.WriteLine($"item {i} {storage[i].Display()}");
            }
        }

    }
}