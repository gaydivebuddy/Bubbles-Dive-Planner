using BubblesDivePlanner.Cylinders.CylinderSetup;
using BubblesDivePlanner.DiveModels.DiveProfile;
using BubblesDivePlanner.DiveStep;
using Xunit;

namespace BubblesDivePlannerTests.Asserters
{
    public static class DiveParameterAsserter
    {
        public static void AssertDiveStepValuesEquality(IDiveStepModel expectedDiveStepViewModel, IDiveStepModel actualDiveStepViewModel)
        {
            Assert.Equal(expectedDiveStepViewModel.Depth, actualDiveStepViewModel.Depth);
            Assert.Equal(expectedDiveStepViewModel.Time, actualDiveStepViewModel.Time);
        }

        public static void AssertSelectedCylinderValuesEquality(ICylinderSetupModel expectedSelectedCylinderViewModel, ICylinderSetupModel actualSelectedCylinderViewModel)
        {
            Assert.NotNull(actualSelectedCylinderViewModel);
            Assert.Equal(expectedSelectedCylinderViewModel.CylinderName, actualSelectedCylinderViewModel.CylinderName);
            Assert.Equal(expectedSelectedCylinderViewModel.CylinderPressure, actualSelectedCylinderViewModel.CylinderPressure);
            Assert.Equal(expectedSelectedCylinderViewModel.CylinderVolume, actualSelectedCylinderViewModel.CylinderVolume);
            Assert.Equal(expectedSelectedCylinderViewModel.InitialPressurisedCylinderVolume, actualSelectedCylinderViewModel.InitialPressurisedCylinderVolume);
            Assert.NotNull(actualSelectedCylinderViewModel.GasMixture);
            Assert.Equal(expectedSelectedCylinderViewModel.GasMixture.Helium, actualSelectedCylinderViewModel.GasMixture.Helium);
            Assert.Equal(expectedSelectedCylinderViewModel.GasMixture.Oxygen, actualSelectedCylinderViewModel.GasMixture.Oxygen);
            Assert.Equal(expectedSelectedCylinderViewModel.GasMixture.Nitrogen, actualSelectedCylinderViewModel.GasMixture.Nitrogen);
            Assert.NotNull(actualSelectedCylinderViewModel.GasUsage);
            Assert.Equal(expectedSelectedCylinderViewModel.GasUsage.SurfaceAirConsumptionRate, actualSelectedCylinderViewModel.GasUsage.SurfaceAirConsumptionRate);
            Assert.Equal(expectedSelectedCylinderViewModel.GasUsage.GasRemaining, actualSelectedCylinderViewModel.GasUsage.GasRemaining);
            Assert.Equal(expectedSelectedCylinderViewModel.GasUsage.GasUsed, actualSelectedCylinderViewModel.GasUsage.GasUsed);
        }

        public static void AssertDiveProfileValuesEquality(IDiveProfileModel expectedDiveStepViewModel, IDiveProfileModel actualDiveStepViewModel)
        {
            Assert.NotNull(actualDiveStepViewModel);
            Assert.Equal(expectedDiveStepViewModel.PressureOxygen, actualDiveStepViewModel.PressureOxygen);
            Assert.Equal(expectedDiveStepViewModel.PressureNitrogen, actualDiveStepViewModel.PressureNitrogen);
            Assert.Equal(expectedDiveStepViewModel.PressureHelium, actualDiveStepViewModel.PressureHelium);
            Assert.Equal(expectedDiveStepViewModel.DiveCeiling, actualDiveStepViewModel.DiveCeiling);
            Assert.Equal(expectedDiveStepViewModel.AValues, actualDiveStepViewModel.AValues);
            Assert.Equal(expectedDiveStepViewModel.BValues, actualDiveStepViewModel.BValues);
            Assert.Equal(expectedDiveStepViewModel.MaxSurfacePressures, actualDiveStepViewModel.MaxSurfacePressures);
            Assert.Equal(expectedDiveStepViewModel.TissuePressuresNitrogen, actualDiveStepViewModel.TissuePressuresNitrogen);
            Assert.Equal(expectedDiveStepViewModel.TissuePressuresHelium, actualDiveStepViewModel.TissuePressuresHelium);
            Assert.Equal(expectedDiveStepViewModel.TissuePressuresTotal, actualDiveStepViewModel.TissuePressuresTotal);
            Assert.Equal(expectedDiveStepViewModel.ToleratedAmbientPressures, actualDiveStepViewModel.ToleratedAmbientPressures);
            Assert.Equal(expectedDiveStepViewModel.CompartmentLoad, actualDiveStepViewModel.CompartmentLoad);
        }
    }
}