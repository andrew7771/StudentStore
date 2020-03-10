using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentStore.BLL.Models
{
    public class OperationResult
    {
        public bool Succeeded { get; set; } = false;
        public object Result { get; set; } = null;
        public List<ErrorModel> Errors { get; set; } = new List<ErrorModel>();

        public OperationResult AddError(string code, string description)
        {
            Errors.Add(new ErrorModel
            {
                Code = code,
                Description = description
            });
            return this;
        }
    }
}
