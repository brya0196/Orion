using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Orion.Business;
using Orion.Data.Models;

namespace Orion.Web.Controllers
{
    public class ProductosController : Controller
    {
        private IUnitOfWork _unitOfWork;

        public ProductosController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("/api/Productos/GetAll")]
        public IActionResult GetAll()
        {
            try
            {
                var productos = _unitOfWork.Productos.GetAll();
                return Ok(Json(productos));
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
        [Route("/api/Productos/GetById/{Id:int}")]
        public IActionResult GetById(int Id)
        {
            try
            {
                var producto = _unitOfWork.Productos.GetById(Id);
                return Ok(Json(producto));
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
        [Route("/api/Productos/Add")]
        public IActionResult Add([FromBody]Producto producto)
        {
            try
            {
                if (producto == null) return BadRequest();
                {
                    _unitOfWork.Productos.Add(producto);
                    
                    _unitOfWork.Complete();

                    return Ok(Json(producto));
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
        
        [HttpPost]
        [Route("/api/Productos/Delete")]
        public IActionResult Delete([FromBody]Producto producto)
        {
            try
            {
                if (producto == null) return BadRequest();
                {
                    _unitOfWork.Productos.Delete(producto);
                    
                    _unitOfWork.Complete();

                    return Ok(Json(producto));
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
        
        [HttpPost]
        [Route("/api/Productos/Update")]
        public IActionResult Update([FromBody]Producto producto)
        {
            try
            {
                if (producto == null) return BadRequest();
                {
                    _unitOfWork.Productos.Update(producto);
                    
                    _unitOfWork.Complete();

                    return Ok(Json(producto));
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