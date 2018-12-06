using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BookStore.Helpers
{
    public static class ImageHelper
    {
        public static MvcHtmlString Image(this HtmlHelper html, string url, string alternateText,
            object htmlAttributes)
        {
            TagBuilder img = new TagBuilder("img");
            img.MergeAttribute("src", url);
            img.MergeAttribute("alt", alternateText);
            img.MergeAttributes(new RouteValueDictionary(htmlAttributes));
            //Чтобы обозначить элемент как самозакрывающийся, мы можем применить значение TagRenderMode.SelfClosing.
            return MvcHtmlString.Create(img.ToString(TagRenderMode.SelfClosing));
        }
    }
}