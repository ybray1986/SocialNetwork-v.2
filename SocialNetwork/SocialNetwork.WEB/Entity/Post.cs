﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SocialNetwork.WEB.Entity
{
    public class Post
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPost { get; set; }
        public string Title { get; set; }
        public string PostContent { get; set; }
        public bool? TypePublic { get; set; }
        public Category IdCategory { get; set; }
        public DateTime? PostDate { get; set; }
        public byte[] PostImage { get; set; }
        public User IdUser { get; set; }
    }
}