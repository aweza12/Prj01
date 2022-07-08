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
    public class VariantService : IVariantService
    {
        private readonly IVariantRepository _variantRepository;
        private readonly IQuestionRepository _questionRepository;
        public readonly IMapper _mapper;


        public VariantService(IVariantRepository variantRepository, IQuestionRepository questionRepository, IMapper mapper)
        {
            _variantRepository = variantRepository;
            _questionRepository = questionRepository;
            _mapper = mapper;
        }

        public async Task<VariantDto> CreateVariantByQuestionIdAsync(VariantDto variant, Guid questionId)
        {
            VariantDbModel dbModel = _mapper.Map<VariantDbModel>(variant);
            dbModel.Question = _questionRepository.FirstOrDefault(x => x.Id == questionId);
            if (dbModel.Question == null)
            {
                throw new ApplicationException($"No such question");
            }

            await _variantRepository.AddAsync(dbModel);
            return variant;
        }
    }
}
