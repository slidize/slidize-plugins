using Slidize;

public class PresentationMergerExamples
{
    // Merge multiple presentations into a single presentation file
    public static void MergePresentations()
    {
        var inputPaths = new string[] { "presentation1.pptx", "presentation2.pptx", "presentation3.pptx" };
        var outputPath = "merged_presentation.pptx";

        PresentationMerger.Process(inputPaths, outputPath);
    }
}