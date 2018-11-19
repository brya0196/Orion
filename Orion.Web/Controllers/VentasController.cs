using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Orion.Business;
using Orion.Data.Models;

namespace Orion.Web.Controllers
{
    public class VentasController : Controller
    {
        private IUnitOfWork _unitOfWork;

        public VentasController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        [HttpGet]
        [Route("/api/Ventas/GetAll")]
        public IActionResult GetAll()
        {
            try
            {
                var ventas = _unitOfWork.Ventas.GetAll();
                return Ok(Json(ventas));
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
            finally
            {
                _unitOfWork.Dispose();
            }
        }
        
        [HttpPost]
        [Route("/api/Ventas/GetById/{Id:int}")]
        public IActionResult GetById(int Id)
        {
            try
            {
                var ventas = _unitOfWork.Ventas.GetById(Id);
                return Ok(Json(ventas));
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
            finally
            {
                _unitOfWork.Dispose();
            }
        }
        
        [HttpPost]
        [Route("/api/Ventas/Add")]
        public IActionResult Add([FromBody]Venta venta)
        {
            try
            {
                if (venta == null) return BadRequest();
                {
                    _unitOfWork.Ventas.Add(venta);
                    
                    _unitOfWork.Complete();

                    return Ok(Json(venta));
                }
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
            finally
            {
                _unitOfWork.Dispose();
            }
        }
    }
}