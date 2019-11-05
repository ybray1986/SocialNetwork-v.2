using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SocialNetwork.WEB.Entity
{
    public class Comment
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdComment { get; set; }
        public string CommentText { get; set; }
        public Post IdPost { get; set; }
        public User IdUser { get; set; }
        public DateTime? CommentDate { get; set; }
    }
}