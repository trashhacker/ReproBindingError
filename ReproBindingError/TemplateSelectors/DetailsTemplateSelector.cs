using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReproBindingError.TemplateSelectors
{
    internal class DetailsTemplateSelector : DataTemplateSelector
    {
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            string key = item.GetType().Name.Replace("ViewModel", "template").ToLower();
            if (Application.Current.Resources.TryGetValue(key, out object raw) && raw is DataTemplate template)
                return template;

            return null;
        }
    }
}
