namespace EmtptyItemsControlOverlay.Adorners
{
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Documents;
    using System.Windows.Media;

    public class TemplatedAdorner : Adorner
    {
        private ContentPresenter ContentPresenter { get; set; }

        #region Constructors

        public TemplatedAdorner(
                UIElement adornedElement, 
                AdornerLayer adornerLayer, 
                DataTemplate contentDataTemplate, object content) : base(adornedElement)
        {
            this.ContentPresenter = 
                    new ContentPresenter { 
                            ContentTemplate = contentDataTemplate, 
                            Content = content, 
                            DataContext = content };
        }

        #endregion Constructors

        #region Overridden

        protected override int VisualChildrenCount
        {
            get { return 1; }
        }

        protected override Visual GetVisualChild(int index)
        {
            return this.ContentPresenter;
        }

        protected override Size MeasureOverride(Size constraint)
        {
            return this.AdornedElement.RenderSize;
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            ContentPresenter.Arrange(new Rect(new Point(0, 0), finalSize));
            return finalSize;
        }

        #endregion Overridden
    }
}