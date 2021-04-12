namespace Obligatorio1_DA1
{
    class User
    {
        public string Name { get; set; }
        public string Pass { get; set; }


        public User(string name, string pass)
        {
            this.Name = name;
            this.Pass = pass;
        }


    }
}