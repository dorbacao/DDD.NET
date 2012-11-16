

namespace Fresenius.Exemplo.Infraestrutura.Comuns.Logging
{
    public class TraceSourceLogFactory
        :ILoggerFactory
    {
        public ILogger Create()
        {
            return new TraceSourceLog();
        }
    }
}
