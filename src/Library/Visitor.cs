using System.Text;
namespace Library
{
    public abstract class Visitor 
    {     
        public int MasLargo{get;set;} = 0;
        public Node HijoConNombreMasLargo{get;set;}
        public int MasGrande{get;set;} = 0;
        public Node HijoMasGrande{get;set;}
        public int sumaEdades { get; set; } = 0;
        public abstract void Visit(Node node);
    }    
}