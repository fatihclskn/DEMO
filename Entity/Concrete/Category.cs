﻿using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class Category:IEntity
    {
        public int categoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
