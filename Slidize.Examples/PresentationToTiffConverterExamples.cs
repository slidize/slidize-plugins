namespace Slidize.Examples;

public static class PresentationToTiffConverterExamples
{
    // Basic conversion from a presentation file into TIFF images
    public static void Basic()
    {
        PresentationToTiffConverter.Process("presentation.pptx", "slide.tiff");
    }

    // Conversion with custom image dimensions
    public static void WithCustomDimensions()
    {
        var options = new TiffConverterOptions
        {
            ImageWidth = 1024,
            ImageHeight = 768
        };
        PresentationToTiffConverter.Process("presentation.pptx", "slide.tiff", options);
    }

    // Creating a multi-page TIFF from the presentation
    public static void WithMultiPageTiff()
    {
        var options = new TiffConverterOptions
        {
            MultiPage = true
        };
        PresentationToTiffConverter.Process("presentation.pptx", "presentation.tiff", options);
    }

    // Setting a default font for text rendering
    public static void WithDefaultFont()
    {
        var options = new TiffConverterOptions
        {
            DefaultRegularFont = "Arial"
        };
        PresentationToTiffConverter.Process("presentation.pptx", "slide.tiff", options);
    }

    // Including speaker notes in the output images
    public static void WithSpeakerNotes()
    {
        var options = new TiffConverterOptions
        {
            SlidesViewOptions = new NotesCommentsViewOptions
            {
                NotesPosition = NotesPositions.BottomFull
            }
        };
        PresentationToTiffConverter.Process("presentation.pptx", "slide.tiff", options);
    }

    // Applying LZW compression to the TIFF images
    public static void WithLzwCompression()
    {
        var options = new TiffConverterOptions
        {
            CompressionType = TiffCompressionTypes.LZW
        };
        PresentationToTiffConverter.Process("presentation.pptx", "slide.tiff", options);
    }
}