using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Razor;

namespace project.Infrastructure
{
    public class FeatureLocationExpander: IViewLocationExpander
    {
        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string>viewLocations){
            return new[] { "/Features/{1}/{0}.cshtml", "/Features/Shared/{0}.cshtml" };
        }
        public void PopulateValues(ViewLocationExpanderContext context){}
    }
}