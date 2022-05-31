using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
     public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public string BlogThumnailImage { get; set; } //resimlerin sunucuda çok alan kaplayacağını var sayarak dosya yolu olarak tutacağız. thumbnail:kapak foto 
        public string BlogImage { get; set; } //büyük foto
        public DateTime BlogCreateDate { get; set; }
        public bool BlogStatus { get; set; }


        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [ForeignKey("CommentId")]
        public List<Comment> Comments { get; set; }

    }
}
