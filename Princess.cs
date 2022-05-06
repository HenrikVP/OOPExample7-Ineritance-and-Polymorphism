namespace OOPExample7
{
    internal class Princess : Royalty
    {
        public string FavoriteBarbie { get; set; }

        //New method with same name/returntype/parameters "OVERRIDEs" inherited class method
        public override void ShowShowsize() 
        { 
            Console.WriteLine("Overide show shoe size " + Shoesize); 
        }
    }
}
