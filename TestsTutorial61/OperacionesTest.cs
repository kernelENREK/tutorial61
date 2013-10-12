using MiCalculadora;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestsTutorial61
{
    
    
    /// <summary>
    ///Se trata de una clase de prueba para OperacionesTest y se pretende que
    ///contenga todas las pruebas unitarias OperacionesTest.
    ///</summary>
    [TestClass()]
    public class OperacionesTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Obtiene o establece el contexto de la prueba que proporciona
        ///la información y funcionalidad para la ejecución de pruebas actual.
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

        #region Atributos de prueba adicionales
        // 
        //Puede utilizar los siguientes atributos adicionales mientras escribe sus pruebas:
        //
        //Use ClassInitialize para ejecutar código antes de ejecutar la primera prueba en la clase 
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup para ejecutar código después de haber ejecutado todas las pruebas en una clase
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize para ejecutar código antes de ejecutar cada prueba
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup para ejecutar código después de que se hayan ejecutado todas las pruebas
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Una prueba de Sumar
        ///</summary>
        [TestMethod()]
        public void SumarTest()
        {
            Operaciones target = new Operaciones(); 
            int num1 = 4; 
            int num2 = 1; 
            int expected = 5; 
            int actual;
            actual = target.Sumar(num1, num2);
            Assert.AreEqual(expected, actual);
            // Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SumarExcepcionElPrimerValorMayorQueIntMaxValue()
        {
            Operaciones target = new Operaciones();
            target.Sumar(int.MaxValue, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SumarExcepcionElSegundoValorMayorQueIntMaxValue()
        {
            Operaciones target = new Operaciones();
            target.Sumar(1, int.MaxValue);
        }
    
    }
}
