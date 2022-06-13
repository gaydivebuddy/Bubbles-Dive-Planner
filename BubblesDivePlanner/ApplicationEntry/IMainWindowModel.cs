using System;
using System.Reactive;
using BubblesDivePlanner.CentralNervousSystemToxicity;
using BubblesDivePlanner.Cylinders.CylinderSelector;
using BubblesDivePlanner.DecompressionProfile;
using BubblesDivePlanner.DiveModels.Selector;
using BubblesDivePlanner.DiveStep;
using BubblesDivePlanner.Header;
using BubblesDivePlanner.Results;
using ReactiveUI;

namespace BubblesDivePlanner.ApplicationEntry
{
    public interface IMainWindowModel : IEventSubscriber
    {
        IHeaderModel HeaderModel { get; }
        IDiveModelSelectorModel DiveModelSelector { get; set; }
        IDiveStepModel DiveStep { get; set; }
        ICylinderSelectorModel CylinderSelector { get; set; }
        IResultsOverviewModel ResultsOverviewModel { get; set; }
        ICentralNervousSystemToxicityModel CentralNervousSystemToxicity { get; }
        IDecompressionProfileModel DecompressionProfile { get; set; }
        ReactiveCommand<Unit, Unit> CalculateDiveStepCommand { get; }
        IObservable<bool> CanCalculateDiveStep { get; }
    }
}