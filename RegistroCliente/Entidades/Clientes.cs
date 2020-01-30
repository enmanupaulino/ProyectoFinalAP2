using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroCliente.Entidades
{
    public class Clientes
    {
       

        [Key]
        public int ClienteId { get; set; }
        public  string Nombres { get; set; }
        public string Cedula { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }


        public Clientes()
        {
            ClienteId = 0;
            Nombres = string.Empty;
            Cedula = string.Empty;
            Email = string.Empty;
            Direccion = string.Empty;
            Telefono = 0;
        }


    }
}
