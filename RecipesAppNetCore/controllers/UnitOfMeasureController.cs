using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipesAppNetCoreData.domain;
using RecipesAppNetCoreData.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesAppNetCore.controllers
{
    /// <summary>
    /// Unit of Measure controller
    /// </summary>
    [ApiController]
    [Route("/api/[controller]")]
    public class UnitOfMeasureController : ControllerBase
    {
        private readonly IUnitOfMeasureService _service;

        public UnitOfMeasureController(IUnitOfMeasureService service)
        {
            this._service = service;
        }

        /// <summary>
        /// Gets all Unit of Measure list
        /// </summary>        
        [HttpGet]        
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<ICollection<UnitOfMeasure>> Get([FromQuery] string Description)
        {
            if (Description == null)
            {
                return Ok(_service.GetAll());
            }                
            else
            {
                return Ok(_service.GetByDescription(Description));
            }

        }

        /// <summary>
        /// Gets a Unit of Measure element using its Id
        /// </summary>        
        [HttpGet]
        [Route("{Id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<UnitOfMeasure> GetById([FromRoute] long Id)
        {
            UnitOfMeasure resp = _service.GetById(Id);

            if (resp == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(resp);
            }            
        }
    }
}
