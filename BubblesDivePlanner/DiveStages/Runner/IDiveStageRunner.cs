namespace BubblesDivePlanner.DiveStages.Runner
{
    public interface IDiveStageRunner
    {
        //RunDiveStages() //Returns some sort of result containing the dive step, selected cylinder and dive profile

        //RunDecompressionDiveStages() //Runs a iterative calculation algorithm that effiently gets a user out of decompression
        //Has an additional setup for decompression step size

        //SimulateDecompression() //Returns a collection of dive steps with a deep clone of the dive profile (using a fresh cloned dive profile each time)
    }
}