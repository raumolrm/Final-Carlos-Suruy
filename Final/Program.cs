using Final;
// Programa principal - la documetación general está al final del código
class Program
{
    //La clase contiene listas estáticas para almacenar usuarios, prestamos, y un objeto catalogo para manejar los libros. Ser estáticas significa que estos datos son compartidos por todas las instancias de la clase y accesibles a través de toda la ejecución del programa.
    public static List<Usuario> usuarios = new List<Usuario>();
    public static List<Prestamo> prestamos = new List<Prestamo>();
    public static Catalogo catalogo = new Catalogo();

    static void Main(string[] args) //Aquí inicia la aplicación y contiene un bucle que permite al usuario interacturar repetidamente con el sistema.
    {
        // Lógica para añadir algunos libros al catálogo inicial
        catalogo.AgregarLibro(new Libro("Cien años de soledad", "Gabriel García Márquez", "1234567890", 1967, 5));
        catalogo.AgregarLibro(new Libro("El Hobbit", "J.R.R. Tolkien", "0987654321", 1937, 3));

        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine("\nBiblioteca:");
            Console.WriteLine("1) Ingreso de datos");
            Console.WriteLine("2) Mostrar datos");
            Console.WriteLine("3) Salir del programa");
            Console.Write("Seleccione una opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    IngresoDatos();
                    break;
                case 2:
                    MostrarDatos();
                    break;
                case 3:
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }

    static void IngresoDatos() //permite al usuario elegir entre registrar un nuevo usuario, agregar un libro al catálogo o registrar un préstamo
    {
        Console.WriteLine("Ingreso de datos:");
        Console.WriteLine("1) Registrar usuario");
        Console.WriteLine("2) Agregar libro");
        Console.WriteLine("3) Registrar préstamo");
        Console.Write("Seleccione una opción: ");
        int opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                RegistrarUsuario();
                break;
            case 2:
                AgregarLibro();
                break;
            case 3:
                RegistrarPrestamo();
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }

    static void MostrarDatos()//este método ofrece un menú para consultar y mostrar diferentes tipos de datos almacenados en el sistema
    {
        Console.WriteLine("\nMostrar datos:");
        Console.WriteLine("1) Listado de libros prestados por usuario");
        Console.WriteLine("2) Consultar catálogo de libros");
        Console.WriteLine("3) Listado de usuarios activos");
        Console.Write("Seleccione una opción: ");
        int opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                ListadoLibrosPrestados();
                break;
            case 2:
                ConsultarCatalogo();
                break;
            case 3:
                ListadoUsuariosActivos();
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }

    static void RegistrarUsuario()//Solicita al usuario que ingrese detalles
    {
        Console.Write("Ingrese nombre: ");
        string nombre = Console.ReadLine();
        Console.Write("Ingrese apellidos: ");
        string apellidos = Console.ReadLine();
        Console.Write("Ingrese carné: ");
        string carne = Console.ReadLine();
        Console.Write("Ingrese teléfono: ");
        string telefono = Console.ReadLine();

        usuarios.Add(new Usuario(nombre, apellidos, carne, telefono));
        Console.WriteLine("Usuario registrado exitosamente.");
    }

    static void AgregarLibro()//Pide al usuario los detalles del libro y lo agrega al catálogo. Esto incluye información como título, autor, ISBN, año de publicación y cantidad disponible.
    {
        Console.Write("Ingrese título del libro: ");
        string titulo = Console.ReadLine();
        Console.Write("Ingrese autor del libro: ");
        string autor = Console.ReadLine();
        Console.Write("Ingrese ISBN: ");
        string isbn = Console.ReadLine();
        Console.Write("Ingrese año de publicación: ");
        int anoPublicacion = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese cantidad disponible: ");
        int cantidadDisponible = Convert.ToInt32(Console.ReadLine());

        catalogo.AgregarLibro(new Libro(titulo, autor, isbn, anoPublicacion, cantidadDisponible));
        Console.WriteLine("Libro agregado exitosamente al catálogo.");
    }

    static void RegistrarPrestamo()//Permite al usuario crear un préstamo verificando primero que tanto el usuario como el libro existan y estén disponibles. Luego crea un nuevo objeto Prestamo que se agrega a la lista de préstamos y ajusta la cantidad disponible del libro.
    {
        Console.Write("Ingrese el carné del usuario: ");
        string carne = Console.ReadLine();
        Usuario usuario = usuarios.FirstOrDefault(u => u.Carne == carne);
        if (usuario == null)
        {
            Console.WriteLine("Usuario no encontrado.");
            return;
        }

        Console.Write("Ingrese el ISBN del libro: ");
        string isbn = Console.ReadLine();
        Libro libro = catalogo.BuscarLibro(isbn);
        if (libro == null || libro.CantidadDisponible <= 0)
        {
            Console.WriteLine("Libro no disponible.");
            return;
        }

        DateTime fechaPrestamo = DateTime.Now;
        DateTime fechaDevolucion = fechaPrestamo.AddDays(14); // Prestamo por 14 días

        prestamos.Add(new Prestamo(usuario, libro, fechaPrestamo, fechaDevolucion, "Activo"));
        libro.CantidadDisponible--;
        Console.WriteLine("Préstamo registrado exitosamente.");
    }

    static void ListadoLibrosPrestados()//Muestra todos los préstamos asociados a un carné de usuario especificado, permitiendo visualizar detalles de cada préstamo.
    {
        Console.Write("Ingrese el carné del usuario: ");
        string carne = Console.ReadLine();
        var prestamosUsuario = prestamos.Where(p => p.Usuario.Carne == carne).ToList();

        if (prestamosUsuario.Count == 0)
        {
            Console.WriteLine("No se encontraron préstamos para este usuario.");
        }
        else
        {
            foreach (var prestamo in prestamosUsuario)
            {
                Console.WriteLine(prestamo);
            }
        }
    }

    static void ConsultarCatalogo()//Imprime detalles de cada libro disponible en el catálogo.
    {
        foreach (var libro in catalogo.ListaLibros)
        {
            Console.WriteLine(libro);
        }
    }

    static void ListadoUsuariosActivos()//Muestra información de todos los usuarios registrados en el sistema.
    {
        foreach (var usuario in usuarios)
        {
            Console.WriteLine(usuario);
        }
    }
}

//Documentación

//Descripción:Este componente controla la interacción del usuario con el sistema de gestión de la biblioteca a través de un menú de consola.

//Métodos:
//1) Main(string[] args): Punto de entrada del programa que maneja el menú principal y las acciones seleccionadas.
//2) IngresoDatos(): Gestiona el ingreso de datos para usuarios, libros y préstamos.
//3) MostrarDatos(): Muestra datos como listados de libros prestados, catálogo de libros y usuarios activos.
//4) RegistrarUsuario(), AgregarLibro(), RegistrarPrestamo(): Métodos para registrar usuarios, agregar libros y registrar préstamos.
//5) ListadoLibrosPrestados(), ConsultarCatalogo(), ListadoUsuariosActivos(): Métodos para mostrar información relevante.

//Entradas:Interacciones del usuario a través del menú de consola.
//Procesos:Navegación a través del menú, elección de opciones y ejecución de funciones relacionadas.
//Salidas:Visualización de datos y confirmaciones de acciones realizadas en la consola.