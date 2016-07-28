namespace Tests
{
    internal class Person
    {
        private string name;
        public string Name { get; set; }

        public Person(string name)
        {
            this.Name = name;
        }

        public int Age { get; internal set; }
    }
}