namespace Slidize.Examples;

public static class PresentationToSvgConverterExamples
{
    // Basic conversion from a presentation file into SVG images
    public static void Basic()
    {
        PresentationToSvgConverter.Process("presentation.pptx", "slide.svg");
    }

    // Setting a default font for text rendering
    public static void WithDefaultFont()
    {
        var options = new SvgConverterOptions
        {
            DefaultRegularFont = "Arial"
        };
        PresentationToSvgConverter.Process("presentation.pptx", "slide.svg", options);
    }

    // Managing the compression level of pictures
    public static void WithPictureCompression()
    {
        var options = new SvgConverterOptions
        {
            PicturesCompression = PicturesCompressionLevel.Dpi150
        };
        PresentationToSvgConverter.Process("presentation.pptx", "slide.svg", options);
    }

    // Vectorizing text to improve quality
    public static void WithVectorizedText()
    {
        var options = new SvgConverterOptions
        {
            VectorizeText = true
        };
        PresentationToSvgConverter.Process("presentation.pptx", "slide.svg", options);
    }

    // Adjusting JPEG quality in the SVG
    public static void WithJpegQuality()
    {
        var options = new SvgConverterOptions
        {
            JpegQuality = 85
        };
        PresentationToSvgConverter.Process("presentation.pptx", "slide.svg", options);
    }

    // Controlling the resolution of rasterized metafiles
    public static void WithMetafileRasterizationDpi()
    {
        var options = new SvgConverterOptions
        {
            MetafileRasterizationDpi = 150
        };
        PresentationToSvgConverter.Process("presentation.pptx", "slide.svg", options);
    }
}