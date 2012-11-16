

using Fresenius.Exemplo.Infraestrutura.Comuns.Logging;
namespace Fresenius.Exemplo.Infraestrutura.Comuns.Logging
{
    /// <summary>
    /// Fábrica concreta para construção de logs
    /// </summary>
    public static class LoggerFactory
    {
        #region Members

        static ILoggerFactory _currentLogFactory = null;

        #endregion

        #region Public Methods

        public static void SetCurrent(ILoggerFactory logFactory)
        {
            _currentLogFactory = logFactory;
        }

        public static ILogger CreateLog()
        {
            return (_currentLogFactory != null) ? _currentLogFactory.Create() : null;
        }

        #endregion
    }
}
