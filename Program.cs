using OOPExample7;

//Reference     Object (instans)
Royalty p1 = new Royalty();
p1.Name = "Frede";
p1.Shoesize = 32;
p1.ShowShowsize();

Console.WriteLine(p1.Name);

Princess p2 = new Princess() { Name = "Mary", Shoesize = 52};
Console.WriteLine(p2.Name);
p2.ShowShowsize();

Prince p3 = new Prince("Christian", 18);
Console.WriteLine(p3.Name);

//Prince p4 = (Prince)p1;



DateTime dt = new DateTime(2000, 10, 5);


