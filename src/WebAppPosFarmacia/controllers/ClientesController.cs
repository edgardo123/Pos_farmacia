using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppPosFarmacia.models;
using WebAppPosFarmacia.viewmodels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppPosFarmacia.controllers
{
    public class ClientesController: Controller
    {
        //objetos de solo lectura que sera instancias de las clases repositorios
        private readonly ICiudadRepositorio _ciudadRepositorio;
        private readonly IClientesRepositorio _clientesRepositorio;

        //constructor de esta clase controller 
        public ClientesController(ICiudadRepositorio ciudadRepositorio, IClientesRepositorio clientesRepositorio) //clase padre y clase hijo
        {
            _ciudadRepositorio = ciudadRepositorio;
            _clientesRepositorio = clientesRepositorio;
        } //fin del constructor

        //metodo para devolver la vista con todos los datos inyactados
        public ViewResult ListaClientes()
        {
            //objetos para mostrar las caracteristicas de los productos
            ListaClientesViewModel listaclientesViewModel = new ListaClientesViewModel();
           // listaclientesViewModel.Clientes =_clientesRepositorio.Clientes.Where(c=> c.CodigoCiudad == 1); //filtrado de datos

           // listaclientesViewModel.CiudadCliente = "Lista de clientes ";

             listaclientesViewModel.Clientes = _clientesRepositorio.Clientes;
            //pasando intencionalmente un valor a la variable de la clase
           listaclientesViewModel.CiudadCliente = "Listado de Clientes";




            //  return View(_clientesRepositorio.Clientes);
            return View(listaclientesViewModel);
        }   //fin del metodo ListaProductos

    }
}
