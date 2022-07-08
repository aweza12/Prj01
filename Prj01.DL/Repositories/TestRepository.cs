using Microsoft.AspNetCore.Http;
using Prj01.DL.Abstract;
using Prj01.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj01.DL.Repositories
{
    public class TestRepository : BaseRepository<TestDbModel>, ITestRepository
    {
        public TestRepository(Prj01DbContext dbContext, IHttpContextAccessor httpContextAccessor) : base(dbContext, httpContextAccessor)
        {

        }
    }
}
