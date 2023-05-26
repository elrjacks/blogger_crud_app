namespace Blogger.Web.Models.Domain
{
    public class Tag
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string DisplayName { get; set; }

        //the same tag can be assigned to multiple blog posts - set relation here 
        public ICollection<BlogPost> BlogPosts { get; set; }
    }
}
