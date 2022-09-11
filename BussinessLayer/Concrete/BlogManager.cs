using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;
        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }
        public void AddBlog(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void DeleteBlog(Blog blog)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public Blog GetById(int id)
        {
            throw new NotImplementedException();
        }
        public List<Blog> GetBlogById(int id)
        {
            return _blogDal.GetAllList(x => x.BlogId == id);
        }
        public List<Blog> GetList()
        {
            return _blogDal.GetAllList();
        }
        public List<Blog> GetLast3Blog()
        {
            return _blogDal.GetAllList().Take(3).ToList();
        }

        public void UpdateBlog(Blog blog)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetBlogListByWriter(int id)
        {
            return _blogDal.GetAllList(x => x.WriterId == id);
        }
    }
}
