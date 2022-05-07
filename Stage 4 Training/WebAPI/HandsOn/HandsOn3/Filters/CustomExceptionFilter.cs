using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc.Filters;

namespace HandsOn3.Filters
{
    public class CustomExceptionFilter : ExceptionFilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            filterContext.ExceptionHandled = true;

            string path = @"C:Customlog.txt";
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine($"Error Type : {filterContext.Exception.GetType()}" +
                             $" | Message : {filterContext.Exception.Message}");
            }

            filterContext.Result = new InternalServerErrorResult();
        }
    }
}
