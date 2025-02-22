﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ContentManager:IContentService
    {

        IContentDal _contentDal;

        public  ContentManager(IContentDal contentDal)
        {
            _contentDal = contentDal;
        }

        public List<Content> GetList()
        {
            return _contentDal.List();
        }

        public List<Content> GetListByParameter(string p)
        {
            return _contentDal.List(x => x.ContentValue.Contains(p));
        }

        public List<Content> GetListByHeadingId(int Id)
        {
            return _contentDal.List(x => x.HeadingId == Id);
        }

        public List<Content> GetListByWriter(int Id)
        {
            return _contentDal.List(x => x.WriterId == Id);
        }

        public void ContentAddBl(Content content)
        {
            _contentDal.Insert(content);
        }

        public Content GetById(int id)
        {
            return _contentDal.Get(x => x.ContentId == id);
        }

        public void ContentDelete(Content content)
        {
            _contentDal.Delete(content);
        }

        public void ContentUpdate(Content content)
        {
            _contentDal.Update(content);
        }
    }
}
