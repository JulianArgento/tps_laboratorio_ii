using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logica;
using System;

namespace TestsUnitariosCliente
{
    [TestClass]
    public class RegistroClientesTests
    {
        [TestMethod]
        public void RegistroClientes_NoAgregaUnClienteNull()
        {
            //Arrange 
            RegistroClientes lista = new RegistroClientes();
            Cliente cliente = null;

            
            

            //Assert
            Assert.ThrowsException<ValorInvalidoFueraDeRango>(()=> lista += cliente);
        }

        [TestMethod]
        public void RegistroClientes_NoAgregaClientesRepetidos()
        {
            //Arrange
            RegistroClientes lista = new RegistroClientes();
            Butaca asiento = new Butaca("8F", true);
            Cliente cliente1 = new Cliente("Julian", 445021621, asiento);
            Cliente cliente2 = new Cliente("Julian", 445021621, asiento);

            //Act
            lista += cliente1;

            //Assert
            Assert.ThrowsException<ValorInvalidoFueraDeRango>(() => lista += cliente2);


        }

        [TestMethod]
        public void RegistroClientes_NoBorraClientesQueNoFueronAgregados()
        {
            //Arrange
            RegistroClientes lista = new RegistroClientes();
            Butaca asiento = new Butaca("8F", true);
            Butaca asiento2 = new Butaca("8H", true);
            Cliente cliente1 = new Cliente("Julian", 445021621, asiento);
            Cliente cliente2 = new Cliente("Carolina", 33324123, asiento);

            //Act
            lista += cliente1;

            //Assert
            Assert.ThrowsException<ValorInvalidoFueraDeRango>(() => lista -= cliente2);


        }

        


    }
}
