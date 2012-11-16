


namespace Fresenius.Exemplo.Infraestrutura.Comuns.Validator
{
    using System;
    using System.Collections.Generic;

    public interface IEntityValidator
    {
        bool IsValid<TEntity>(TEntity item)
            where TEntity : class;

        IEnumerable<String> GetInvalidMessages<TEntity>(TEntity item)
            where TEntity : class;
    }
}
