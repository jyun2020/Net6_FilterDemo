using Microsoft.AspNetCore.Mvc.Filters;

namespace Net6_FilterDemo.Filters
{
    public class CustomResourceFilterAttribute : Attribute, IResourceFilter
    {
        //模擬快取
        private Dictionary<string,object> Cache = new Dictionary<string,object>();
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            Console.WriteLine("離開ResourceFilter");
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            Console.WriteLine("進入ResourceFilter");
        }
    }
}
