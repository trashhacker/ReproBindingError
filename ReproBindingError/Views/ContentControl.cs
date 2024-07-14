namespace ReproBindingError.Views
{
    public class ContentControl : ContentView
    {
        public static readonly BindableProperty DataTemplateSelectorProperty = BindableProperty.Create(nameof(DataTemplateSelector), typeof(DataTemplateSelector), typeof(ContentControl), propertyChanged: DataTemplateSelectorPropertyChanged);
        private static void DataTemplateSelectorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ContentControl control)
                control.GenerateContent();
        }

        public static readonly BindableProperty ItemTemplateProperty = BindableProperty.Create(nameof(ItemTemplate), typeof(DataTemplate), typeof(ContentControl), propertyChanged: ItemTemplatePropertyChanged);
        private static void ItemTemplatePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ContentControl control)
                control.GenerateContent();
        }

        public static readonly BindableProperty ItemProperty = BindableProperty.Create(nameof(Item), typeof(object), typeof(ContentControl), propertyChanged: ItemPropertyChanged);
        private static void ItemPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ContentControl control)
                control.GenerateContent();
        }

        public DataTemplateSelector DataTemplateSelector
        {
            get => (DataTemplateSelector)GetValue(DataTemplateSelectorProperty);
            set => SetValue(DataTemplateSelectorProperty, value);
        }
        public DataTemplate ItemTemplate
        {
            get => (DataTemplate)GetValue(ItemTemplateProperty);
            set => SetValue(ItemTemplateProperty, value);
        }
        public object Item
        {
            get => GetValue(ItemProperty);
            set => SetValue(ItemProperty, value);
        }
        private void GenerateContent()
        {
            if (Item != null && (DataTemplateSelector?.SelectTemplate(Item, this) ?? ItemTemplate) is DataTemplate template)
            {
                template.SetValue(BindingContextProperty, Item);
                if (template.CreateContent() is View view)
                {
                    Content = view;
                    return;
                }
            }

            Content = null;
            return;
        }
    }
}
