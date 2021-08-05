using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSVentas.Model;
using WSVentas.Model.Response;
using WSVentas.ViewModel;
namespace WSVentas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            Respuesta respuesta = new Respuesta();
            try
            {
                using (VentaRealContext db = new VentaRealContext())
                {
                    var lista = db.Clientes.OrderByDescending(d=>d.IdCliente).ToList();
                    respuesta.data = lista;
                    respuesta.exito = 1;
                }
            }catch(Exception ex)
            {
                respuesta.mensaje = ex.Message;
            }
           
                return Ok(respuesta);
        }

        [HttpPost]
        public IActionResult Add(ClienteRequest clienteRequest)
        {
            Respuesta respuesta = new Respuesta();
            try
            {
                using (VentaRealContext db = new VentaRealContext())
                {
                    Cliente cliente = new Cliente();
                    cliente.Nombre = clienteRequest.nombre;
                    db.Clientes.Add(cliente);
                    db.SaveChanges();
                    respuesta.exito = 1;
                }
            }
            catch (Exception ex)
            {
                respuesta.mensaje = ex.Message;
            }

            return Ok(respuesta);
        }
        [HttpPut]
        public IActionResult Edit(ClienteRequest clienteRequest)
        {
            Respuesta respuesta = new Respuesta();
            try
            {
                using (VentaRealContext db = new VentaRealContext())
                {
                    Cliente cliente = db.Clientes.Find(clienteRequest.id);
                    cliente.Nombre = clienteRequest.nombre;
                    db.Entry(cliente).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                    respuesta.exito = 1;
                }
            }
            catch (Exception ex)
            {
                respuesta.mensaje = ex.Message;
            }

            return Ok(respuesta);
        }
        [HttpPut("{id}")]
        public IActionResult Remove(long id)
        {
            Respuesta respuesta = new Respuesta();
            try
            {
                using (VentaRealContext db = new VentaRealContext())
                {
                    Cliente cliente = db.Clientes.Find(id);
                    db.Remove(cliente);
                    db.SaveChanges();
                    respuesta.exito = 1;
                }
            }
            catch (Exception ex)
            {
                respuesta.mensaje = ex.Message;
            }

            return Ok(respuesta);
        }
    }
}
