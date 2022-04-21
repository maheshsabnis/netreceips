using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;

namespace Blazor_Wasm.Pages
{
    public partial class JustTestComponent: ComponentBase
    {
        public JustTestComponent()
        {
            
            values = new Values();
        }
        public Values values { get; set; }

        public void Add()
        {
            values.Z = values.X + values.Y;
        }
    }

    public class Values
    {
        [Required(ErrorMessage ="X is Mandatory")]
        public int X { get; set; }
        [Required(ErrorMessage = "Y is Mandatory")]
        public int Y { get; set; }
        public int Z { get; set; }
        [Required(ErrorMessage = "NAme is Mandatory")]
        public string Name { get; set; }
    }
}
