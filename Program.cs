using System;
using System.Linq;
using System.Threading.Tasks;

namespace aspweb
{
    class Program
    {
        static async Task Main(string[] args)
        {

            string pathToCurrentDirectory = Environment.CurrentDirectory;
            string path = $"{ pathToCurrentDirectory }/posts.json";
            
            var postService = new PostService();
            var fileService = new FileService();
            
            var postIds = new[] {4, 5, 6, 7, 8, 9, 10, 11, 12, 13};

            var tasks = postIds.Select(postId => postService.GetPostAsync(postId)).ToList();

            try
            {
                var posts = await Task.WhenAll(tasks);

                foreach (var post in posts)
                {
                    fileService.WritePostToFile(path, post);
                    Console.WriteLine(post.Id);
                }
            }
            catch (Exception  e)
            {
                foreach (var task in tasks.Where(x => x.IsFaulted))
                {
                    Console.WriteLine($"Error: { e.Message }");
                }
            }
        }
    }
}