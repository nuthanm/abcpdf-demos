using System;
using WebSupergoo.ABCpdf11;

namespace Demos_on_abcpdf
{
    class Program
    {
        static void Main(string[] args)
        {
            string outputFolder = @"D:\Projects\AbcPDF_Demos\abcpdf-demos\Demos_on_abcpdf\Output\";
            string inputFolder = @"D:\Projects\AbcPDF_Demos\abcpdf-demos\Demos_on_abcpdf\Input\";
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
            //int theID = doc.AddImageUrl("https://techinuthan.blogspot.com/"); // Converts web page to multiple Images in PDF
            //while(true)
            //{
            //    if (!doc.Chainable(theID))
            //        break;
            //    doc.Page = doc.AddPage();
            //    doc.AddImageToChain(theID);
            //}
            //doc.Save(outputFolder + "ConvertWebPageToMultiplePages.pdf");
            #endregion Demo 3 Ends - Multiple Pages inside single PDF

            #region Demo 4 Starts -  Multiple Pages inside single PDF With Links action Perform
            //doc.HtmlOptions.AddLinks = true;
            //doc.HtmlOptions.LinkPages();
            //int theID = doc.AddImageUrl("https://techinuthan.blogspot.com/"); // Converts web page to multiple Images in PDF
            //while (true)
            //{
            //    if (!doc.Chainable(theID))
            //        break;
            //    doc.Page = doc.AddPage();
            //    doc.AddImageToChain(theID);
            //}

            //doc.Save(outputFolder + "ConvertWebPageToMultiplePagesWithLinks.pdf");
            #endregion Demo 4 Ends - Multiple Pages inside single PDF With Links action Perform

            #region Demo 5 Starts -  Image With text is on top left
            // This demo adds Image as background and text is on top left
            XImage image = new XImage();
            image.SetFile(inputFolder + "IMG_2396.jpg");
            doc.AddImageObject(image, true);
            doc.FontSize = 24;
            doc.AddTextStyled("<b>Picture took it from IPHONE SE</b>");
            doc.Save(outputFolder + "ImageWithBoldText_DefaultLocation.pdf");
            #endregion Demo 5 Ends -  Image With Text is on top left

            Console.WriteLine("PDF Generated Successfully");
            Console.ReadLine();
        }
    }
}
