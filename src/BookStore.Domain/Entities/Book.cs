using BookStore.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Entities
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public string Overview { get; set; }
        public int AuthorId { get; set; }
        public int PublisherId { get; set; }
        public int CategoryId { get; set; }
        public int LanguageId { get; set; }
        public int FormatId { get; set; }
        public int PaperTypeId { get; set; }
        //public int CoverTypeId { get; set; }
        public int Pages { get; set; }
        public string Dimensions { get; set; }
        public int ISBN10 { get; set; }
        public int ISBN13 { get; set; }
        public int PublicationDate { get; set; }
        public string Edition { get; set; }
        public string CoverImage { get; set; }
    }
}
