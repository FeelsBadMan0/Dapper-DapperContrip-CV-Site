﻿using Dapper.Contrib.Extensions;
using System;

namespace ARSProje.DapperCvAppEntities.Concrate.BaseClasses
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
