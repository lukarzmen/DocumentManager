using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentManager.Core.DTOs
{
    public class DocumentDTO
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public List<DocumentDTO> ChildDocuments { get; set; }
        public DocumentDTO Parent { get; set; }
    }
}
