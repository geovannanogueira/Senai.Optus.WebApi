using Senai.Optus.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Optus.WebApi.Repositories
{
    public class EstiloRepository
    {
        public List<Estilos> Listar()
        {
            using (OptusContext ctx = new OptusContext())
            {
                return ctx.Estilos.ToList();
            }
        }

        public void Cadastrar (Estilos estilo)
        {
            using (OptusContext ctx = new OptusContext())
            {
                ctx.Estilos.Add(estilo);
                ctx.SaveChanges();
            }
        }

        public Estilos BuscarPorId(int id)
        {
            using (OptusContext ctx = new OptusContext())
            {
                return ctx.Estilos.FirstOrDefault(x => x.IdEstilo == id);
            }
        }

        public void Atualizar (Estilos estilo)
        {
            using (OptusContext ctx = new OptusContext())
            {
                Estilos EstilosBuscada = ctx.Estilos.First(x => x.IdEstilo == estilo.IdEstilo);
 
                EstilosBuscada.Nome = estilo.Nome;
                ctx.Estilos.Update(EstilosBuscada);
                ctx.SaveChanges();
            }
        }

        public void Deletar(int id)
        {
            using (OptusContext ctx = new OptusContext())
            {
                Estilos Estilo = ctx.Estilos.Find(id);
                ctx.Estilos.Remove(Estilo);
                ctx.SaveChanges();
            }
        }

    }
}
