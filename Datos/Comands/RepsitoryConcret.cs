﻿using Dominio.Comands;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Datos.Comands
{
    //    public class RepsitoryConcret<T> : IRepositorio<T> where T : Entidad, new()
    //    {
    //        public interface IRepositorio<T>
    //        {
    //            void Agregar(T entidad);
    //            void Eliminar(int id);
    //            void Actualizar(T entidad);
    //            int Contar(Expression<Func<T, bool>> where);
    //            Entidad ObtenerPorId(int id);
    //            IEnumerable<T> EncontrarPor(ParametrosDeQuery<T> parametrosDeQuery);
    //        }
    //        public void Actualizar(T entidad)
    //        {
    //            using (var db = new EmpresaContext())
    //            {
    //                db.Entry(entidad).State = EntityState.Modified;
    //                db.SaveChanges();
    //            }
    //        }

    //        public List<T> TraerIncertadosHoy()
    //        {
    //            using (var db = new EmpresaContext())
    //            {
    //                return db.Set<T>().Where(x => x.FechaIncercion == DateTime.Today).ToList();
    //            }
    //        }
    //        public List<T> TraerSegunParametros(ParametrosDeQuery<T> parametrosDeQuery)
    //        {
    //            var orderByClass = ObtenerOrderBy(parametrosDeQuery);
    //            Expression<Func<T, bool>> whereTrue = x => true;
    //            var where = (parametrosDeQuery.Where == null) ? whereTrue : parametrosDeQuery.Where;
    //            using (var db = new EmpresaContext())
    //            {

    //                return db.Set<T>().Where(where).OrderByDescending(orderByClass.OrderBy).ToList();
    //            }
    //        }
    //        public IEnumerable<T> EncontrarPor(ParametrosDeQuery<T> parametrosDeQuery)
    //        {
    //            var orderByClass = ObtenerOrderBy(parametrosDeQuery);
    //            Expression<Func<T, bool>> whereTrue = x => true;
    //            var where = (parametrosDeQuery.Where == null) ? whereTrue : parametrosDeQuery.Where;
    //            using (EmpresaContext db = new EmpresaContext())
    //            {
    //                if (orderByClass.IsAscending)
    //                {
    //                    return db.Set<T>().Where(where).OrderBy(orderByClass.OrderBy)
    //                    .Skip((parametrosDeQuery.Pagina - 1) * parametrosDeQuery.Top)
    //                    .Take(parametrosDeQuery.Top).ToList();
    //                }
    //                else
    //                {
    //                    return db.Set<T>().Where(where).OrderByDescending(orderByClass.OrderBy)
    //                    .Skip((parametrosDeQuery.Pagina - 1) * parametrosDeQuery.Top)
    //                    .Take(parametrosDeQuery.Top).ToList();
    //                }

    //            }
    //        }
    //        public Entidad ObtenerPorId(int id)
    //        {
    //            using (var db = new EmpresaContext())
    //            {
    //                return db.Set<T>().FirstOrDefault(x => x.Id == id);
    //            }
    //        }
    //        public void Agregar(T entidad)
    //        {
    //            using (var db = new EmpresaContext())
    //            {
    //                entidad.FechaIncercion = DateTime.Today;
    //                db.Entry(entidad).State = EntityState.Added;
    //                db.SaveChanges();
    //            }
    //        }

    //        public void Eliminar(int id)
    //        {
    //            using (var db = new EmpresaContext())
    //            {
    //                var entidad = new T() { Id = id };
    //                db.Entry(entidad).State = EntityState.Deleted;
    //                db.SaveChanges();
    //            }
    //        }



    //        private OrderByClass ObtenerOrderBy(ParametrosDeQuery<T> parametrosDeQuery)
    //        {
    //            if (parametrosDeQuery.OrderBy == null && parametrosDeQuery.OrderByDescending == null)
    //            {
    //                return new OrderByClass(x => x.Id, true);
    //            }

    //            return (parametrosDeQuery.OrderBy != null)
    //                ? new OrderByClass(parametrosDeQuery.OrderBy, true) :
    //                new OrderByClass(parametrosDeQuery.OrderByDescending, false);
    //        }
    //        public List<T> OptenerTodos()
    //        {
    //            using (var db = new EmpresaContext())
    //            {
    //                return db.Set<T>().ToList();
    //            }
    //        }



    //        public int Contar(Expression<Func<T, bool>> where)
    //        {
    //            using (var db = new EmpresaContext())
    //            {
    //                return db.Set<T>().Where(where).Count();
    //            }
    //        }

    //        private class OrderByClass
    //        {

    //            public OrderByClass()
    //            {

    //            }

    //            public OrderByClass(Func<T, object> orderBy, bool isAscending)
    //            {
    //                OrderBy = orderBy;
    //                IsAscending = isAscending;
    //            }


    //            public Func<T, object> OrderBy { get; set; }
    //            public bool IsAscending { get; set; }
    //        }
    //    }
}
