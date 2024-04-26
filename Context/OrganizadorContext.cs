using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using trilha_net_desafio_api_dio.Entities;

namespace trilha_net_desafio_api_dio.Context
{
    public class OrganizadorContext : DbContext
    {
        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options)
        {

        }
        public DbSet<Tarefa> Tarefas { get; set; }
    }
}