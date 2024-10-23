using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Maui.Controls;


namespace guiacursodois.ViewModel
{
    public class DetailPageViewModel
    {
        public string Title { get; set; }
        public string Detail { get; set; }

        public DetailPageViewModel(IDictionary<string, string> parameters)
        {

            parameters ??= new Dictionary<string, string>(); 

            Title = parameters.TryGetValue("title", out var title) ? title : "000";
            Detail = parameters.TryGetValue("detail", out var detail) ? detail : "000";
        }
    }
}
