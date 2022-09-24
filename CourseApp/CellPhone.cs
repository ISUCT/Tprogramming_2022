namespace CourseApp
{
    using System;

    public class CellPhone: Phone
    {
        private float diagonal;

          public float Diagonal
        {
            get
            {
                return diagonal;
            }

            set
            {
                if (value > 0 && value < 20)
                {
                    this.diagonal = value;
                }
            }
        }

        public string TrackName {get; set;}

        public CellPhone():base("+70000000","nokia", 2)
        {
            Console.WriteLine("Cell phone without params");
        }

        public CellPhone(string number, string name, int diagonal)
        {
            Console.WriteLine("Cell phone with params");
        }
        public void DeclineCall()
        {
            Console.WriteLine("Decline Call");
        }
        public void GetMessage()
        {
            Console.WriteLine("Getting text message");
        }
        public void SendMessage()
        {
            Console.WriteLine("Sending message");
        }
        
        public override string GetDisplay()
        {
            return $"Сотовый телефон {Name} номер:{Number}, произведен {Year}";
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

    }
}