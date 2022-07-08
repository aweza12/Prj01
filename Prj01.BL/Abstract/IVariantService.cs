using Prj01.BL.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj01.BL.Abstract
{
    public interface IVariantService
    {
        Task<VariantDto> CreateVariantByQuestionIdAsync(VariantDto variant, Guid questionId);
    }
}
