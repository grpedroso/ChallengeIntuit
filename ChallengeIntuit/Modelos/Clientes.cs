using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeIntuit.Modelos
{
    internal class Clientes
    {
        public string Nombre {  get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Cuit { get; set; }
        public string Domicilio { get; set; }
        public string TelefonoCelular { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }

        public Clientes(string nombre, string apellidos, DateTime fechaNacimiento, string cuit, string domicilio, string telefonoCelular, string email, int id)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            FechaNacimiento = fechaNacimiento;
            Cuit = cuit;
            Domicilio = domicilio;
            TelefonoCelular = telefonoCelular;
            Email = email;
            Id = id;
        }
        public override string ToString()
        {
            return $@"Id: {Id}
                      Nombre: {Nombre}
                      Apellidos: {Apellidos}
                      Fecha de nacimiento: {FechaNacimiento.Date}
                      CUIT: {Cuit} 
                      Domicilio: {Domicilio}  
                      Telefono: {TelefonoCelular}  
                      Email: {Email}";
        }

    }
}
