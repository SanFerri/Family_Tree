using System.Text;
namespace Library
{
    public abstract class Visitor 
    {     
        protected int sumaEdades { get; set; } = 0;
        public abstract void Visit(Persona persona); 
        public abstract void Visit(Node node);
    }    
}