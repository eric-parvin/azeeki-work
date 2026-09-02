using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using Antlr.Runtime;
using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using PdfSharp.Drawing;

namespace ValidateMyInsurance
{
    internal class Utility
    {

#region Methods

      internal static string ReturnStringLeft(string str, int length)
        {
            if (!string.IsNullOrEmpty(str))
            {
                return str.Substring(0, Math.Min(length, str.Length));
            }
            else
            {
                return "";
            }

        }

        internal static bool checkFileSize(decimal filesize)
        {
            //returns true if the file is too large
            decimal size = Math.Round(((decimal)filesize / (decimal)1024), 2);
            if (size > 4048 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal static bool checkFileExtention(string fileName )
        {
            //This list is subject to change based on the type of attachments being sent by the cusotmers.
            string[] ValidFileExtensions = new string[] { ".pdf", ".docx", ".doc", ".jpg", ".png", ".jpeg", ".tif", "gif" };
            bool knownExtension = false;

            string fileExtension = Path.GetExtension(fileName);
            string fileExtLower = fileExtension.ToLower();

            foreach (string extension in ValidFileExtensions)
            {
                if (fileExtLower == extension)
                {
                    knownExtension = true;
                    break;
                }
            }

            return knownExtension;

        }

        internal static bool extensionToConvert(string fileName)
        {
            //This list is subject to change based on the type of attachments being sent by the cusotmers. Cannot convert Word to PDF
            string[] ValidFileExtensions = new string[] { ".pdf", ".jpg", ".png", ".jpeg", ".tif", "gif"};
            bool knownExtension = false;

            string fileExtension = Path.GetExtension(fileName);

            foreach (string extension in ValidFileExtensions)
            {
                if (fileExtension == extension)
                {
                    knownExtension = true;
                    break;
                }
            }

            return knownExtension;

        }

        internal static string returnPhoneNbr(string phoneIn)
        {
            string phoneOut;

            if (!string.IsNullOrEmpty(phoneIn))
            {
                //phoneOut = String.Format("{0:(###) ###-####}", phoneIn);
                phoneOut = Regex.Replace(phoneIn, @"(\d{3})(\d{3})(\d{4})", "$1-$2-$3");
            }
            else
            {
                phoneOut = "NO Phone Number Provided";
            }

            return phoneOut;
        }

        internal static bool emailArchiveDirExists(string emailArchiveDir)
        {
            System.IO.Directory.CreateDirectory(emailArchiveDir);

            return true;
        }

        public static bool MergePDFs(string targetPath, params string[] pdfs)
        {
            //There is an issue with the merge operation on certain PDF files. Changing this to return a false if the merge was unsuccsful. There is ot fix to the library.
            try
            {
                using (PdfDocument targetDoc = new PdfDocument())
                {
                    foreach (string pdf in pdfs)
                    {
                        using (PdfDocument pdfDoc = PdfReader.Open(pdf, PdfDocumentOpenMode.Import))
                        {
                            for (int i = 0; i < pdfDoc.PageCount; i++)
                            {
                                targetDoc.AddPage(pdfDoc.Pages[i]);
                            }
                        }
                    }
                    targetDoc.Save(targetPath);

                    return true;
                }

            }
            catch (PdfReaderException pdfException)
            {
                //There nothing to do on the exception
                return false;
            }
        }

        public static void ConvertToPDF(string targetFilePath, string sourceFilePath)
        {
            PdfDocument doc = new PdfDocument();
            var page = new PdfPage();

            //Get the image from the source file and to convert to PDF
            XImage img = XImage.FromFile(sourceFilePath);

            if (img.Width > img.Height)
            {
                page.Orientation = PageOrientation.Landscape;
            }
            else
            {
                page.Orientation = PageOrientation.Portrait;
            }

            doc.Pages.Add(page);

            XGraphics xgr = XGraphics.FromPdfPage(doc.Pages[0]); xgr.DrawImage(img, 0, 0);

            doc.Save(targetFilePath);
            doc.Close();
            img.Dispose();
        }


        public static void ExceptionOutFile(Exception appException)
        {            
            try
            {
                string tempErrorDir = Properties.Settings.Default.PathtoErrorLogFile;
                string errorLogFile = tempErrorDir.Replace("\"", "");
                
                if (File.Exists(errorLogFile))
                {
                    using (var writer = new StreamWriter(errorLogFile, true))
                    {
                        writer.WriteLine("-----------------------------------------------------------------------------");
                        writer.WriteLine("Date : " + DateTime.Now.ToString());
                        writer.WriteLine();

                        while (appException != null)
                        {
                            writer.WriteLine(appException.GetType().FullName);
                            writer.WriteLine("Message : " + appException.Message);
                            writer.WriteLine("StackTrace : " + appException.StackTrace);

                            appException = appException.InnerException;
                        }
                       
                    }
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }

  
    #endregion
}