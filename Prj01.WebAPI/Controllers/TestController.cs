using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Prj01.BL.Abstract;
using Prj01.BL.Models.Dto;

namespace Prj01.WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiVersion("1")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ITestService _testService;
        public TestController(ITestService testService)
        {
            _testService = testService;
        }

        /// <summary>
        /// Create test.
        /// </summary>
        [HttpPost]
        public async Task<TestDto> CreateTestAsync([FromBody] TestDto test)
        {
            return await _testService.CreateTestAsync(test);
        }

        /// <summary>
        /// Get all tests.
        /// </summary>
        [HttpGet]
        public async Task<List<TestDto>> GetTestsByNameAsync()
        {
            return await _testService.GetTestsAsync();
        }
    }
}
