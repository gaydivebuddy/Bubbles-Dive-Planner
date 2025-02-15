using BubblesDivePlanner.ApplicationEntry;
using BubblesDivePlanner.Header.File.New;

namespace BubblesDivePlanner.Header.File
{
    public class FileViewModel : IFileModel
    {
        private readonly IMainWindowModel _mainWindowModel;

        public FileViewModel(IMainWindowModel mainWindowModel)
        {
            _mainWindowModel = mainWindowModel;
            NewModel = new NewViewModel(_mainWindowModel);
        }

        public INewModel NewModel { get; }
    }
}