using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        private Persona persona;

        private List<Node> children = new List<Node>();

        public Persona Persona {
            get
            {
                return this.Persona;
            }
        }

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(Persona persona)
        {
            this.persona = persona;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }

        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }

        public void NombreMasLargo()
        {
            Visitor visitor = new NombreMasLargoVisitor();
            this.Accept(visitor);
            Console.WriteLine($"{visitor.MasLargo} {visitor.HijoConNombreMasLargo}");
        }
        public void MasGrande()
        {
            Visitor visitor = new MayorVisitor();
            this.Accept(visitor);
            Console.WriteLine($"{visitor.MasGrande} {visitor.HijoMasGrande}");
        }
        public int GetSumaEdades()
        {
            Visitor visitor = new PersonaVisitor(); 
            this.Accept(visitor); 
            return visitor.sumaEdades; 
        }
    }
}
