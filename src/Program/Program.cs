using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona(89, "Alberto");
            Persona persona2 = new Persona(77, "Romina");
            Persona persona3 = new Persona(64, "Romina");
            Persona persona4 = new Persona(53, "Romina");
            Persona persona5 = new Persona(42, "Romina");
            Persona persona6 = new Persona(34, "Romina");
            Persona persona7 = new Persona(19, "Romina");
            Persona persona8 = new Persona(2, "Romina");

            Node n1 = new Node(persona1);
            Node n2 = new Node(persona2);
            Node n3 = new Node(persona3);
            Node n4 = new Node(persona4);
            Node n5 = new Node(persona5);
            Node n6 = new Node(persona6);
            Node n7 = new Node(persona7);
            Node n8 = new Node(persona8);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);
            n3.AddChildren(n8);

            // Y con estos metodos hay errores que no llegue a solucionar.
            n3.NombreMasLargo();
            n3.MasGrande();

            // Aqui me sale stack overflow.
            n3.GetSumaEdades();
        }
    }
}
