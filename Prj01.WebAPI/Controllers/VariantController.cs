using Microsoft.AspNetCore.Mvc;
using Prj01.BL.Abstract;
using Prj01.BL.Models.Dto;

namespace Prj01.WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiVersion("1")]
    [ApiController]
    public class VariantController : ControllerBase
    {
        private readonly IVariantService _variantService;
        public VariantController(IVariantService variantService)
        {
            _variantService = variantService;
        }

        /// <summary>
        /// Create variant by question id.
        /// </summary>
        /// <param name="questionId"></param>
        [HttpPost]
        public async Task<VariantDto> CreateVariantByQuestionIdAsync([FromBody] VariantDto variant, Guid questionId)
        {
            return await _variantService.CreateVariantByQuestionIdAsync(variant, questionId);
        }
    }
}
