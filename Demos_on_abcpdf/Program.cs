using WebSupergoo.ABCpdf11;

namespace Demos_on_abcpdf
{
    class Program
    {
        static void Main(string[] args)
        {
            string outputFolder = @"D:\Projects\AbcPDF_Demos\abcpdf-demos\Demos_on_abcpdf\Output\";
            // Create a basic PDF
            Doc mainDoc = new Doc(); // This Doc class is coming from WebSupergoo.ABCpdf11 namespace.
            mainDoc.AddText("Hello!!! My First PDF Demo using abcpdf library");
            mainDoc.Save(outputFolder + "PDFWithSimpleText.pdf");
        }
    }
}
