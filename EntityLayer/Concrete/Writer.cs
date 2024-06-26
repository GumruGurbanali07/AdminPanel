﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterID { get; set; }
        public string WriterName { get; set; }
        public string WriterSurname { get; set; }
        public string WriterPassword { get; set; }
        public string WriterEmail { get; set; }
        public string WriterImage { get; set; }
        public ICollection<Content> Contents { get; set; }
        public ICollection<Heading> Headings { get; set; }
    }
}
