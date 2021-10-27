using System.Text;
namespace Library
{
    public abstract class Visitor 
    {     
        public int sumaEdades { get; set; } = 0;
        public abstract void Visit(Node node);
    }    
}