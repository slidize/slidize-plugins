namespace Slidize.Examples;

public static class PresentationToPngConverterExamples
{
    // Basic conversion from a presentation file into PNG images
    public static void Basic()
    {
        PresentationToPngConverter.Process("presentation.pptx", "slide.png");
    }

    // Conversion with custom image dimensions
    public static void WithCustomDimensions()
    {
        var options = new ImageConverterOptions
        {
            ImageWidth = 1024,
            ImageHeight = 768
        };
        PresentationToPngConverter.Process("presentation.pptx", "slide.png", options);
    }

    // Scaling images by a factor
    public static void WithImageScaling()
    {
        var options = new ImageConverterOptions
        {
            ImageScale = 1.5f
        };
        PresentationToPngConverter.Process("presentation.pptx", "slide.png", options);
    }

    // Setting a default font for text rendering
    public static void WithDefaultFont()
    {
        var options = new ImageConverterOptions
        {
            DefaultRegularFont = "Arial"
        };
        PresentationToPngConverter.Process("presentation.pptx", "slide.png", options);
    }

    // Including speaker notes in the output images
    public static void WithSpeakerNotes()
    {
        var options = new ImageConverterOptions
        {
            SlidesViewOptions = new NotesCommentsViewOptions
            {
                NotesPosition = NotesPositions.BottomFull
            }
        };
        PresentationToPngConverter.Process("presentation.pptx", "slide.png", options);
    }

    // Including comments in the output images
    public static void WithComments()
    {
        var options = new ImageConverterOptions
        {
            SlidesViewOptions = new NotesCommentsViewOptions
            {
                CommentsPosition = CommentsPositions.Right
            }
        };
        PresentationToPngConverter.Process("presentation.pptx", "slide.png", options);
    }
}