Console.WriteLine("Welcome to the pizzeria Lim");

Console.WriteLine("\nMenu");
Console.WriteLine("Big pizza: 12-15 slices");
Console.WriteLine("Medium pizza: 7-9 slices");
Console.WriteLine("Small pizza: 3-5 slices");

Console.Write("\nWhich will be the size of the pizza: ");
string size = Console.ReadLine();

Console.Write("\nHow many pizzas will be: ");
int pizzas = Int32.Parse(Console.ReadLine());

Console.Write("\nHow many slices do you want: ");
int slices = Int32.Parse(Console.ReadLine());

Console.Write("\nHow many persons will be: ");
int persons = Int32.Parse(Console.ReadLine());

Console.WriteLine("\nHow many portions are for each person: ");
Console.Write(pizzas * slices / persons); 

Console.WriteLine("\nHow many portions are left: ");
Console.Write(pizzas * slices % persons); 

Console.WriteLine("\nOrder complete. Have a nice day");

Console.WriteLine("\nProgram ended");
