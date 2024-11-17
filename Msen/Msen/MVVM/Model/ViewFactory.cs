using Msen.MVVM.Model.Exceptions;
using Msen.MVVM.View;
using System.Windows.Controls;

namespace Msen.MVVM.Model
{
    public static class ViewFactory
    {
        private static readonly Dictionary<string, Func<UserControl>> _viewFactories = new Dictionary<string, Func<UserControl>>(StringComparer.OrdinalIgnoreCase)
        {
            { "SentenceView", () => new SentenceView() },
            { "HistoryView", () => new HistoryView() },
            { "LogInView", () => new LogInView() }
        };

        public static UserControl CreateView(string name)
        {
            if (!_viewFactories.ContainsKey(name))
                throw new NonExistentViewException($"View '{name}' does not exist.");
            return _viewFactories[name]();
        }
    }
}
