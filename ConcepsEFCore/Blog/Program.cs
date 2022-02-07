using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;
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

                //try
                //{
                //    var tag = ctx.Tags.FirstOrDefault(x => x.Id == 3);
                //    ctx.Tags.Remove(tag);
                //    ctx.SaveChanges();
                //}
                //catch (Exception e)
                //{
                //    System.Console.WriteLine(e.Message);
                //}

                //var tags = ctx.Tags.AsNoTracking().First(x => x.Id == 3);
                //var tags = ctx.Users.AsNoTracking().FirstOrDefault(x => x.Id == 3);
                

                //Console.WriteLine($"Tag id is:  {tags?.Id}");

                var user = new User()
                {
                    Email = "mayardesoliveira@gmail.com",
                    Image = "Urlconnection",
                    Name = "Mayardes Oliveira",
                    PasswordHash = "123",
                    Slug = "Mayardes",
                    Bio = "Mayardes Oliveira"
                };

                var category = new Category()
                {
                    Name = "Development",
                    Slug = "Dev"
                };

                var post = new Post()
                {
                    Category = category,
                    Title = "Development software",
                    Slug = "Dev",
                    Author = user,
                    Body = "<h1>Dev</h1>",
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now,
                    Summary = "Dev C#"
                };

                ctx.Posts.Add(post);
                ctx.SaveChanges();

            }
        }
    }
}
