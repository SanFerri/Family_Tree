namespace Library
{
    public class PersonaVisitor : Visitor 
    {
        public override void Visit(Node node) 
        { 
            foreach(Node children in node.Children)
            {
                children.Persona.Accept(this);
            }
        } 

        public override void Visit(Persona persona)
        {
            sumaEdades += persona.edad;
        }
    }    
}