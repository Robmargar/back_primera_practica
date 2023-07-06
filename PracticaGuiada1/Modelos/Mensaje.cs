namespace PracticaGuiada1.Modelos
{
    public class Mensaje
    {
        public string Nombre { get;set; }
        public int Edad { ger; set; }

        public Mensaje(string NombreIn, int EdadIn)
        {
            Nombre = NombreIn;
            Edad= EdadIn;
        }

    }

    public class Persona
    {
        public string Nombre { get; set;}
        public int Edad { get; set;}
        public string Direccion { get; set; }
    }

    public class PersonaPuesto:Persona
    {
        public double Sueldo { get;set; }
        public int PersonaId { get; set;}   
    }
}
