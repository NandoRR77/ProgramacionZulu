using ConceptsPOO;

Console.WriteLine("____________");
Console.WriteLine("Concepts POO");

try // vamos a validar la excepciòn del mes invalido y a capturarla, en el try intenta imprimir las fechas
{
    Console.WriteLine(new Date(2024, 2, 29));
    Console.WriteLine(new Date(1974, 9, 23));
    Console.WriteLine(new Date(1985, 11, 30));
}
catch (Exception error) // capturamos la excepcion y almacenamos en la variable error
{
    Console.WriteLine(error.Message);
}