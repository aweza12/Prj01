using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj01.DL.Models
{
    public class VariantDbModel : BaseDbModel
    {
        public string Text { get; set; }
        public bool IsRight { get; set; }
        public QuestionDbModel Question { get; set; }
    }
}
