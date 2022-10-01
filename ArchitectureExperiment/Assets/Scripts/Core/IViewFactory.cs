public interface IViewFactory
{
    public T CreateView<T>(EViews view) where T : IView;
}
