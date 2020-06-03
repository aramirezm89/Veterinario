namespace Veterinario
{
    public class lista
    {
        private string nombre;
        private string rut;
        private string direccion;
        private string email;
        private string fono;
        private string sexo;
        private string vacunas;
        private string color;
        private string nombreMascota;
        private string edad;


        public lista()
        {
            Nombre = string.Empty;
            Rut = string.Empty;
            Direccion = string.Empty;
            Email = string.Empty;
            Fono = string.Empty;
        }
        public lista(string nom, string ru, string direc, string em, string fon, string sex, string vac, string col, string nomMasc, string ed)
        {
            Nombre = nom;
            Rut = ru;
            Direccion = direc;
            Email = em;
            Fono = fon;
            sexo = sex;
            vacunas = vac;
            color = col;
            nombreMascota = nomMasc;
            Edad = ed;

        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Rut { get => rut; set => rut = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Email { get => email; set => email = value; }
        public string Fono { get => fono; set => fono = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Vacunas { get => vacunas; set => vacunas = value; }
        public string Color { get => color; set => color = value; }
        public string NombreMascota { get => nombreMascota; set => nombreMascota = value; }
        public string Edad { get => edad; set => edad = value; }
    }


}
