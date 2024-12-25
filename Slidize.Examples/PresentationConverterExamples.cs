using Slidize;

public class PresentationConverterExamples
{
    // Convert a legacy PowerPoint presentation (PPT) to the modern PPTX format
    public static void ConvertPptToPptx()
    {
        PresentationConverter.Process("input.ppt", "output.pptx");
    }

    // Convert a PowerPoint presentation (PPTX) to the OpenDocument Presentation format (ODP)
    public static void ConvertPptxToOdp()
    {
        PresentationConverter.Process("input.pptx", "output.odp");
    }

    // Convert a presentation to a PowerPoint template format (POTX)
    public static void ConvertToPotx()
    {
        PresentationConverter.Process("input.pptx", "output.potx");
    }

    // Convert a presentation to a macro-enabled PowerPoint format (PPTM)
    public static void ConvertToPptm()
    {
        PresentationConverter.Process("input.pptx", "output.pptm");
    }

    // Convert a presentation to a PowerPoint Show format (PPSX)
    public static void ConvertToPpsx()
    {
        PresentationConverter.Process("input.pptx", "output.ppsx");
    }

    // Convert a presentation to a macro-enabled PowerPoint Show format (PPSM)
    public static void ConvertToPpsm()
    {
        PresentationConverter.Process("input.pptx", "output.ppsm");
    }

    // Convert a presentation to an OpenDocument Flat XML Presentation format (FODP)
    public static void ConvertToFodp()
    {
        PresentationConverter.Process("input.pptx", "output.fodp");
    }

    // Convert a presentation to an OpenDocument Presentation Template format (OTP)
    public static void ConvertToOtp()
    {
        PresentationConverter.Process("input.pptx", "output.otp");
    }

    // Convert a presentation to a PowerPoint XML Presentation format
    public static void ConvertToXml()
    {
        PresentationConverter.Process("input.pptx", "output.xml");
    }

    // Convert a presentation using streams instead of file paths
    public static void ConvertUsingStreams()
    {
        using var inputStream = new FileStream("input.pptx", FileMode.Open);
        using var outputStream = new FileStream("output.pptx", FileMode.Create);

        PresentationConverter.Process(inputStream, outputStream, ConvertFormat.Pptx);
    }
}
