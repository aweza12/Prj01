using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj01.DL.Models
{
    public class TestDbModel : BaseDbModel
    {
        public string Name { get; set; }
        public List<QuestionDbModel> Questions { get; set; }
    }
}
