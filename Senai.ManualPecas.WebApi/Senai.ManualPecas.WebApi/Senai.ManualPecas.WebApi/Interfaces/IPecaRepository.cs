using Senai.ManualPecas.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.ManualPecas.WebApi.Interfaces
{
    public interface IPecaRepository
    {
        List<Pecas> Listar();

        void Cadastrar(Pecas Peca);

        Pecas BuscarPorId(int id);
    }
}
