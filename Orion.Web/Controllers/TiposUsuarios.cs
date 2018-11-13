using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Orion.Business;
using Orion.Data.Models;

namespace Orion.Web.Controllers
{
    public class TiposUsuarios : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public TiposUsuarios(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("api/TiposUsuarios/GetAll")]
        public IActionResult GetAll()
        {
            try
            {
                var tiposUsuarios = _unitOfWork.TiposUsuarios.GetAll();
                return Json(tiposUsuarios);
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
        
        [HttpGet]
        [Route("api/TiposUsuarios/GetById/{Id:int}")]
        public IActionResult GetById(int Id)
        {
            try
            {
                var tiposUsuarios = _unitOfWork.TiposUsuarios.GetById(Id);
                return Json(tiposUsuarios);
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
        [Route("api/TiposUsuarios/Add")]
        public IActionResult Add(TiposUsuario tipoUsuario)
        {
            try
            {
                if (tipoUsuario == null) return BadRequest();
                {
                    _unitOfWork.TiposUsuarios.Add(tipoUsuario);
                    
                    _unitOfWork.Complete();

                    return Json(tipoUsuario);
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