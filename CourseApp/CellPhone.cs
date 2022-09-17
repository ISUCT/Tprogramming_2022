namespace CourseApp
{
    using System;
    class CellPhone : Phone
    {

        public string TrackName {get; set;}

        public CellPhone(string number, int year): base(number, year)
        { 
            Console.WriteLine("CellPhone constructor clled");
        }

        public void PlayMusic()
        {
            Console.WriteLine($"Сейчас играет {TrackName}");
        }

        public void SendMessage(string number,string message)
        {
            Console.WriteLine($"Отправляем сообщение:{message} на номер {number}");
        }

        public void ReadMessage(string number)
        {
            Console.WriteLine($"Читаем сообщение от контакта {number}");
        } 
        
        public void DeclineCall()
        {
            Console.WriteLine("Звонок сброшен");
        }

        public override void Display()
        {
            Console.WriteLine($"Сотовый телефон номер:{Number}, произведен {Year}");
        } 

    }
}