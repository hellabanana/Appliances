using Appliances.Models;
using Appliances.ViewModel;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Appliances.Infrastructure
{
    public static class ListHelper
    {

      
            public static HtmlString CreateList1(this IHtmlHelper html )
            {
            
                return new HtmlString(@"<div class=""row"">");
            }
        public static HtmlString CreateList2(this IHtmlHelper html)
        {

            return new HtmlString("</div>");
        }
    }
    
}
