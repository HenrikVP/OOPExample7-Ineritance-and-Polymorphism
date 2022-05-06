namespace OOPExample7
{
    internal class Royalty
    {
        //Properties (Egenskaber). Always public and with a get, sometimes with a set
        public string Name { get; set; }
        public int Shoesize { get; set; }

        //Two different constructors/methods with same returntype and methodname, but 
        //different parameters is called "Overloading"
        public Royalty()
        {

        }

        public Royalty(string name, int shoesize)
        {
            Name = name;
            Shoesize = shoesize;
        }

        // A method that is overridden in a child (derived/parent) class have to be virtual 
        public virtual void ShowShowsize() { Console.WriteLine(Shoesize); }
    }
}
