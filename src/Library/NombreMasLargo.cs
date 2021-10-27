namespace Library
{
    public class NombreMasLargoVisitor : Visitor 
    {
        public override void Visit(Node node) 
        { 
            if(node.Persona.nombre.Length > MasLargo)
            {
                this.MasLargo = node.Persona.nombre.Length;
                this.HijoConNombreMasLargo = node;
            }
            foreach(Node children in node.Children)
            {
                if(children.Persona.nombre.Length > MasLargo)
                {
                    this.MasLargo = children.Persona.edad;
                    this.HijoConNombreMasLargo = children;
                }
                children.Accept(this);
            }
        }
    }
}