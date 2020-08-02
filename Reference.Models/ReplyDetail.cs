using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference.Models
{
    public class ReplyDetail
    {
        public int ReplyId { get; set; }
        [Display(Name = "Author")]
        public Guid OwnerId { get; set; }
        public string Text { get; set; }
        public int PostId { get; set; }
    }
}
