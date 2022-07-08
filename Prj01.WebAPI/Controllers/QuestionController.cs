using Microsoft.AspNetCore.Mvc;
using Prj01.BL.Abstract;
using Prj01.BL.Models.Dto;

namespace Prj01.WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiVersion("1")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionService _questionService;
        public QuestionController(IQuestionService questionService)
        {
            _questionService = questionService;
        }

        /// <summary>
        /// Create test by test id.
        /// </summary>
        /// <param name="testId"></param>
        [HttpPost]
        public async Task<QuestionDto> CreateQuestionByTestIdAsync([FromBody] QuestionDto question, Guid testId)
        {
            return await _questionService.CreateQuestionByTestIdAsync(question, testId);
        }
    }
}
