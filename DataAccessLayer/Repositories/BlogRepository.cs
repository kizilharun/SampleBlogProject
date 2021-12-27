using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogDal
    {
        Context c = new Context();
        public void AddBlog(Blog blog)
        {
            c.Blogs.Add(blog);
            c.SaveChanges();
        }

        public void Delete(Blog t)
        {
            throw new NotImplementedException();
        }

        public void DeleteBlog(Blog blog)
        {
            c.Blogs.Remove(blog);
            c.SaveChanges();
        }

        public List<Blog> GetAllList()
        {
            throw new NotImplementedException();
        }

        public Blog GetById(int id)
        {
            return c.Blogs.Find(id);
        }

        public void Insert(Blog t)
        {
            throw new NotImplementedException();
        }

        public List<Blog> ListAllBlogs()
        {
            return c.Blogs.ToList();
        }

        public void Update(Blog t)
        {
            throw new NotImplementedException();
        }

        public void UpdateBlog(Blog blog)
        {
            c.Update(blog);
            c.SaveChanges();
        }
    }
}
