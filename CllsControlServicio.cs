namespace Veterinario
{
    public class CllsControlServicio
    {

        private string nombre;
        private string nombreMascota;
        private string detalle;
        private string servicio;
        private string vacuna;
        private string fecha;
        private string pago;



        public CllsControlServicio()
        {
            Nombre = string.Empty;
            NombreMascota = string.Empty;
            Detalle = string.Empty;
            Servicio = string.Empty;
            Vacuna = string.Empty;
            Fecha = string.Empty;
            Pago = string.Empty;

        }

        public CllsControlServicio(string nom, string masc, string det, string serv, string vac, string fec, string pag)
        {
            Nombre = nom;
            NombreMascota = masc;
            Detalle = det;
            Servicio = serv;
            vacuna = vac;
            fecha = fec;
            pago = pag;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string NombreMascota { get => nombreMascota; set => nombreMascota = value; }
        public string Detalle { get => detalle; set => detalle = value; }
        public string Servicio { get => servicio; set => servicio = value; }
        public string Vacuna { get => vacuna; set => vacuna = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Pago { get => pago; set => pago = value; }
    }



}
