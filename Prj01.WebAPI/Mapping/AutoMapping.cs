using AutoMapper;
using Prj01.DL.Models;
using Prj01.BL.Models.Dto;

namespace Prj01.WebAPI.Mapping
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<QuestionDbModel, QuestionDto>();
            CreateMap<QuestionDto, QuestionDbModel>();

            CreateMap<TestDbModel, TestDto>();
            CreateMap<TestDto, TestDbModel>();

            CreateMap<VariantDbModel, VariantDto>();
            CreateMap<VariantDto, VariantDbModel>();
        }
    }
}
