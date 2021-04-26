using DocumentManager.Core.DTOs;
using DocumentManager.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentManager.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DocumentManagerController : ControllerBase
    {
        private readonly DocumentsService documentsService;
        private readonly ILogger<DocumentManagerController> _logger;

        public DocumentManagerController(ILogger<DocumentManagerController> logger, DocumentsService documentsService)
        {
            this.documentsService = documentsService;
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public DocumentDTO GetDocument()
        {
            //return documentsService.GetDocument();
            return null;
        }
    }
}
