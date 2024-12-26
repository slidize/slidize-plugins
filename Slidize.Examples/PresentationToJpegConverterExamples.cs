namespace Slidize.Examples;

public static class PresentationToJpegConverterExamples
{
    // Basic conversion from a presentation file into JPEG images
    public static void Basic()
    {
        PresentationToJpegConverter.Process("presentation.pptx", "slide.jpg");
    }

    // Conversion with custom image dimensions
    public static void WithCustomDimensions()
    {
        var options = new ImageConverterOptions
        {
            ImageWidth = 1024,
            ImageHeight = 768
        };
        PresentationToJpegConverter.Process("presentation.pptx", "slide.jpg", options);
    }

    // Scaling images by a factor
    public static void WithImageScaling()
    {
        var options = new ImageConverterOptions
        {
            ImageScale = 1.5f
        };
        PresentationToJpegConverter.Process("presentation.pptx", "slide.jpg", options);
    }

    // Setting a default font for text rendering
    public static void WithDefaultFont()
    {
        var options = new ImageConverterOptions
        {
            DefaultRegularFont = "Arial"
        };
        PresentationToJpegConverter.Process("presentation.pptx", "slide.jpg", options);
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
        PresentationToJpegConverter.Process("presentation.pptx", "slide.jpg", options);
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
        PresentationToJpegConverter.Process("presentation.pptx", "slide.jpg", options);
    }
}