namespace Slidize.Examples;

public static class PresentationToHtmlConverterExamples
{
    // Basic conversion from file paths
    public static void Basic()
    {
        PresentationToHtmlConverter.Process("presentation.pptx", "presentation.html");
    }

    // Stream-based conversion
    public static void StreamBased()
    {
        using var inputStream = File.OpenRead("presentation.pptx");
        using var outputStream = new MemoryStream();
        PresentationToHtmlConverter.Process(inputStream, outputStream);
    }

    // Conversion with default font setting
    public static void WithDefaultFont()
    {
        var options = new HtmlConverterOptions
        {
            DefaultRegularFont = "Arial"
        };
        PresentationToHtmlConverter.Process("presentation.pptx", "presentation.html", options);
    }

    // Adjusting picture compression level
    public static void WithPictureCompression()
    {
        var options = new HtmlConverterOptions
        {
            PicturesCompression = PicturesCompressionLevel.Dpi150
        };
        PresentationToHtmlConverter.Process("presentation.pptx", "presentation.html", options);
    }

    // Removing cropped areas of images
    public static void WithoutCroppedAreas()
    {
        var options = new HtmlConverterOptions
        {
            DeletePicturesCroppedAreas = true
        };
        PresentationToHtmlConverter.Process("presentation.pptx", "presentation.html", options);
    }

    // Setting JPEG image quality
    public static void WithJpegQuality()
    {
        var options = new HtmlConverterOptions
        {
            JpegQuality = 85
        };
        PresentationToHtmlConverter.Process("presentation.pptx", "presentation.html", options);
    }

    // Customizing slide view options
    public static void WithCustomSlideView()
    {
        var options = new HtmlConverterOptions
        {
            SlidesViewOptions = new HandoutViewOptions
            {
                Handout = HandoutViewType.Handouts4Horizontal
            }
        };
        PresentationToHtmlConverter.Process("presentation.pptx", "presentation.html", options);
    }

    // Handling different presentation formats
    public static void ConvertOdpToHtml()
    {
        PresentationToHtmlConverter.Process("presentation.odp", "presentation.html");
    }
}