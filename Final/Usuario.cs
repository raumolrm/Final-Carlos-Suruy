namespace Final;
//La documentación está al final de cada clase

//Cada propiedad tiene un método get y un método set:
//get: Permite acceder al valor de la propiedad.
//set: Permite modificar el valor de la propiedad.

//Todas las propiedades son de tipo string, lo que significa que esperan almacenar cadenas de texto.
public class Usuario
{
    public string Nombre { get; set; }
    public string Apellidos { get; set; }
    public string Carne { get; set; }
    public string Telefono { get; set; }

    public Usuario(string nombre, string apellidos, string carne, string telefono)
    {
        Nombre = nombre;
        Apellidos = apellidos;
        Carne = carne;
        Telefono = telefono;
    }

//Al utilizar la palabra clave override, se indican quela clase Usuario proporcionará una implementación propia de este método, reemplazando la implementación por defecto.
//Además,se está utilizado una iterpolació de cadenas, signifca  que se puede colocar valores dentro de esa cadena
    public override string ToString()
    {
        return $"Nombre: {Nombre}, Apellidos: {Apellidos}, Carné: {Carne}, Teléfono: {Telefono}";
    }
}

//Documentación
//Descripción: Esta clase representa a un usuario de la biblioteca con sus datos personales.

//Atributos:
//Nombre: Nombre del usuario.
//Apellidos: Apellidos del usuario.
//Carne: Número de carné de identificación del usuario en la biblioteca.
//Telefono: Número de teléfono del usuario.

//Constructor:
//Usuario(string nombre, string apellidos, string carne, string telefono): Inicializa una nueva instancia de la clase Usuario con los datos proporcionados.

//Métodos:
//ToString(): Devuelve una representación en cadena de la información del usuario.

//Entradas: Datos personales del usuario al ser creado.
//Procesos:Almacenamiento de los datos del usuario.
//Salidas:Representación en cadena de la información del usuario para su visualización.
