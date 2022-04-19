using Core_WebApp.Models;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core_WebApp.CUstomTagHelpers
{
    public class ListGenerator : TagHelper
    {
        public List<Department> Departments { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "List";
            output.TagMode = TagMode.StartTagAndEndTag;
            var table = "<table class='table table-bordered table-striped table-danger'>";
            foreach (var item in Departments)
            {
                table += $"<tr><td>{item.DeptNo}</td><td>{item.DeptName}</td><td>{item.Location}</td><td>{item.Capacity}</td></tr>";
            }
            table += "</table>";
            

            //var strSb = new StringBuilder();
            //strSb.AppendFormat("<span>Hello! My Name is {0}</span>", this.Name);

             output.PreContent.SetHtmlContent(table);
        }
    }
}
