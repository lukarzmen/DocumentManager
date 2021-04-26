using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DocumentManager.Infrastructure.Entities
{
    public class Document
    {
        [Key]
        public int ID { get; set; }
        public int? ParentID { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
    }
}
