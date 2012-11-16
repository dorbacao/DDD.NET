using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Fresenius.Exemplo.Infraestrutura.Persistencia.Repository;

namespace Fresenius.Exemplo.UI.Web.Tests
{
    
    
    /// <summary>
    ///This is a test class for AlunoRepositoryTest and is intended
    ///to contain all AlunoRepositoryTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AlunoRepositoryTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for AlunoRepository Constructor
        ///</summary>
        [TestMethod()]
        public void AlunoRepositoryConstructorTest()
        {
            AlunoRepository target = new AlunoRepository();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
