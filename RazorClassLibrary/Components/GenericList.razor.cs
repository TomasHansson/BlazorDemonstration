using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RazorClassLibrary.Components
{
    public partial class GenericList<T>
    {
        [Parameter]
        [EditorRequired]
        public List<T> Items { get; set; }
        private List<PropertyInfo> properties;

        protected override void OnInitialized()
        {
            properties = typeof(T).GetProperties().ToList();
        }
    }
}
