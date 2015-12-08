using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cubanos.BusinessEntity;

namespace Cubanos.Service
{
    public interface ICubanosGymService
    {
        //Cliente
        IEnumerable<Cliente> listarClientes(String criterio);  //listar Cliente
        void InsertarCliente(Cliente cliente); //Registrar Cliente
        Cliente GetCliente(Int32 idCliente); //devvolver un cliente
        Cliente GetClientePorDni(String dni);
        void Actualizar(Cliente cliente); //Actualizar cliente
        void EliminarCliente(Int32 IdCliente);//elliminar cliente
        //....................................................
        //Paquete
        IEnumerable<Paquete> ListarPaquete(String criterio, DateTime? fechaInicio, DateTime? fechaFin);  //listar Paquete
        //....................................................
        //Plan
        IEnumerable<Plan> ListarPlan(DateTime? fechaInicio, DateTime? fechaFin);  // listar Plan
                                                                                  //....................................................

        //Rutina
        //IEnumerable<Rutina> ListarRutina(String criterio);
        //.........................................................

        //Empleado
        IEnumerable<Empleado> ListarEmpleado(String criterio);    //listar Empleado
        void InsertarEmpleado(Empleado empleado);               //Registrar Empleado
        //.........................................................
    }
}
