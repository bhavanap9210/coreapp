using CoreApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Infrastructure
{
    [HtmlTargetElement("div", Attributes = "page-model")]
    public class PageLinkTagHelper : TagHelper
    {
        private IUrlHelperFactory _urlHelperFactory;
        public PageLinkTagHelper(IUrlHelperFactory urlHelperFactory)
        {
            _urlHelperFactory = urlHelperFactory;
        }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }

        public PagingInfo PageModel { get; set; }

        public string PageAction { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper urlHelper = _urlHelperFactory.GetUrlHelper(ViewContext);
            TagBuilder tagBuilder = new TagBuilder("div");
            int firstPage = 1;
            int diff = 0;
            int lastPage = 0;


            //calculate first page 
            if (PageModel.CurrentPage % 5 == 0)
            { 
                for (int j = PageModel.CurrentPage-1; j > 0; j--)
                {
                    if (j % 5 == 0)
                    {
                        firstPage = j+1;
                        break;
                    }
                }
            }
            else
            {
                for (int j = PageModel.CurrentPage; j > 0; j--)
                {
                    if (j % 5 == 0)
                    {
                        firstPage = j + 1;
                        break;
                    }
                }
            }

            diff = PageModel.CurrentPage - firstPage + 1;
            if (diff > -1)
                lastPage = PageModel.CurrentPage + 5 - diff;
            else
                lastPage = PageModel.CurrentPage + 5;

            if (lastPage > PageModel.TotalPages)
                lastPage = PageModel.TotalPages;

            if (firstPage > 5)
            {
                TagBuilder taNext = new TagBuilder("a");
                taNext.Attributes["href"] = urlHelper.Action(PageAction, new { pageIndex = firstPage - 1 });
                taNext.InnerHtml.AppendHtml("<" + "&nbsp;");
                tagBuilder.InnerHtml.AppendHtml(taNext);
            }

            for (int i = firstPage; i <= lastPage; i++)
            {
                TagBuilder ta = new TagBuilder("a");
                ta.Attributes["href"] = urlHelper.Action(PageAction, new { pageIndex = i });
                if (PageModel.CurrentPage == i)
                {
                    ta.Attributes["class"] = "selected-page-index";
                }
                else
                {
                    ta.Attributes["class"] = "not-selected-page-index";
                }
                ta.InnerHtml.AppendHtml(i.ToString() + "&nbsp;");
                tagBuilder.InnerHtml.AppendHtml(ta);
            }
            
            if (lastPage != PageModel.TotalPages)
            {
                TagBuilder taNext = new TagBuilder("a");
                taNext.Attributes["href"] = urlHelper.Action(PageAction, new { pageIndex = lastPage + 1 });
                taNext.InnerHtml.AppendHtml(">" + "&nbsp;");
                tagBuilder.InnerHtml.AppendHtml(taNext);
            }
            output.Content.AppendHtml(tagBuilder);
        }
    }
}
