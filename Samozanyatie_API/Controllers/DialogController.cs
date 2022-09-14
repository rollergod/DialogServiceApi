using Microsoft.AspNetCore.Mvc;
using Samozanyatie_API.Application.Interfaces;
using Samozanyatie_API.DAL.Interfaces;
using Samozanyatie_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Samozanyatie_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DialogController : ControllerBase
    {
        private readonly IGetDialog _dialogService;

        public DialogController(IGetDialog dialogService)
        {
            _dialogService = dialogService;
        }

        [HttpGet]
        [ProducesResponseType(200,Type = typeof(string))]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public IActionResult Get([FromQuery] Guid[] idsToSearch)
        {
            if (idsToSearch == null || idsToSearch.Length == 0)
                return BadRequest();

            var result = _dialogService.GetDialogId(idsToSearch);

            if (result.Length == 0)
                return NotFound();

            return Ok(result);
        }
    }
}
