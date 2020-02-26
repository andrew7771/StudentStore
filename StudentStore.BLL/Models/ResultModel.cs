using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentStore.BLL.Models
{
    public class ResultModel
    {
        public bool Succeeded { get; }
        public List<ErrorModel> Errors { get; }
    }
}
