using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj01.DL.Models
{
    public class QuestionDbModel : BaseDbModel
    {
        public string Text { get; set; }
        public List<VariantDbModel> Variants { get; set; }
        public TestDbModel? Test { get; set; }
    }
}
