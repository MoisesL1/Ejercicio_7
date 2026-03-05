Dictionary<int, string> productos = new Dictionary<int, string>();

Console.WriteLine("Ingrese la cantidad de productos que ingresaea: ");
int cant = int.Parse(Console.ReadLine());

int id;
bool existe;

for(int x = 0; x < cant; x++)
{
    do
    {
        Console.WriteLine("Ingrese el ID: ");
        id = int.Parse(Console.ReadLine());

        existe = productos.ContainsKey(id);

        if (existe == true)
        {
            Console.WriteLine("Ingrese el nombre del proucto: ");
            string nombre = Console.ReadLine();

            productos.Add(id, nombre);
        }

        else
        {
            Console.WriteLine("Ingreso un ID que ya existe. ");
        }
    }
    while(!existe);
}