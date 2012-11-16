
namespace Fresenius.Exemplo.Infraestrutura.Comuns.Validator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class DataAnnotationsEntityValidatorFactory
        :IEntityValidatorFactory
    {
        public IEntityValidator Create()
        {
            return new DataAnnotationsEntityValidator();
        }
    }
}
