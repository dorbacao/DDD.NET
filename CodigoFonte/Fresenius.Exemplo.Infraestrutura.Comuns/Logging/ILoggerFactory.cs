

namespace Fresenius.Exemplo.Infraestrutura.Comuns.Logging
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Contrato base para a fábrica de Loggers
    /// </summary>
    public interface ILoggerFactory
    {
        ILogger Create();
    }
}
