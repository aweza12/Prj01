using AutoMapper;
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
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository _questionRepository;
        private readonly ITestRepository _testRepository;
        public readonly IMapper _mapper;

        public QuestionService(IQuestionRepository questionRepository, ITestRepository testRepository, IMapper mapper)
        {
            _questionRepository = questionRepository;
            _testRepository = testRepository;
            _mapper = mapper;
        }

        public async Task<QuestionDto> CreateQuestionByTestIdAsync(QuestionDto question, Guid testId)
        {
            QuestionDbModel dbModel = _mapper.Map<QuestionDbModel>(question);
            dbModel.Test = _testRepository.FirstOrDefault(x => x.Id == testId);
            if (dbModel.Test == null)
            {
                throw new ApplicationException($"No such test");
            }

            await _questionRepository.AddAsync(dbModel);
            return question;
        }
    }
}
