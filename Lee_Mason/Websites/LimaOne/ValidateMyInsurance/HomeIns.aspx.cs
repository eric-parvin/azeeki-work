using PdfSharp;
using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;
using TheArtOfDev.HtmlRenderer.PdfSharp;
using static TheArtOfDev.HtmlRenderer.Adapters.RGraphicsPath;

namespace ValidateMyInsurance
{
    public partial class HomeIns : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

                      

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            try
            {

                //Validate that Policy Type is selected
                if (string.IsNullOrEmpty(lstInsuranceType.SelectedValue) || lstInsuranceType.SelectedValue == "-- Please Choose One --")
                {
                    Panel1.Visible = true;
                    lblFileIssues.Text = "Please select a Policy Type from the dropdown list.";
                    lblFileIssues.Visible = true;
                    return;
                }

                //Validate that State is selected
                if (string.IsNullOrEmpty(lstPremiseStateCd.SelectedValue) || lstPremiseStateCd.SelectedValue == "-- Please Choose One --")
                {
                    Panel1.Visible = true;
                    lblFileIssues.Text = "Please select a State from the dropdown list.";
                    lblFileIssues.Visible = true;
                    return;
                }

                //Extract the values entered by the user and reduce size of fields
                string policyType, applicantEmail, phoneNbr, mailingStreetTxt, mailingStreet2Txt, mailingStateCd, mailingCityNm, mailingZipCd, businessNm, lenderNm, lenderAcctNbr, lenderAddressTxt, premiseStreetTxt, premiseStreet2Txt, premiseCityNm, premiseStateCd, premiseZipCd
                    , insuranceCoNm, insuranceCoPhoneNbr, agentNm, agentPhoneNbr, agentAddressTxt, policyNbr, mortgageeNm, coverageAmt, commentsTxt, effectiveStartDt, effectiveEndDt, floodZoneCd, loanBinder, collateralDesc, typeofInsurance, agentPhoneNbrFormatted, phoneNbrFormatted, insuranceCoPhoneNbrFormatted;

                policyType = applicantEmail = phoneNbr = mailingStreetTxt = mailingStateCd = mailingCityNm = mailingZipCd = businessNm = lenderNm = lenderAcctNbr = lenderAddressTxt =
                premiseStreetTxt = premiseCityNm = premiseStateCd = premiseZipCd = insuranceCoNm = insuranceCoPhoneNbr = agentNm = agentPhoneNbr = agentAddressTxt = policyNbr =
                mortgageeNm = coverageAmt = commentsTxt = effectiveStartDt = effectiveEndDt = floodZoneCd = loanBinder = collateralDesc = typeofInsurance = premiseStreet2Txt = mailingStreet2Txt = phoneNbrFormatted = agentPhoneNbrFormatted = insuranceCoPhoneNbrFormatted = string.Empty;

                bool isPDFAttachment = false; //Tracks if the attachment from the user is a PDF
                string policyDefFileNm = null; //Holder for the document upload from the user
                string tempPDFAttachment = null; //Temp location for the PDF attachment from the user
                bool isConvertToPDF = false; //Determine if the file extension is one to convert to PDF

                //Check file size first
                if (FileUpload1.HasFile)
                {
                    bool fileExceedsLimit = Utility.checkFileSize(FileUpload1.PostedFile.ContentLength);

                    if (fileExceedsLimit == true)
                    {
                        Panel1.Visible = true;
                        lblFileIssues.Visible = true;
                        return;
                    }

                    //Check file extenstion
                    string fileExt = Path.GetExtension(FileUpload1.FileName);

                    bool legitExtention = Utility.checkFileExtention(fileExt);

                    if (legitExtention == false)
                    {
                        Panel1.Visible = true;
                        lblFileIssues.Text =
                            "The file extension uploaded to the this form is not supported. The supported types are .pdf, .jpeg, .jpg, .png, .doc, .docx, tif, and gif";
                        lblFileIssues.Visible = true;
                        return;
                    }                
                }
                else //file is missing
{
                    Panel1.Visible = true;
                    lblFileIssues.Text = "No file was uploaded. Please upload a document that serves as your evidence of insurance.";
                    lblFileIssues.Visible = true;
                    return;
                }

                //Policy Type
                if (lstInsuranceType.SelectedValue != "-- Please Choose One --") { Utility.ReturnStringLeft(policyType = lstInsuranceType.SelectedValue, 4); }

                if (!string.IsNullOrWhiteSpace(txtEmail.Text)) { Utility.ReturnStringLeft(applicantEmail = txtEmail.Text, 255); }
                if (!string.IsNullOrWhiteSpace(txtPhoneNbr.Text)) { Utility.ReturnStringLeft(phoneNbr = txtPhoneNbr.Text, 15); }
                if (!string.IsNullOrWhiteSpace(txtBusinessNm.Text)) { Utility.ReturnStringLeft(businessNm = txtBusinessNm.Text, 255); }
                //Lender
                if (!string.IsNullOrWhiteSpace(txtLenderNm.Text)) { Utility.ReturnStringLeft(lenderNm = txtLenderNm.Text, 255); }
                if (!string.IsNullOrWhiteSpace(txtAccountNbr.Text)) { Utility.ReturnStringLeft(lenderAcctNbr = txtAccountNbr.Text, 255); }
                
                //Premise
                
                if (!string.IsNullOrWhiteSpace(txtPremiseStreetTxtNm.Text)) { Utility.ReturnStringLeft(premiseStreetTxt = txtPremiseStreetTxtNm.Text, 255); }
                if (!string.IsNullOrWhiteSpace(txtPremiseStreetTxt2Nm.Text)) { Utility.ReturnStringLeft(premiseStreet2Txt = txtPremiseStreetTxt2Nm.Text, 255); }
                if (!string.IsNullOrWhiteSpace(txtPremiseCityNm.Text)) { Utility.ReturnStringLeft(premiseCityNm = txtPremiseCityNm.Text, 255); }
                if (lstPremiseStateCd.SelectedValue != "-- Please Choose One --") { Utility.ReturnStringLeft(premiseStateCd = lstPremiseStateCd.SelectedValue, 2); }
                if (!string.IsNullOrWhiteSpace(txtPremiseZipCd.Text)) { Utility.ReturnStringLeft(premiseZipCd = txtPremiseZipCd.Text, 10); }
                
                
                //if (!string.IsNullOrWhiteSpace(txtEffectiveEndDt.Text)) { Utility.ReturnStringLeft(effectiveEndDt = txtEffectiveEndDt.Text, 20); }
                if (!string.IsNullOrWhiteSpace(txtComments.Text)) { Utility.ReturnStringLeft(commentsTxt = txtComments.Text, 1000); }

                phoneNbrFormatted = Utility.returnPhoneNbr(phoneNbr);

                //Create single line premise address for email
                string premiseFullAddress = string.Empty;
                if (!string.IsNullOrWhiteSpace(premiseStreetTxt))
                {
                    premiseFullAddress = premiseStreetTxt;

                    if (!string.IsNullOrWhiteSpace(premiseStreet2Txt))
                    {
                        premiseFullAddress += ", " + premiseStreet2Txt;
                    }

                    if (!string.IsNullOrWhiteSpace(premiseCityNm))
                    {
                        premiseFullAddress += ", " + premiseCityNm;
                    }

                    if (!string.IsNullOrWhiteSpace(premiseStateCd))
                    {
                        premiseFullAddress += ", " + premiseStateCd;
                    }

                    if (!string.IsNullOrWhiteSpace(premiseZipCd))
                    {
                        premiseFullAddress += " " + premiseZipCd;
                    }
                }

                //Create body of email based on values passed in
                //StringBuilder internalEmailBody = new StringBuilder();
                StringBuilder leadEmailBody = new StringBuilder();

                 var emailSubject = string.Empty;

                switch (policyType.ToLower())
                {
                    case "hi":
                        policyType = "Hazard Insurance";
                        emailSubject = "Hazard Insurance Information";
                        break;
                    case "fi":
                        policyType = "Flood Insurance";
                        emailSubject = "Flood Insurance Information";
                        break;
                    case "cahi":
                        policyType = "Condo Association Hazard Insurance";
                        emailSubject = "Condo Association Hazard Insurance";
                        break;
                    case "cafi":
                        policyType = "Condo Association Flood Insurance";
                        emailSubject = "Condo Association Flood Insurance";
                        break;
                    case "uohi":
                        policyType = "Unit Owner Hazard Insurance";
                        emailSubject = "Unit Owner Hazard Insurance Information";

                        break;
                    case "wi":
                        policyType = "Wind Insurance";
                        emailSubject = "Wind Insurance Information";
                        break;
                    case "li":
                        policyType = "Liability Insurance";
                        emailSubject = "Liability Insurance Information";
                        break;
                    case "bri":
                        policyType = "Builders Risk Insurance";
                        emailSubject = "Builders Risk Insurance Information";
                        break;
                    default:
                        policyType = "Hazard Insurance";
                        emailSubject = "Hazard Insurance Information";
                        break;
                }


                //Create HTML email to Lee and Mason - internal
                StringWriter writer = new StringWriter();
                string htmlString = string.Empty; //Used for conversion of HTML To email body
                using (HtmlTextWriter htmlText = new HtmlTextWriter(writer))
                {
                    htmlText.RenderBeginTag(HtmlTextWriterTag.H4);
                    htmlText.WriteEncodedText("Applicant Details:");
                    htmlText.RenderEndTag();
                    htmlText.WriteEncodedText($"LLC Name: {businessNm}");
                    htmlText.WriteBreak();                   
                    htmlText.WriteEncodedText($"Email: {applicantEmail}");
                    htmlText.WriteBreak();
                    htmlText.WriteEncodedText($"Phone Number: {phoneNbrFormatted}");
                    htmlText.WriteBreak();

                    htmlText.RenderBeginTag(HtmlTextWriterTag.H4);
                    htmlText.WriteEncodedText("Premise Address:");
                    htmlText.RenderEndTag();
                    
                    htmlText.WriteEncodedText($"Street Address: {premiseStreetTxt}");
                    htmlText.WriteBreak();
                    htmlText.WriteEncodedText($"Street Address 2: {premiseStreet2Txt}");
                    htmlText.WriteBreak();
                    htmlText.WriteEncodedText($"City Nm: {premiseCityNm}");
                    htmlText.WriteBreak();
                    htmlText.WriteEncodedText($"State Code: {premiseStateCd}");
                    htmlText.WriteBreak();
                    htmlText.WriteEncodedText($"Zip Code: {premiseZipCd}");
                    htmlText.WriteBreak();

                    htmlText.RenderBeginTag(HtmlTextWriterTag.H4);
                    htmlText.WriteEncodedText("Lender Information:");
                    htmlText.RenderEndTag();
                    htmlText.WriteEncodedText($"Lender Name: {lenderNm}");
                    htmlText.WriteBreak();
                    htmlText.WriteEncodedText($"Lender Account Nbr: {lenderAcctNbr}");
                    htmlText.WriteBreak();

                    htmlText.RenderBeginTag(HtmlTextWriterTag.H4);
                    htmlText.WriteEncodedText("Policy Information:");
                    htmlText.RenderEndTag();
                    htmlText.WriteEncodedText($"Policy Type Code: {policyType}");
                    htmlText.WriteBreak();

                    htmlText.WriteBreak();

                    htmlText.WriteEncodedText($"Comments: {commentsTxt}");
                    htmlText.WriteBreak();

                    //End of Email with extra line break to account for email signature
                    htmlText.WriteBreak();
                    htmlText.Flush();

                    htmlString = writer.ToString();
                }

                //Decided to add email code to each page instead of central class due to the translation of the attachment for the email

                //Obtain Internal email addresses and Email authentication settings
                string toPrimaryEmail = Properties.Settings.Default.ToPrimaryEmail;
                string toSecondaryEmail = Properties.Settings.Default.ToSecondaryEmail;
                string authenticateEmailPassword = Properties.Settings.Default.EmailAccountPassword;
                string authenticateEmail = Properties.Settings.Default.AuthenticateEmail;
                string fromEmailAddress = Properties.Settings.Default.FromEmailAddress; //The email address to generate email to user that entered info
                bool sendToSecondary = string.IsNullOrEmpty(toSecondaryEmail); //Determine to add secondary email

                //Generate email to internal resource for the insurance lead - To Lee and Mason
                MailMessage primaryInternalEmail = new MailMessage();
                primaryInternalEmail.To.Add(new MailAddress(toPrimaryEmail, "Insurance Center"));
                primaryInternalEmail.From = new MailAddress(authenticateEmail, "Insurance Center");
                primaryInternalEmail.Subject = string.Format("{0} from {1}", emailSubject, businessNm);
                primaryInternalEmail.Body = htmlString;
                primaryInternalEmail.IsBodyHtml = true;

                if (!sendToSecondary)
                {
                    primaryInternalEmail.CC.Add(new MailAddress(toSecondaryEmail, "Insurance Center"));
                }

                //Policy Dec file attachment
                if (FileUpload1.HasFile)
                {
                    //Determine if the attachment is a PDF and combine with the PDF created with the data entry. Otherwise, attach the uploaded file by the user and convert the approved formats to PDF. Can't convert Word
                    string fileExtension = Path.GetExtension(FileUpload1.FileName);
                    string fileExtensionLower = fileExtension.ToLower();

                    //Obtain the uploaded file name from the user
                    policyDefFileNm = System.IO.Path.GetFileName(FileUpload1.PostedFile.FileName);

                    if (fileExtensionLower == ".pdf")
                    {
                        isPDFAttachment = true;

                        string tempEmailArchiveDir = Properties.Settings.Default.PathtoLogFile;
                        string pdfArchiveDir = tempEmailArchiveDir.Replace("\"", "");

                        //Create PDF copy of the file to save on disk and use in the merge of PDF documents
                        string emailPDFFileNm = businessNm + "_DecPageUpload_" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".pdf";
                        tempPDFAttachment = pdfArchiveDir + @"\" + emailPDFFileNm;

                        //Save file off to temp location on the server
                        FileUpload1.SaveAs(tempPDFAttachment);
                    }
                    else //Handle Non-PDF uploaded images
                    {
                        //Determine if this is one of the extensions to convert to PDF
                        isConvertToPDF = Utility.extensionToConvert(fileExtensionLower);

                        //Attach the uploaded file from the user
                        Attachment policyAttachment = new Attachment(FileUpload1.PostedFile.InputStream, policyDefFileNm);
                        primaryInternalEmail.Attachments.Add(policyAttachment);

                        if (isConvertToPDF == true) //Attach to email if not converting to PDF
                        {
                            string tempEmailArchiveDir = Properties.Settings.Default.PathtoLogFile;
                            string pdfArchiveDir = tempEmailArchiveDir.Replace("\"", ""); //Destination PDF file after the conversion to PDF
                                                                                          //string tempFileUploadLocation = tempEmailArchiveDir.Replace("\"", ""); //File from user saved to temp location
                            string tempOrigUserAttachment = pdfArchiveDir + @"\" + policyDefFileNm;

                            //Create location for the target PDF to be created
                            string emailPDFFileNm = businessNm + "_DecPageUpload_" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".pdf";
                            tempPDFAttachment = pdfArchiveDir + @"\" + emailPDFFileNm;

                            //Save the uploaded file from the user to the temp dir and use for the conversion
                            FileUpload1.SaveAs(tempOrigUserAttachment);

                            //Convert the image to a PDF
                            Utility.ConvertToPDF(tempPDFAttachment, tempOrigUserAttachment);

                            isPDFAttachment = true; //Set to true so it is combined with the PDF with the inputted information from the user
                        }
                    }
                }

                //Generate Thank you Response email to user submitting data
                leadEmailBody.Append("Thank you for submitting your evidence of insurance for the collateral below.");
                leadEmailBody.Append("<br><br>");
                leadEmailBody.Append($"Insurance Type: {policyType}");
                leadEmailBody.Append("<br><br>");
                leadEmailBody.Append($"Property: {premiseFullAddress}");
                leadEmailBody.Append("<br><br>");
                leadEmailBody.Append("Your submission will be processed within two business days.");
                leadEmailBody.Append("<br><br>");
                leadEmailBody.Append("Thank you for your assistance.");
                leadEmailBody.Append("<br><br>");
                leadEmailBody.Append("Insurance Center");
                leadEmailBody.Append("<br><br>");

                leadEmailBody.Append("<div style='font-size: 9pt;'>");
                leadEmailBody.Append("Disclaimer: Your insurance submission is handled by an independent third party service provider. Lima One Capital is not directly notified of submission completion or status updates and will only be contacted in the event that a discrepancy, error, or clarification is required.");
                leadEmailBody.Append("</div>");

                //Changing to send the email from noreply@leeandmason.com - ReplyEmailAddress
                //This is the email sent to the online user thanking them for the insurance information
                MailMessage leadEmail = new MailMessage();
                leadEmail.To.Add(new MailAddress(applicantEmail, "The Lead"));
                leadEmail.From = new MailAddress(fromEmailAddress, "Insurance Center");
                leadEmail.Subject = "Evidence of Insurance Submission";
                leadEmail.Body = leadEmailBody.ToString();
                leadEmail.IsBodyHtml = true;

                //Check to see if logging the email to disk for archive
                var doLog = Properties.Settings.Default.LogtoFile;

                if (doLog)
                {
                    string tempEmailArchiveDir = Properties.Settings.Default.PathtoLogFile;
                    string emailArchiveDir = tempEmailArchiveDir.Replace("\"", "");
                    bool emailArchiveDirExists = Utility.emailArchiveDirExists(emailArchiveDir);

                    //Save as text file
                    string emailFileNm =  businessNm + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".txt";
                    string emailFileLocation = emailArchiveDir + @"\" + emailFileNm;
                    System.IO.File.WriteAllText(emailFileLocation, htmlString);

                    //Create PDF copy of the file to save on disk and to email to send in email to L&M
                    string emailPDFFileNm = businessNm + "_" + policyType + "_" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".pdf";
                    string emailPDFFileLocation = emailArchiveDir + @"\" + emailPDFFileNm;

                    PdfGenerateConfig config = new PdfGenerateConfig();
                    config.PageSize = PageSize.A4;
                    config.SetMargins(20);

                    var doc = PdfGenerator.GeneratePdf(htmlString, config, null);
                    doc.Save(emailPDFFileLocation);

                    //Add as an attachment to the email if the Policy Dec is not a PDF. Otherwise, combine PDFs                
                    if (isPDFAttachment == false)
                    {
                        Attachment pdfAttachment = new Attachment(emailPDFFileLocation);
                        primaryInternalEmail.Attachments.Add(pdfAttachment);
                    }
                    else
                    {
                        //Combine PDFs into 1 PDF document
                        if (policyDefFileNm != null)
                        {

                            //Combine the PDFs
                            string emailTempPDFFileNm = businessNm + "_" + policyType + "_CombinedDoc_" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".pdf";
                            string emailMergePDFFile = emailArchiveDir + @"\" + emailTempPDFFileNm;

                            //Merge the attachments
                            bool mergedDocs;
                            mergedDocs = Utility.MergePDFs(emailMergePDFFile, emailPDFFileLocation, tempPDFAttachment);

                            //Attach to email the merged PDF doc if succesful
                            if (mergedDocs == true)
                            {
                                Attachment pdfAttachment = new Attachment(emailMergePDFFile);
                                primaryInternalEmail.Attachments.Add(pdfAttachment);
                            }
                            else
                            {
                                //The PDF merge operation failed and need to add each attachment as seperate documents
                                Attachment pdfEmailAttachment = new Attachment(emailPDFFileLocation);
                                Attachment pdfDecPageAttachment = new Attachment(tempPDFAttachment);
                                primaryInternalEmail.Attachments.Add(pdfEmailAttachment);
                                primaryInternalEmail.Attachments.Add(pdfDecPageAttachment);

                            }
                        }
                    }

                }
                //Switch to internal SMTP server if setting is selected, otherwise use Office365 with credentials
                bool useInternalSMTP = Properties.Settings.Default.UseInternalSMTP;
                SmtpClient client;

                if (useInternalSMTP)
                {
                    client = new SmtpClient();
                }
                else
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                                                          | SecurityProtocolType.Tls11
                                                          | SecurityProtocolType.Tls12;

                    client = new SmtpClient
                    {
                        UseDefaultCredentials = false,
                        Credentials = new System.Net.NetworkCredential(authenticateEmail, authenticateEmailPassword),
                        Port = 587,
                        Host = "smtp.office365.com",
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        EnableSsl = true
                    };
                }

                client.Send((primaryInternalEmail));
                client.Send((leadEmail));
                client.Dispose();

                //Redirect to Thank you page

                                      
                Response.Redirect("ThankYou.aspx?h");
                

            }
            catch (Exception ex)
            {
                //Log the exception
                Utility.ExceptionOutFile(ex);

                //Redirect the user to the thank you page even if an error occurs
                Response.Redirect("ThankYou.aspx?h");
            }

        }


    }
}