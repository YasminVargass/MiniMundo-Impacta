﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MiniMundo.Models;

namespace MiniMundo.Data
{
    public class MiniMundoContext : DbContext
    {
        public MiniMundoContext (DbContextOptions<MiniMundoContext> options)
            : base(options)
        {
        }

        public DbSet<MiniMundo.Models.Funcionario> Funcionario { get; set; } = default!;
        public DbSet<MiniMundo.Models.Produto> Produto { get; set; } = default!;
        public DbSet<MiniMundo.Models.Categoria> Categoria { get; set; } = default!;
        public DbSet<MiniMundo.Models.Fornecedor> Fornecedor { get; set; } = default!;
        public DbSet<MiniMundo.Models.NivelAcesso> NivelAcesso { get; set; } = default!;
        public DbSet<MiniMundo.Models.Venda> Venda { get; set; } = default!;
        public DbSet<MiniMundo.Models.Cliente> Cliente { get; set; } = default!;
    }
}
