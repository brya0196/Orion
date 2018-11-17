using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Orion.Business;
using Orion.Data.Models;
using Orion.Repository.Generics;

namespace Orion.Web.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public UsuariosController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        [HttpGet]
        [Route("/api/Usuarios/GetAll")]
        public IActionResult GetAll()
        {
            try
            {
                var usuarios = _unitOfWork.Usuarios.GetAll();
                return Ok(Json(usuarios));
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
        [Route("/api/Usuarios/GetById/{Id:int}")]
        public IActionResult GetById(int Id)
        {
            try
            {
                var usuarios = _unitOfWork.Usuarios.GetById(Id);
                return Ok(Json(usuarios));
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
        [Route("/api/Usuarios/Add")]
        public IActionResult Add([FromBody]Usuario usuario)
        {
            try
            {
                if (usuario == null) return BadRequest();
                {
                    _unitOfWork.Usuarios.Add(usuario);
                    
                    _unitOfWork.Complete();

                    return Ok(Json(usuario));
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
        [Route("/api/Usuarios/Delete")]
        public IActionResult Delete([FromBody]Usuario usuario)
        {
            try
            {
                if (usuario == null) return BadRequest();
                {
                    _unitOfWork.Usuarios.Delete(usuario);
                    
                    _unitOfWork.Complete();

                    return Ok(Json(usuario));
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
        [Route("/api/Usuarios/Update")]
        public IActionResult Update([FromBody]Usuario usuario)
        {
            try
            {
                if (usuario == null) return BadRequest();
                {
                    _unitOfWork.Usuarios.Update(usuario);
                    
                    _unitOfWork.Complete();

                    return Ok(Json(usuario));
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