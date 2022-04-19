using Core_WebApp.Models;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core_WebApp.MyTagHelpers
{
    public class CollectionGenerator : TagHelper
    {
        // <collection-generator departments=""></collection-generator>
        public List<Department> Departments { get; set; }
        /// <summary>
        /// TagHelperContext: Define a Execution of the Tah Helper on Veiw
        /// where it is used
        /// TagHelperOutput: Define a Custom Tage ith HTML Rendering
        /// </summary>
        /// <param name="context"></param>
        /// <param name="output"></param>
        /// <returns></returns>
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            // Custom Tag
            output.TagName = "Collection";
            // <collection></collection>
            output.TagMode = TagMode.StartTagAndEndTag;
            // The encapsulation of Actual HTML UI ELement
            var table = "<table class='table table-bordered table-striped table-danger'>";
            foreach (var item in Departments)
            {
                table += $"<tr><td>{item.DeptNo}</td><td>{item.DeptName}</td><td>{item.Location}</td><td>{item.Capacity}</td></tr>";
            }
            table += "</table>";


             // Set HTML for Content Redering
            output.PreContent.SetHtmlContent(table);
        }
    }
}
