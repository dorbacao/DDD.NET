using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fresenius.Exemplo.WebService.Response;
using Fresenius.Exemplo.WebService.Request;

namespace Fresenius.Exemplo.WebService.Services
{
    public class SomaService
    {
        public ResponseSoma Calcular(RequestSoma request)
        {
            ResponseSoma response = new ResponseSoma();

            response.Resultado = request.ValorUm + request.ValorDois;

            return response;
        }
    }
}
