using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades.Interfaces
{
    public interface IBaseRepositorio<TEntity> : IDisposable where TEntity : class
    {
        // CRUD

        // CREATE
        void Adicionar(TEntity entity);

        // READ
        TEntity ObeterPorId(int Id);
        IEnumerable<TEntity> ObterTodos();

        // UPDATE
        void Atualizar(TEntity entity);

        // DELETE
        void Deletar(TEntity entity);
    }
}
