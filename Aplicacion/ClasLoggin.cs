using Dominio.Comands;
using Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Aplicacion
{
    
   public class ClasLoggin
    {
        IRepositorio<Usuarios> RepUsuario ;
        ParametrosDeQuery<Usuarios> ParametrosUsuario;

        public ClasLoggin(IRepositorio<Usuarios> repUsuario, ParametrosDeQuery<Usuarios> parametrosUsuario)
        {
            RepUsuario = new RepsitoryConcret<Usuarios>();
            ParametrosUsuario = parametrosUsuario;
        }

        public Usuarios AutentificarUsuario(string User,string password)
        {
            ParametrosUsuario.Where = (x => x.Nombre == User && x.Contraseña == password);
            return RepUsuario.EncontrarPor(ParametrosUsuario).FirstOrDefault<Usuarios>();
        }
    }
}
