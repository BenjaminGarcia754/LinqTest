using LinqConexion;

/*
    int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 7, 10 };
    Console.WriteLine("A continuacion te mostramos los numeros pares que existen en el arreglo");
    Sin LINQ
    list<int> numeropares = new list<int>();
    foreach (int numero in numeros)
    {
        if (numero % 2 == 0)
            numeropares.add(numero);
    }
*/


//Con LINQ

//IEnumerable<int> numerosPares = from numero in numeros where numero % 2 == 0 select numero;

//Impresion numeros pares
/*
    foreach (int numero in numerosPares)
    {
        Console.WriteLine(numero);
    }
*/

//Ejemplo control alumno Objetos

ControlAlumnos controlAlumnos  = new ControlAlumnos();
controlAlumnos.ObtenerAlumnosPorCarrera(2);
controlAlumnos.ObtenerAlumnosPorCarreraJoin(2);