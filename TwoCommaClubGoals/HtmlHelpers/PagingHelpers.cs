﻿using System;
using System.Text;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TwoCommaClubGoals.Models;

namespace TwoCommaClubGoals.HtmlHelpers
{
        public static class PagingHelpers
        {
        public static MvcHtmlString PageLinks(this HtmlHelper html,Paging paging,Func<int, string> pageUrl)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 1; i <= paging.TotalPages; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", pageUrl(i));
                tag.InnerHtml = i.ToString();
                if (i == paging.CurrentPage)
                {
                    tag.AddCssClass("selected");
                    tag.AddCssClass("btn-primary");
                }
                tag.AddCssClass("btn btn-default");
                result.Append(tag.ToString());
            }
            return MvcHtmlString.Create(result.ToString());
        }
    }
}