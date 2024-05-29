namespace Final;
//La documentación está al final de cada clase
public class Prestamo
{
    public Usuario Usuario { get; set; }
    public Libro Libro { get; set; }
    public DateTime FechaPrestamo { get; set; }
    public DateTime FechaDevolucion { get; set; }
    public string EstadoPrestamo { get; set; }

    public Prestamo(Usuario usuario, Libro libro, DateTime fechaPrestamo, DateTime fechaDevolucion, string estadoPrestamo)
    {
        Usuario = usuario;
        Libro = libro;
        FechaPrestamo = fechaPrestamo;
        FechaDevolucion = fechaDevolucion;
        EstadoPrestamo = estadoPrestamo;
    }
//Facilita la visualización de los detalles del préstamo, como quién tiene el libro, qué libro es, las fechas clave y el estado del préstamo.
    public override string ToString()
    {
        return $"Usuario: {Usuario.Nombre}, Libro: {Libro.Titulo}, Fecha de Préstamo: {FechaPrestamo.ToShortDateString()}, Fecha de Devolución: {FechaDevolucion.ToShortDateString()}, Estado: {EstadoPrestamo}";
    }
}

//Documentación

//Descripción: Esta clase representa un préstamo de un libro a un usuario.

//Atributos:
//Usuario: Usuario que realiza el préstamo.
//Libro: Libro que es prestado.
//FechaPrestamo: Fecha en la que se realiza el préstamo.
//FechaDevolucion: Fecha estimada para la devolución del libro.
//EstadoPrestamo: Estado actual del préstamo (activo, finalizado, etc.).

//Constructor:
//Prestamo(Usuario usuario, Libro libro, DateTime fechaPrestamo, DateTime fechaDevolucion, string estadoPrestamo): Inicializa una nueva instancia de la clase Prestamo con los datos proporcionados.

//Métodos:
//ToString(): Devuelve una representación en cadena de la información del préstamo.

//Entradas:Datos del préstamo al ser creado.
//Procesos:Almacenamiento y gestión de los datos del préstamo.
//Salidas:Representación en cadena de la información del préstamo para su visualización.