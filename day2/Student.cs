namespace day2
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }
        public string Img { get; set; }
        public override string ToString()
        {
            return $"Name: {Name}";
        }
    }
}
