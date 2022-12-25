namespace WebMarcosD.Models
{
    public class Cliente
    {
        private String identificacion;
        private String nombres;
        private String apellidos;
        private int edad;

        public Cliente()
        {
            
        }


        public Cliente(string identificacion, string nombres, string apellidos, int edad)
        {
            this.identificacion = identificacion;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.edad = edad;
        }

        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int Edad { get => edad; set => edad = value; }

        public String Identificacion { get => identificacion; set => identificacion = value; }



    }
}

