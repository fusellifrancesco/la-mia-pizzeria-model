namespace NetCore_01.Models
{
    public class Pizza {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Img  { get;}

        public Pizza(int id, string name, string description, string img) {
            Id = id;
            Name = name;
            Description = description;
            Img = img;
        }
    }

}

