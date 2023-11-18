using HackathonApi.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace HackathonApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PdfController : ControllerBase
    {

        private PDFservice _pdfService;
        public PdfController(PDFservice pdfService) { 
            _pdfService = pdfService;
        }


        [HttpPost("agreement")]
        public IActionResult GetAgreementPdf([FromBody] TemplateDTO template)
        {
            return File(_pdfService.Form_1_Generate(template.User, template.Internship, template.Polish), "application/pdf");
        }

    }
}
