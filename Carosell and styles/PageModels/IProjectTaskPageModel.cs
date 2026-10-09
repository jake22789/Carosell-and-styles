using Carosell_and_styles.Models;
using CommunityToolkit.Mvvm.Input;

namespace Carosell_and_styles.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}