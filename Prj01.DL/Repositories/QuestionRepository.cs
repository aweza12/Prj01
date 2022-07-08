using Prj01.DL.Abstract;
using Prj01.DL.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj01.DL.Repositories
{
    public class QuestionRepository : BaseRepository<QuestionDbModel>, IQuestionRepository
    {
        public QuestionRepository(Prj01DbContext dbContext, IHttpContextAccessor httpContextAccessor) : base(dbContext, httpContextAccessor)
        {

        }
    }
}
