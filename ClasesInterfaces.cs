using System;
using System.Collections;

public interface Comparable
{
    Boolean sosIgual(Comparable C);
    Boolean sosMayor(Comparable c);
    Boolean sosMenor(Comparable c);
}

public interface Coleccionable
{
    int cuantos();
    Comparable minimo();
    Comparable maximo();
    void agregar(Comparable c);
    bool contiene(Comparable c);

}

public class Numero : Comparable
{
    int valor;
    public Numero(int v)
    {
        valor = v;
    }
    public int getValor()
    {
        return valor;
    }
    public Boolean sosIgual(Comparable c)
    {
        return this.getValor() == ((Numero)c).getValor();
    }
    public Boolean sosMayor(Comparable c)
    {
        Numero n = (Numero)c;
        return this.getValor() > n.getValor();
    }
    public Boolean sosMenor(Comparable c)
    {
        return this.getValor() < ((Numero)c).getValor();
    }
}

public class Pila : Coleccionable
{
    List<Comparable> elementos = new List<Comparable>();
    //public void push(){    }
    public void pop()
    {
        elementos.RemoveAt(-1);
    }
    public int cuantos()
    {
        return elementos.Count;
    }
    public void agregar(Comparable c)
    {
        elementos.Add(c);
    }
    public bool contiene(Comparable c)
    {
        foreach (Comparable e in elementos)
        {
            if (e.sosIgual(c))
                return true;
        }
        return false;
    }
    public Comparable minimo()
    {
        Comparable min = elementos[0];
        foreach (Comparable e in elementos)
        {
            if (e.sosMenor(min))
                min = e;
        }
        return min;
    }
    public Comparable maximo()
    {
        Comparable max = elementos[0];
        foreach (Comparable e in elementos)
        {
            if (e.sosMayor(max))
                max = e;
        }
        return max;
    }
}

public class Cola : Coleccionable
{
    List<Comparable> elementos = new List<Comparable>();
    public void push(Coleccionable c)
    {

    }
    public void pop()
    {
        elementos.RemoveAt(0);
    }
    public int cuantos()
    {
        return elementos.Count;
    }
    public void agregar(Comparable c)
    {
        elementos.Add(c);
    }
    public bool contiene(Comparable c)
    {
        foreach (Comparable e in elementos)
        {
            if (e.sosIgual(c))
                return true;
        }
        return false;
    }
    public Comparable minimo()
    {
        Comparable min = elementos[0];
        foreach (Comparable e in elementos)
        {
            if (e.sosMenor(min))
                min = e;
        }
        return min;
    }
    public Comparable maximo()
    {
        Comparable max = elementos[0];
        foreach (Comparable e in elementos)
        {
            if (e.sosMayor(max))
                max = e;
        }
        return max;
    }
}

public class coleccionMultiple : Coleccionable
{
    Coleccionable pila;
    Coleccionable cola;
    public coleccionMultiple(Coleccionable p, Coleccionable c)
    {
        pila = p;
        cola = c;
    }

    public void agregar(Comparable c)
    { }

    public bool contiene(Comparable c)
    {
        if (pila.contiene(c) || cola.contiene(c))
            return true;
        return false;
    }

    public int cuantos() //Esta mal=======================================
    {
        int p = pila.cuantos();
        int c = cola.cuantos();

        return p & c;
    }

    public Comparable maximo()
    {
        Comparable maxpila = pila.maximo();
        Comparable maxcola = cola.maximo();

        if (maxpila.sosMayor(maxcola))
            return maxpila;
        return maxcola;
    }

    public Comparable minimo()
    {
        Comparable minpila = pila.minimo();
        Comparable mincola = cola.minimo();

        if (minpila.sosMenor(mincola))
            return minpila;
        return mincola;
    }
}
public class Persona : Comparable{
    string nombre;
    int dni;
    public Persona(string nom, int d){
        nombre = nom;
        dni = d;
    }
    public string getNombre(){
        return nombre;
    }
    public int getDNI(){
        return dni;
    }

    public bool sosIgual(Comparable c)
    {
        return this.getDNI() == ((Persona) c).getDNI();
    }

    public bool sosMayor(Comparable c)
    {
        return this.getDNI() > ((Persona) c).getDNI();
    }

    public bool sosMenor(Comparable c)
    {
        return this.getDNI() < ((Persona) c).getDNI();
    }
}

public class Alumno : Persona{
    int legajo;
    int promedio;

    public Alumno(string n, int d, int l, int p) : base(n, d){
        legajo = l;
        promedio = p;
    }
    public int getLegajo(){
        return legajo;
    }
    public int getPromedio(){
        return promedio;
    }
}


