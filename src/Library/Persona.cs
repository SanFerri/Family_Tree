namespace Library
{
    public class Persona
    {
        public int edad{get;}
        public string nombre{get;}

        public Persona(int edad, string nombre)
        {
            this.edad = edad;
            this.nombre = nombre;
        }

        public void Accept(Visitor visitor) 
        { 
            visitor.Visit(this); 
        } 
    }
}