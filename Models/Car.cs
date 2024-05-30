namespace Models
{
    public class Car
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string  Color { get; set; }
        public int Year { get; set; }

        override public string ToString() => $"Id: {Id}, Name: {Name}, Color: {Color}, Year: {Year}";
        
    }
}
