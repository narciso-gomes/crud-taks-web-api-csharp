﻿using System;
using Microsoft.EntityFrameworkCore;
using SistemasDeTarefas.Models;

namespace SistemaDeTarefas.Data
{
	public class SistemaDeTarefasDBContext : DbContext
	{
		public SistemaDeTarefasDBContext(DbContextOptions<SistemaDeTarefasDBContext> options) : base(options){}

		public DbSet<UsuarioModel> Usuarios { get; set; }

		public DbSet<TarefaModel> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

