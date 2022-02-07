using Blog.Data;
using Blog.Models;
using System;
using System.Linq;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new BlogDataContext())
            {
                //var tag = new Tag()
                //{
                //    Name = "ASP NET",
                //    Slug = "Microsoft"
                //};

                //ctx.Tags.Add(tag);
                //ctx.SaveChanges();

                //var tag = ctx.Tags.FirstOrDefault(x => x.Id == 3);
                //tag.Name = "New Name";
                //tag.Slug = "New Slug";
                //ctx.Tags.Update(tag);
                //ctx.SaveChanges();

                try
                {
                    var tag = ctx.Tags.FirstOrDefault(x => x.Id == 3);
                    ctx.Tags.Remove(tag);
                    ctx.SaveChanges();
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }
            }
        }
    }
}
