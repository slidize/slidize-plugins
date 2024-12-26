namespace Slidize.Examples;

public static class PresentationToPdfConverterExamples
{
    // Basic conversion from a presentation file into PDF
    public static void Basic()
    {
        PresentationToPdfConverter.Process("presentation.pptx", "presentation.pdf");
    }

    // Conversion with PDF/A-1b compliance level
    public static void WithComplianceLevel()
    {
        var options = new PdfConverterOptions
        {
            ComplianceLevel = PdfComplianceLevel.PdfA1b
        };
        PresentationToPdfConverter.Process("presentation.pptx", "presentation.pdf", options);
    }

    // Embedding full fonts in the PDF
    public static void WithEmbeddedFonts()
    {
        var options = new PdfConverterOptions
        {
            EmbedFullFonts = true
        };
        PresentationToPdfConverter.Process("presentation.pptx", "presentation.pdf", options);
    }

    // Including hidden slides in the PDF
    public static void WithHiddenSlides()
    {
        var options = new PdfConverterOptions
        {
            ShowHiddenSlides = true
        };
        PresentationToPdfConverter.Process("presentation.pptx", "presentation.pdf", options);
    }

    // Exporting notes and comments in the PDF
    public static void WithNotesAndComments()
    {
        var options = new PdfConverterOptions
        {
            SlidesViewOptions = new NotesCommentsViewOptions
            {
                NotesPosition = NotesPositions.BottomFull,
                CommentsPosition = CommentsPositions.Right
            }
        };
        PresentationToPdfConverter.Process("presentation.pptx", "presentation.pdf", options);
    }

    // Adjusting JPEG quality in the PDF
    public static void WithJpegQuality()
    {
        var options = new PdfConverterOptions
        {
            JpegQuality = 85
        };
        PresentationToPdfConverter.Process("presentation.pptx", "presentation.pdf", options);
    }
}