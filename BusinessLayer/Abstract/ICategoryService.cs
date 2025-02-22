﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetList();
        Category GetById(int id);
        void CategoryAddBl(Category category);
        void CategoryDelete(Category category);
        void CategoryUpdate(Category category);
    }
}
