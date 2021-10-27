namespace Library
{
    public class MayorVisitor : Visitor 
    {
        public override void Visit(Node node) 
        { 
            if(node.Persona.edad > MasGrande)
            {
                this.MasGrande = node.Persona.edad;
                this.HijoMasGrande = node;
            }
            foreach(Node children in node.Children)
            {
                if(children.Persona.edad > MasGrande)
                {
                    this.MasGrande = children.Persona.edad;
                    this.HijoMasGrande = children;
                }
                children.Accept(this);
            }
        }
    
    }
}