using ChallengeIntuit.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeIntuit.Banco
{
    internal class DAL<T> where T : class
    {
        protected readonly ChallengeIntuitContext context;
        public DAL(ChallengeIntuitContext context)
        {
            this.context = context;
        }
        public  IEnumerable<T> Listar()
        {
            return context.Set<T>().ToList();
        }
        public void Adicionar(T objeto)
        {
            context.Set<T>().Add(objeto);
            context.SaveChanges();
        }
        public void Borrar(T objeto)
        {
            context.Set<T>().Remove(objeto);
            context.SaveChanges();
        }
        public void Actualizar(T objeto)
        {
            context.Set<T>().Update(objeto);
            context.SaveChanges();
        }
        public T? RecuperarPor(Func<T, bool> condicion)
        {
            return context.Set<T>().FirstOrDefault(condicion);
        }
    }
}
