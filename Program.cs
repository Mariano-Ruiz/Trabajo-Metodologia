using System;

namespace Metodologia;
class Program
{
    static void Main(string[] args)
    {
        
        Coleccionable c = new Cola();
        Coleccionable p = new Pila();
        Coleccionable multiple = new coleccionMultiple(c, p);
        // llenar(c);
        // llenar(p);
        // llenarPersonas(c);
        // llenarPersonas(p);
        // llenarAlumnos(c);
        // llenarAlumnos(p);

        // informar(c);
        // informar(p);
        // informar(multiple);

        // Console.WriteLine(cuantos());
        //coleccionMultiple u = new coleccionMultiple(p, c);
        
    }


    public static void llenar(Coleccionable c){
        Random random = new Random();
        for (int i = 0; i < 20; i++)
        {
            Comparable elemento = new Numero(random.Next(100));
            c.agregar(elemento);
        }
    }
    
    public static void informar(Coleccionable c){
        Console.WriteLine("La cantidad de elementos es: {0}", c.cuantos());
        Console.WriteLine("El elemento minimo es: {0}", ((Numero) c.minimo()).getValor());
        Console.WriteLine("El elemento maximo es: {0}", ((Numero)c.maximo()).getValor());
        Console.WriteLine("Ingrese un numero a buscar: ");
        Comparable c2 = new Numero(int.Parse(Console.ReadLine()));
        if(c.contiene(c2))
            Console.WriteLine("Está");
        else
            Console.WriteLine("No está");
    }

    public static void llenarPersonas(Coleccionable c){
        Random random = new Random();
        string[] nombres = {"mariano", "laura", "maria", "cristina", "agustina", "ivan", "dario", "marcelo"};
        for (int i = 0; i < 20; i++)
        {
            Comparable persona = new Persona(nombres[random.Next(nombres.Length)], random.Next(30000000, 50000000));
            c.agregar(persona);
        }
    }

    public static void llenarAlumnos(Coleccionable c){
        Random random = new Random();
        string[] nombres = {"mariano", "laura", "maria", "cristina", "agustina", "ivan", "dario", "marcelo"};
        for (int i = 0; i < 20; i++){
            Comparable Alumno = new Alumno(nombres[random.Next(nombres.Length)], random.Next(30000000, 50000000), random.Next(99999), random.Next(0, 10));
            c.agregar(Alumno);
        }
    }
}

