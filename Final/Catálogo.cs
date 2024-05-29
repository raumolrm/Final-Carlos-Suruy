namespace Final;
//La documentación  general está al final de cada clase

//ListaLibros: Es una propiedad de tipo List<Libro>, que es una lista genérica de objetos Libro. Esta lista almacena todos los libros que forman parte del catálogo de la biblioteca.
public class Catalogo
{
    public List<Libro> ListaLibros = new List<Libro>();

//Este método toma un objeto Libro como parámetro y lo agrega a la lista ListaLibros. Utiliza el método Add de la lista, que es parte de la biblioteca estándar de colecciones de .NET.
    public void AgregarLibro(Libro libro)
    {
        ListaLibros.Add(libro);
    }

// Utiliza el método RemoveAll de la lista, que acepta un predicado (una función que devuelve un valor booleano) y elimina todos los elementos de la lista que cumplen con este.
    public void EliminarLibro(string isbn)
    {
        ListaLibros.RemoveAll(libro => libro.ISBN == isbn);
    }

//Utiliza el método Find de la lista, que busca el primer libro que cumpla con el criterio especificado por el predicado dado (en este caso, que el ISBN del libro sea igual al ISBN proporcionado).
    public Libro BuscarLibro(string isbn)
    {
        return ListaLibros.Find(libro => libro.ISBN == isbn);
    }
}

//Documentación - General
//Descripción:Esta clase representa el catálogo de libros de la biblioteca.

//Atributos:
//ListaLibros: Lista que almacena los objetos de la clase Libro.

//Métodos:
//AgregarLibro(Libro libro): Añade un libro al catálogo.
//EliminarLibro(string isbn): Elimina un libro del catálogo basándose en el ISBN.
//BuscarLibro(string isbn): Busca y retorna un libro en el catálogo basándose en el ISBN.

//Entradas:Libros al ser agregados o eliminados del catálogo.
//Procesos:Gestión de los libros dentro del catálogo.
//Salidas:Operaciones sobre el catálogo que afectan la disponibilidad de los libros.