using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using Fresenius.Exemplo.Dominio.Entity;
using Fresenius.Exemplo.Infraestrutura.Persistencia.Repository;

namespace Fresenius.Exemplo.Dominio.BindContext
{
    public static class Container
    {
        static IUnityContainer _currentContainer;

        public static IUnityContainer Current
        {
            get
            {
                return _currentContainer;
            }
        }

        static Container()
        {
            _currentContainer.RegisterType<IAlunoRepository, AlunoRepository>();
            _currentContainer.RegisterType<IEscolaRepository, EscolaRepository>();
            
        }
    }
}
