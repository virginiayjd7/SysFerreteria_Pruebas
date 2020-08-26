using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyecttoSysFerreteria.Entidad;
using System.Collections.Generic;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalcularTotalPorIngresoDeProducto()
        {

            EDetalleVenta detalleProducto = new EDetalleVenta();
            List<EDetalleVenta> listaDetalleProducto = new List<EDetalleVenta>();
            EVenta lineaDeVenta = new EVenta();

            detalleProducto.Precio = 20;
            detalleProducto.Cantidad = 5;
            double valorEsperado = 100;
            listaDetalleProducto.Add(detalleProducto);
            lineaDeVenta.ListaDetalleProducto = listaDetalleProducto;

            double total = lineaDeVenta.CalcularTotalPorIngresoDeProducto();

            Assert.AreEqual(valorEsperado, total);


        }
    }
}

