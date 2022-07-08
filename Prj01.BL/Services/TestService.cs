using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using Prj01.BL.Abstract;
using Prj01.BL.Models.Dto;
using Prj01.DL.Abstract;
using Prj01.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj01.BL.Services
{
    public class TestService : ITestService
    {
        private readonly ITestRepository _testRepository;
        public readonly IMapper _mapper;

        public TestService(ITestRepository testRepository, IMapper mapper)
        {
            _testRepository = testRepository;
            _mapper = mapper;
        }

        public async Task<TestDto> CreateTestAsync(TestDto test)
        {
            TestDbModel dbModel = _mapper.Map<TestDbModel>(test);

            await _testRepository.AddAsync(dbModel);
            return test;
        }

        public async Task<List<TestDto>> GetTestsAsync()
        {
            return await _testRepository.GetAllEntitiesAsync()
                .Select(dbModel => _mapper.Map<TestDto>(dbModel))
                .ToListAsync();
        }
    }
}
