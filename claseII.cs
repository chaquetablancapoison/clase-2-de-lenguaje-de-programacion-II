Console.WriteLine("Nombre: ");
String? nombre = Console.ReadLine();
Console.WriteLine("Apellido: ");
String? apellido = Console.ReadLine();
Console.WriteLine("Edad: ");
int edad = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Altura: ");
float altura = float.Parse(Console.ReadLine());

Console.WriteLine($"hola, mi nombre es {nombre} {apellido}");
Console.WriteLine($"tengo {edad} años y mido {altura} metros");
