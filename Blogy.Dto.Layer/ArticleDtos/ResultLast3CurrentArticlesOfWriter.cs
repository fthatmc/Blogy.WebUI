﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.Dto.Layer.ArticleDtos
{
    public class ResultLast3CurrentArticlesOfWriter
    {
        public int ArticleId { get; set; }
        public string ImageURL { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
    }
}
