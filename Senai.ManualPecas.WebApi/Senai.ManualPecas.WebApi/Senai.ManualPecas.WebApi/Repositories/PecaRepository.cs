using Senai.ManualPecas.WebApi.Domains;
using Senai.ManualPecas.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.ManualPecas.WebApi.Repositories
{
    public class PecaRepository : IPecaRepository
    {
        public Pecas BuscarPorId(int id)
        {
            using (ManualPecasContext ctx = new ManualPecasContext())
            {
                return ctx.Pecas.Find(id);
            }
        }

        public void Cadastrar(Pecas Peca)
        {
            using (ManualPecasContext ctx = new ManualPecasContext())
            {
                ctx.Pecas.Add(Peca);
                ctx.SaveChanges();
            }
        }

        public List<Pecas> Listar()
        {
            using (ManualPecasContext ctx = new ManualPecasContext())
            {
                return ctx.Pecas.ToList();
            }
        }
    }
}
