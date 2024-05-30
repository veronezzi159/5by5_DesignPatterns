namespace Models
{
    public class Car
    {
        public static readonly string Insert = "INSERT INTO TB_Car (Name, Color, Year) VALUES (@Name, @Color, @Year)";
        public static readonly string Update = "UPDATE TB_Car SET Name = @Name, Color = @Color, Year = @Year WHERE Id = @id";
        public static readonly string Delete = "DELETE FROM TB_Car WHERE Id = @id";
        public static readonly string GetById = "SELECT Id, Name, Color, Year FROM TB_Car WHERE Id = @id";
        public static readonly string GetAll = "SELECT Id, Name, Color, Year FROM TB_Car";
        public int Id { get; set; }
        public string  Name { get; set; }
        public string  Color { get; set; }
        public int Year { get; set; }

        override public string ToString() => $"Id: {Id}, Name: {Name}, Color: {Color}, Year: {Year}";
        
    }
}
