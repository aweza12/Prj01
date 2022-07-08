using Prj01.DL.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj01.DL.Models
{
    public abstract class BaseDbModel : IEntity
    {
        protected BaseDbModel()
        {
            CreatedOn = DateTime.Now;
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
