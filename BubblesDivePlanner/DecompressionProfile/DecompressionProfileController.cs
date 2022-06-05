using System;
using System.Collections.Generic;
using BubblesDivePlanner.Cylinders.CylinderSetup;
using BubblesDivePlanner.DiveModels;
using BubblesDivePlanner.DiveStages;
using BubblesDivePlanner.DiveStages.Runner;
using BubblesDivePlanner.DiveStep;

namespace BubblesDivePlanner.DecompressionProfile
{
    public class DecompressionProfileController
    {
        public Queue<IDiveStepModel> CollateDecompressionDiveSteps(IDiveModel diveModel, ICylinderSetupModel selectedCylinder)
        {
            Queue<IDiveStepModel> diveStepModelQueue = new();

            while(diveModel.DiveProfile.DiveCeiling > 0)
            {
                diveStepModelQueue.Enqueue(CalculateDiveStepAtStepInterval(diveModel,selectedCylinder));
            }

            return diveStepModelQueue;
        }

        private IDiveStepModel CalculateDiveStepAtStepInterval(IDiveModel diveModel, ICylinderSetupModel selectedCylinder)
        {
            double diveCeiling = diveModel.DiveProfile.DiveCeiling;

            if (diveCeiling <= 0)
            {
                return null;
            }

            var diveStepModel = CreateDiveStepModelForStepInterval(diveCeiling);
            var diveStages = CreateDiveStages(diveModel, diveStepModel, selectedCylinder);
            var time = RunSimulatedDiveStages(diveStages, diveModel, diveStepModel);

            return new DiveStepViewModel() { Depth = diveStepModel.Depth, Time = time };
        }

        private byte FindNearestDepthToDiveCeiling(double diveCeiling)
        {
            const int stepInterval = 3;
            return diveCeiling > 0 ? (byte)(Math.Ceiling(diveCeiling / stepInterval) * stepInterval) : (byte)0;
        }

        private IDiveStepModel CreateDiveStepModelForStepInterval(double diveCeiling)
        {
            var diveStepModel = new DiveStepViewModel();
            diveStepModel.Depth = FindNearestDepthToDiveCeiling(diveCeiling);
            diveStepModel.Time = 1;

            return diveStepModel;
        }

        private IDiveStageCommand[] CreateDiveStages(IDiveModel diveModel, IDiveStepModel diveStepModel, ICylinderSetupModel selectedCylinder)
        {
            DiveStageCommandFactory diveStageCommandFactory = new(diveModel, diveStepModel, selectedCylinder);
            return diveStageCommandFactory.CreateDiveStages();
        }

        private byte RunSimulatedDiveStages(IDiveStageCommand[] diveStages, IDiveModel diveModel, IDiveStepModel diveStepModel)
        {
            byte time = 0;

            while (diveStepModel.Depth == FindNearestDepthToDiveCeiling(diveModel.DiveProfile.DiveCeiling))
            {
                time++;

                foreach (var diveStage in diveStages)
                {
                    diveStage.RunDiveStage();
                }
            }

            return time;
        }
    }
}