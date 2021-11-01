namespace Models
{
    public class Reviews
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public int userId { get; set; }
        public Users User { get; set; }

        public override string ToString()
        {
            return $"Rating: {Rating}";
        }
    }
}