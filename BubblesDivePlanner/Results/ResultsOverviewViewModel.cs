using System.Collections.ObjectModel;
using ReactiveUI;

namespace BubblesDivePlanner.Results
{
    public class ResultsOverviewViewModel : ReactiveObject, IResultsOverviewModel
    {
        public ObservableCollection<IResultModel> Results
        {
            get;
        } = new ObservableCollection<IResultModel>();

        private IResultModel _latestResult = new ResultViewModel();
        public IResultModel LatestResult
        {
            get => _latestResult;
            set
            {
                Results.Add(_latestResult);
                this.RaiseAndSetIfChanged(ref _latestResult, value);
            }
        }

        private bool _isVisible = false;
        public bool IsVisible
        {
            get => _isVisible;
            set => this.RaiseAndSetIfChanged(ref _isVisible, value);
        }
    }
}