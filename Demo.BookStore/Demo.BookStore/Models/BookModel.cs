﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.BookStore.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string auther { get; set; }

        public string Description { get; set; }
        public string Category { get; set; }
        public int Totalpages { get; set; }
        public string Language { get; set; }

    }
}
