using Blog.Data;
using Blog.Models;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new BlogDataContext())
            {
                var tag = new Tag()
                {
                    Name = "ASP NET",
                    Slug = "Microsoft"
                };

                ctx.Tags.Add(tag);
                ctx.SaveChanges();


            }
        }
    }
}
