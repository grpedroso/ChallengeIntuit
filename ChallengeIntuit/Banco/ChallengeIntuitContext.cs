using ChallengeIntuit.Modelos;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ChallengeIntuit.Banco
{
    internal class ChallengeIntuitContext : DbContext
    {
        public DbSet<Clientes> Clientes { get; set; }

        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog = ChallengeIntuit; Integrated Security = True; Encrypt=False;Trust Server Certificate=False;Application Intent = ReadWrite; Multi Subnet Failover=False";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }        

    }
}
