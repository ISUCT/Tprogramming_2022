namespace Phones
{
    using System;

    public class CellPhone : Phone
    {
        private float diagonal;

        public CellPhone()
            : base("+70000000", "nokia", 2)
        {
            Console.WriteLine("Cell phone without params");
        }

        public CellPhone(string number, string name, int diagonal)
            : base(number, name, 2000)
        {
            this.Diagonal = diagonal;
            Console.WriteLine("Cell phone with params");
        }

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

        public string TrackName { get; set; }

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

        public void PlayMusic()
        {
            Console.WriteLine($"Сейчас играет {TrackName}");
        }

        public override string ToString()
        {
            return $"Сотовый телефон {Name} номер:{Number}, произведен {Year}";
        }

        public override string Display()
        {
            return this.ToString();
        }
    }
}