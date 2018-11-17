using Microsoft.AspNetCore.Mvc;
using Orion.Business;
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
        
    }
}