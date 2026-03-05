Dictionary<int, string> productos = new Dictionary<int, string>();

Console.WriteLine("Ingrese la cantidad de productos que ingresara: ");
int cant = int.Parse(Console.ReadLine());

int id;
bool existe;

for(int x = 0; x < cant; x++)
{
    Console.WriteLine("Ingrese el ID: ");
    id = int.Parse(Console.ReadLine());

    existe = productos.ContainsKey(id);

    if(existe == true)
    {
        Console.WriteLine("Ingreso un ID existente. ");
    }

    else if (existe == false)
    {
        Console.WriteLine("Ingrese el nombre del producto: ");
        string nombre = Console.ReadLine();

        productos.Add(id, nombre);
    }
}