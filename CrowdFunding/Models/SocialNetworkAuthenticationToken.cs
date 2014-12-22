﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class SocialNetworkAuthenticationToken
    {   [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string LongFacebookToken{ get; set;}
        public string GmailRefreshToken { get;set; }
        public string TwitterAccessToken  {get;set;}
        public string TwitterTokenSecret{ get; set; }
        public string LongLinkedInToken { get; set;}




    }
}