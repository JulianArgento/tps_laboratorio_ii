using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logica;
using System;

namespace TestsUnitariosCliente
{
    [TestClass]
    public class ClientesTests
    {
        [TestMethod]
        public void Clientes_NoSeAgregaUnaButacaRepetida()
        {
            //Arrange 
            Butaca asiento = new Butaca("3T", true);
            Cliente julian = new Cliente("Julian", 66666);

            julian += asiento;

            //Assert
            Assert.ThrowsException<ValorInvalidoFueraDeRango>(() => julian += asiento);
        }

        [TestMethod]
        public void Clientes_NoSeAgregaUnaButacaNull()
        {
            //Arrange 
            Butaca asiento = null;
            Cliente julian = new Cliente("Julian", 66666);

            

            //Assert
            Assert.ThrowsException<ValorInvalidoFueraDeRango>(() => julian += asiento);
        }


    }
}
