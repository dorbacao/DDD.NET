using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoMapper;
using Fresenius.Exemplo.UI.Web.Tests.Stub;

namespace Fresenius.Exemplo.UI.Web.Tests
{
    [TestClass]
    public class AutomapperAdapter
    {
        public List<StubCliente> ListaCliente = new List<StubCliente>();



        [TestMethod]
        public void TesteAutoMapper()
        {
            
            Mapper.CreateMap<StubCliente, StubClienteModel>()
                .ForMember(model => model.NomeCliente, from => from.MapFrom(s => s.Nome));

            StubCliente cliente = new StubCliente() { Nome = "Marcus" };
            StubClienteModel model2 = Mapper.Map<StubClienteModel>(cliente);

            Assert.IsTrue(cliente.Nome == model2.NomeCliente);
        }
    }
}
