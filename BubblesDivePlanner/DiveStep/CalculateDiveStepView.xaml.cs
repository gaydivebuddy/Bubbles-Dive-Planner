using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace BubblesDivePlanner.DiveStep
{
    public class CalculateDiveStepView : UserControl
    {
        public CalculateDiveStepView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}