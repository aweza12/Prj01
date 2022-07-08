using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj01.BL.Models.Dto
{
    public abstract class BaseDto
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }
    }
}
