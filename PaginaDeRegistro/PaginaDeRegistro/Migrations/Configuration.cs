namespace PaginaDeRegistro.Migrations
{
    using PaginaDeRegistro.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PaginaDeRegistroContext>
    {

        bool Recuerdam = Recuerdame == "1";
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PaginaDeRegistroContext context)
        {
            context.Usuarios.AddOrUpdate(
                p => p.NombreUsuario,
                new Usuario
                {
                    NombreUsuario = "Asa",
                    Contraseña = "123",
                    Nombre = "Assael",
                    Apellido = "Gonzalez",
                    Genero = "Hombre",
                    Recuerdame = true,


                });
            context.Intereses.AddOrUpdate(
                p => p.Id,
                new Intereses { Nombre = "Juegos" },
                new Intereses { Nombre = "Morras" },
                new Intereses { Nombre = "Libros" },
                new Intereses { Nombre = "Programar" },
                new Intereses { Nombre = "Cochar" }
                );
            
        }
    }
}
