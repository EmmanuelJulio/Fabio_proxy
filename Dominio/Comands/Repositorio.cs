using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;


namespace Dominio.Comands
{
    public class ParametrosDeQuery<T>
    {
        public ParametrosDeQuery()
        {
            Where = null;
            OrderBy = null;
            OrderByDescending = null;
        }

        public ParametrosDeQuery(int pagina, int top)
        {
            Pagina = pagina;
            Top = top;
            Where = null;
            OrderBy = null;
            OrderByDescending = null;
        }
        public int Pagina { get; set; }
        public int Top { get; set; }
        public Expression<Func<T, bool>> Where { get; set; }
        public Func<T, object> OrderBy { get; set; }
        public Func<T, object> OrderByDescending { get; set; }
    }

    public interface IRepositorio<T>
    {
        void Agregar(T entidad);
        void Eliminar(int id);
        void Actualizar(T entidad);
        int Contar(Expression<Func<T, bool>> where);
        Entidad ObtenerPorId(int id);
        IEnumerable<T> EncontrarPor(ParametrosDeQuery<T> parametrosDeQuery);
    }
    
}
