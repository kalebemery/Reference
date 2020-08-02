using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference.Data
{
    public class Reply : Comment
    {
        [Key]
        public int ReplyId { get; set; }
    }
}
