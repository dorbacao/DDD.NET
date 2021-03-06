﻿


namespace Fresenius.Exemplo.Infraestrutura.Comuns.Validator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Base contract for entity validator abstract factory
    /// </summary>
    public interface IEntityValidatorFactory
    {
        /// <summary>
        /// Create a new IEntityValidator
        /// </summary>
        /// <returns>IEntityValidator</returns>
        IEntityValidator Create();
    }
}
