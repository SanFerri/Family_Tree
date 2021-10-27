namespace Library
{
    public class PersonaVisitor : Visitor 
    {
        public override void Visit(Node node) 
        { 
            sumaEdades += node.Persona.edad; 
            foreach(Node children in node.Children)
            {
                if(children.Children.Count != 0)
                {
                    children.Accept(this);
                }
            }
        } 
    }    
}