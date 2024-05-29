namespace Final;
//La documentación está al final de cada clase

//Estas propiedades están definidas con { get; set; }, lo que significa que cada propiedad es accesible y modificable desde fuera de la clase. Esto permite leer y cambiar los valores después de que el objeto ha sido inicializado.
public class Libro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string ISBN { get; set; }
    public int AnoPublicacion { get; set; }
    public int CantidadDisponible { get; set; }

    public Libro(string titulo, string autor, string isbn, int anoPublicacion, int cantidadDisponible)
    {
        Titulo = titulo;
        Autor = autor;
        ISBN = isbn;
        AnoPublicacion = anoPublicacion;
        CantidadDisponible = cantidadDisponible;
    }
//El método proporciona una implementación personalizada que se utiliza para obtener una representación en cadena del objeto Libro.
    public override string ToString()
    {
        return $"Título: {Titulo}, Autor: {Autor}, ISBN: {ISBN}, Año de Publicación: {AnoPublicacion}, Cantidad Disponible: {CantidadDisponible}";
    }
}

//Documetación

//Descripción: Esta clase representa a un libro dentro del catálogo de la biblioteca.

//Atributos:
//Titulo: Título del libro.
//Autor: Autor del libro.
//ISBN: Número de identificación estándar internacional del libro.
//AnoPublicacion: Año de publicación del libro.
//CantidadDisponible: Cantidad disponible del libro para ser prestado.

//Constructor:
//Libro(string titulo, string autor, string isbn, int anoPublicacion, int cantidadDisponible): Inicializa una nueva instancia de la clase Libro con los datos proporcionados.

//Métodos:
//ToString(): Devuelve una representación en cadena de la información del libro.

//Entradas: Datos del libro al ser creado.
//Procesos:Almacenamiento de los datos del libro.
//Salidas:Representación en cadena de la información del libro para su visualización.