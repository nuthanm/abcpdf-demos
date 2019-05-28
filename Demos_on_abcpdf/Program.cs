using System;
using WebSupergoo.ABCpdf11;

namespace Demos_on_abcpdf
{
    class Program
    {
        static void Main(string[] args)
        {
            string outputFolder = @"D:\Projects\AbcPDF_Demos\abcpdf-demos\Demos_on_abcpdf\Output\";
            Doc doc = new Doc(); // This Doc class is coming from WebSupergoo.ABCpdf11 namespace.

            #region Demo 1 Starts
            //// Create a basic PDF With text
            //doc.AddText("Hello!!! My First PDF Demo using abcpdf library");
            //doc.Save(outputFolder + "PDFWithSimpleText.pdf");
            #endregion Demo 1 Ends

            #region Demo 2 Starts - Single PDF
            //doc.AddImageUrl("https://techinuthan.blogspot.com/"); // Converts web page to Image in PDF
            //doc.Save(outputFolder + "ConvertWebPageToPDF.pdf");
            #endregion Demo 2 Ends - Single PDF

            #region Demo 3 Starts -  Multiple Pages inside single PDF
            int theID = doc.AddImageUrl("https://techinuthan.blogspot.com/"); // Converts web page to multiple Images in PDF
            while(true)
            {
                if (!doc.Chainable(theID))
                    break;
                doc.Page = doc.AddPage();
                doc.AddImageToChain(theID);
            }
            doc.Save(outputFolder + "ConvertWebPageToMultiplePages.pdf");
            #endregion Demo 3 Ends - Multiple Pages inside single PDF

            Console.WriteLine("PDF Generated Successfully");
            Console.ReadLine();
        }
    }
}
