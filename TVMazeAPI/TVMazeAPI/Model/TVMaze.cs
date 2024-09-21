namespace TVMazeAPI.Model
{
    public class TVMazeShows
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Embedded Embedded { get; set; }


    }
    public class Embedded
    {
        public List<Cast> Casts { get; set; }
    }
    public class Cast
    {
        public List<Person> Persons { get; set; }
    }
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string  Birthday { get; set; }


    }
}
