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


        public Clientes(int clienteId, string nombres, string cedula, string email, string direccion, int telefono)
        {
            ClienteId = clienteId;
            Nombres = nombres;
            Cedula = cedula;
            Email = email;
            Direccion = direccion;
            Telefono = telefono;
        }


    }
}
