namespace OOPExample7
{
    internal class Prince : Royalty
    {
        public string FavoriteCar { get; set; }

        //In order to inherit the constructor from a base class, the base
        //class constructors should be inherited too.
        public Prince() : base()
        {

        }

        public Prince(string name, int shoesize) : base(name, shoesize)
        {
        }
    }
}
