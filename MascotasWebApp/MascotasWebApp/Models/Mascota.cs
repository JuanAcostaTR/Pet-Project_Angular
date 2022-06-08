using System;

namespace MascotasWebApp.Models
{
    public class Mascota
    {
        public Mascota() { }

        public Mascota(int id, string nombre, DateTime fechaNacimiento, string observaciones, bool soporteEmocional, bool lazarillo, bool activo, int idTipo) {
            ID = id;
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            Observaciones = observaciones;
            SoporteEmocional = soporteEmocional;
            Lazarillo = lazarillo;
            Activo = activo;
            IDTipo = idTipo;


        }

        public Mascota(string nombre, DateTime fechaNacimiento, string observaciones, bool soporteEmocional, bool lazarillo, bool activo, int idTipo)
        {
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            Observaciones = observaciones;
            SoporteEmocional = soporteEmocional;
            Lazarillo = lazarillo;
            Activo = activo;
            IDTipo = idTipo;
        }
        public Mascota(int id,bool activo)
        {
            ID = id;
            Activo = activo;
        }

        public int ID { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Observaciones { get; set; }
        public bool SoporteEmocional { get; set; }
        public bool Lazarillo { get; set; }
        public bool Activo { get; set; }
        public int IDTipo { get; set; }
    }                                  
}