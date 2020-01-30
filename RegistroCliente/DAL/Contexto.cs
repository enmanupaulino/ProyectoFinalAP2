using Microsoft.EntityFrameworkCore;
using RegistroCliente.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RegistroCliente.DAL
{
    public class Contexto :DbContext
    {
        public DbSet<Clientes>clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server =.\SqlExpress; Database=ProyectoFinalAP2Db; Trusted_Connection = true;");
        }


    }
}
