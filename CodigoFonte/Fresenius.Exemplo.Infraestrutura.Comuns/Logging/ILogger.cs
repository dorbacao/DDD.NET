
namespace Fresenius.Exemplo.Infraestrutura.Comuns.Logging
{
    using System;

        /// <summary>
        /// Contrato padrão para abstração de componente de Log, ferramentas como log4net, .NET Diagnostics API, Elhma podem ser utilizados.
        /// <remarks>        
        /// </remarks>
        /// </summary>
    public interface ILogger
    {
        void Debug(string message, params object[] args);

        void Debug(string message,Exception exception,params object[] args);

        void Debug(object item);

        void Fatal(string message, params object[] args);

        void Fatal(string message, Exception exception,params object[] args);

        void LogInfo(string message, params object[] args);

        void LogWarning(string message, params object[] args);

        void LogError(string message, params object[] args);

        void LogError(string message, Exception exception, params object[] args);
    }
}
