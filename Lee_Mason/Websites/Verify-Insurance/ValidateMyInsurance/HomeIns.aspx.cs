using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Text;
using System.Net.Mail;
using System.Web.UI;
using PdfSharp;
using TheArtOfDev.HtmlRenderer.PdfSharp;

namespace ValidateMyInsurance
{
    public partial class CondoIns : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            //Get query string for insurance type and hide controls as needed

            var insType = Request.QueryString[0].ToString();

            switch (insType)
            {
                case "h":
                    FormLabel.Text = "Home Insurance";
                    txtFloodZoneCd.Visible = false;
                    txtCollateralDesc.Visible = false;
                    break;
                case "f":
                    FormLabel.Text = "Flood Insurance";
                    txtFloodZoneCd.Visible = true;
                    txtCollateralDesc.Visible = false;
                    break;
                case "c":
                    FormLabel.Text = "Condo Insurance";
                    txtFloodZoneCd.Visible = false;
                    txtCollateralDesc.Visible = false;
                    break;
                case "co":
                    FormLabel.Text = "Commercial Real Estate";
                    txtFloodZoneCd.Visible = false;
                    txtBusinessNm.Visible = true;
                    txtCollateralDesc.Visible = true;
                    txtTypeofInsurance.Visible = true;
                    break;
                case "b":
                    FormLabel.Text = "Commercial Other";
                    txtFloodZoneCd.Visible = false;
                    txtBusinessNm.Visible = true;
                    txtTypeofInsurance.Visible = true;
                    txtCollateralDesc.Visible = true;
                    lblCoverageAmt.Text = "Insurance Coverage Amount";
                    break;
                default:
                    FormLabel.Text = "Home Insurance";
                    txtFloodZoneCd.Visible = false;
                    txtCollateralDesc.Visible = false;
                    break;
            }

            //Set the Start Date to today and the End date to one year from today
            txtEffectiveStartDt.Text = DateTime.Today.ToString("yyyy-MM-dd");
            
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            try
            {


                //Extract the values entered by the user and reduce size of fields
                string policyType, firstNm, lastNm, applicantEmail, phoneNbr, mailingStreetTxt, mailingStreet2Txt, mailingStateCd, mailingCityNm, mailingZipCd, businessNm, lenderNm, lenderAcctNbr, lenderAddressTxt, premiseStreetTxt, premiseStreet2Txt, premiseCityNm, premiseStateCd, premiseZipCd
                    , insuranceCoNm, insuranceCoPhoneNbr, agentNm, agentPhoneNbr, agentAddressTxt, policyNbr, mortgageeNm, coverageAmt, commentsTxt, effectiveStartDt, effectiveEndDt, floodZoneCd, loanBinder, collateralDesc, typeofInsurance, agentPhoneNbrFormatted, phoneNbrFormatted, insuranceCoPhoneNbrFormatted;

                policyType = firstNm = lastNm = applicantEmail = phoneNbr = mailingStreetTxt = mailingStateCd = mailingCityNm = mailingZipCd = businessNm = lenderNm = lenderAcctNbr = lenderAddressTxt =
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

                bool includeBusinessNm = false;

                if (!string.IsNullOrWhiteSpace(txtFirstNm.Text)) { Utility.ReturnStringLeft(firstNm = txtFirstNm.Text, 100); }
                if (!string.IsNullOrWhiteSpace(txtLastNm.Text)) { Utility.ReturnStringLeft(lastNm = txtLastNm.Text, 100); }
                if (!string.IsNullOrWhiteSpace(txtEmail.Text)) { Utility.ReturnStringLeft(applicantEmail = txtEmail.Text, 255); }
                if (!string.IsNullOrWhiteSpace(txtPhoneNbr.Text)) { Utility.ReturnStringLeft(phoneNbr = txtPhoneNbr.Text, 15); }
                if (!string.IsNullOrWhiteSpace(txtBusinessNm.Text)) { Utility.ReturnStringLeft(businessNm = txtBusinessNm.Text, 255); }
                //Lender
                if (!string.IsNullOrWhiteSpace(txtLenderNm.Text)) { Utility.ReturnStringLeft(lenderNm = txtLenderNm.Text, 255); }
                if (!string.IsNullOrWhiteSpace(txtAccountNbr.Text)) { Utility.ReturnStringLeft(lenderAcctNbr = txtAccountNbr.Text, 255); }
                if (!string.IsNullOrWhiteSpace(txtLenderAddress.Text)) { Utility.ReturnStringLeft(lenderAddressTxt = txtLenderAddress.Text, 255); }
                //Premise
                if (!string.IsNullOrWhiteSpace(txtCollateralDesc.Text)) { Utility.ReturnStringLeft(collateralDesc = txtCollateralDesc.Text, 255); }
                if (!string.IsNullOrWhiteSpace(txtPremiseStreetTxtNm.Text)) { Utility.ReturnStringLeft(premiseStreetTxt = txtPremiseStreetTxtNm.Text, 255); }
                if (!string.IsNullOrWhiteSpace(txtPremiseStreetTxt2Nm.Text)) { Utility.ReturnStringLeft(premiseStreet2Txt = txtPremiseStreetTxt2Nm.Text, 255); }
                if (!string.IsNullOrWhiteSpace(txtPremiseCityNm.Text)) { Utility.ReturnStringLeft(premiseCityNm = txtPremiseCityNm.Text, 255); }
                if (lstPremiseStateCd.SelectedValue != "-- Please Choose One --") { Utility.ReturnStringLeft(premiseStateCd = lstPremiseStateCd.SelectedValue, 2); }
                if (!string.IsNullOrWhiteSpace(txtPremiseZipCd.Text)) { Utility.ReturnStringLeft(premiseZipCd = txtPremiseZipCd.Text, 10); }
                if (!string.IsNullOrWhiteSpace(txtFloodZoneCd.Text)) { Utility.ReturnStringLeft(floodZoneCd = txtFloodZoneCd.Text, 10); }
                //if the checkbox is checked for mailing copy user premise values
                if (ckMailingSameasPremise.Checked)
                {
                    mailingStreetTxt = premiseStreetTxt;
                    mailingStreet2Txt = premiseStreet2Txt;
                    mailingCityNm = premiseCityNm;
                    mailingZipCd = premiseZipCd;
                    mailingStateCd = premiseStateCd;
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(txtMailingStreetNm.Text)) { Utility.ReturnStringLeft(mailingStreetTxt = txtMailingStreetNm.Text, 255); }
                    if (!string.IsNullOrWhiteSpace(txtMailingStreet2Nm.Text)) { Utility.ReturnStringLeft(mailingStreet2Txt = txtMailingStreet2Nm.Text, 255); }
                    if (!string.IsNullOrWhiteSpace(txtMailingCityCd.Text)) { Utility.ReturnStringLeft(mailingCityNm = txtMailingCityCd.Text, 255); }
                    if (lstMailingStateCd.SelectedValue != "-- Please Choose One --") { Utility.ReturnStringLeft(mailingStateCd = lstMailingStateCd.SelectedValue, 2); }
                    if (!string.IsNullOrWhiteSpace(txtMailingZipCd.Text)) { Utility.ReturnStringLeft(mailingZipCd = txtMailingZipCd.Text, 10); }
                }

                //Insurance and Agent Info
                if (!string.IsNullOrWhiteSpace(txtInsuranceCoNm.Text)) { Utility.ReturnStringLeft(insuranceCoNm = txtInsuranceCoNm.Text, 255); }
                if (!string.IsNullOrWhiteSpace(txtInsuranceCoPhoneNbr.Text)) { Utility.ReturnStringLeft(insuranceCoPhoneNbr = txtInsuranceCoPhoneNbr.Text, 255); }
                if (!string.IsNullOrWhiteSpace(txtAgentNm.Text)) { Utility.ReturnStringLeft(agentNm = txtAgentNm.Text, 255); }
                if (!string.IsNullOrWhiteSpace(txtAgentAddress.Text)) { Utility.ReturnStringLeft(agentAddressTxt = txtAgentAddress.Text, 255); }
                if (!string.IsNullOrWhiteSpace(txtAgentAddress.Text)) { Utility.ReturnStringLeft(agentPhoneNbr = txtAgentPhoneNbr.Text, 255); }
                if (!string.IsNullOrWhiteSpace(txtTypeofInsurance.Text)) { Utility.ReturnStringLeft(typeofInsurance = txtTypeofInsurance.Text, 255); }

                //Policy
                if (!string.IsNullOrWhiteSpace(txtPolicyNbr.Text)) { Utility.ReturnStringLeft(policyNbr = txtPolicyNbr.Text, 255); }
                if (!string.IsNullOrWhiteSpace(txtPayeeDecPage.Text)) { Utility.ReturnStringLeft(mortgageeNm = txtPayeeDecPage.Text, 255); }
                if (!string.IsNullOrWhiteSpace(txtCoverageAmt.Text)) { Utility.ReturnStringLeft(coverageAmt = txtCoverageAmt.Text, 15); }
                if (!string.IsNullOrWhiteSpace(txtEffectiveStartDt.Text)) { Utility.ReturnStringLeft(effectiveStartDt = txtEffectiveStartDt.Text, 20); }
                //if (!string.IsNullOrWhiteSpace(txtEffectiveEndDt.Text)) { Utility.ReturnStringLeft(effectiveEndDt = txtEffectiveEndDt.Text, 20); }
                if (!string.IsNullOrWhiteSpace(txtComments.Text)) { Utility.ReturnStringLeft(commentsTxt = txtComments.Text, 1000); }
                //Radio Button
                loanBinder = rbPolicyType.SelectedValue;

                //Determine if Policy Number is not included and compare to radio buttons
                if (string.IsNullOrEmpty(policyNbr))
                {
                    if (string.IsNullOrEmpty(loanBinder))
                    {
                        txtPolicyNbr.BorderColor = System.Drawing.Color.Red;
                        return;
                    }
                    else
                    {
                        policyNbr = "Not Entered by User.";
                    }
                }
                else
                {
                    //If the value is NA then ignore the radio buttons
                    if (!string.IsNullOrEmpty(policyNbr))
                    {
                        loanBinder = "";
                    }
                }

                //format the phone numbers entered
                agentPhoneNbrFormatted = Utility.returnPhoneNbr(agentPhoneNbr);
                phoneNbrFormatted = Utility.returnPhoneNbr(phoneNbr);
                insuranceCoPhoneNbrFormatted = Utility.returnPhoneNbr(insuranceCoPhoneNbr);

                //Create body of email based on values passed in
                //StringBuilder internalEmailBody = new StringBuilder();
                StringBuilder leadEmailBody = new StringBuilder();

                var insType = Request.QueryString[0].ToString();
                var emailSubject = string.Empty;

                switch (insType)
                {
                    case "h":
                        policyType = "Hazard";
                        emailSubject = "Hazard Insurance Information";
                        break;
                    case "f":
                        policyType = "Flood";
                        emailSubject = "Flood Insurance Information";
                        break;
                    case "c":
                        policyType = "Condo";
                        emailSubject = "Condo Insurance Information";
                        break;
                    case "co":
                        policyType = "Commercial Real Estate";
                        emailSubject = "Commercial Real Estate Insurance Information";
                        includeBusinessNm = true;
                        break;
                    case "b":
                        policyType = "Commerical Other";
                        emailSubject = "Commerical Other Insurance Information";
                        includeBusinessNm = true;
                        break;
                    default:
                        policyType = "Hazard";
                        emailSubject = "Hazard Insurance Information";
                        break;
                }

                //If insurance type is not picked up then assign to Hazard
                if (!string.IsNullOrEmpty(policyType))
                {
                    policyType = "Hazard";
                    emailSubject = "Hazard Policy Insurance Information";
                }

                //Create HTML email to Lee and Mason - internal
                StringWriter writer = new StringWriter();
                string htmlString = string.Empty; //Used for conversion of HTML To email body
                using (HtmlTextWriter htmlText = new HtmlTextWriter(writer))
                {
                    htmlText.RenderBeginTag(HtmlTextWriterTag.H4);
                    htmlText.WriteEncodedText("Applicant Details:");
                    htmlText.RenderEndTag();
                    htmlText.WriteEncodedText($"First Name: {firstNm}");
                    htmlText.WriteBreak();
                    htmlText.WriteEncodedText($"Last Name: {lastNm}");
                    htmlText.WriteBreak();
                    htmlText.WriteEncodedText($"Email: {applicantEmail}");
                    htmlText.WriteBreak();
                    htmlText.WriteEncodedText($"Phone Number: {phoneNbrFormatted}");
                    htmlText.WriteBreak();
                    if (includeBusinessNm)
                    {
                        htmlText.WriteEncodedText($"Business Name: {businessNm}");
                        htmlText.WriteBreak();
                    }

                    htmlText.RenderBeginTag(HtmlTextWriterTag.H4);
                    htmlText.WriteEncodedText("Mailing Address:");
                    htmlText.RenderEndTag();
                    htmlText.WriteEncodedText($"Street Address: {mailingStreetTxt}");
                    htmlText.WriteBreak();
                    htmlText.WriteEncodedText($"Street Address 2: {mailingStreet2Txt}");
                    htmlText.WriteBreak();
                    htmlText.WriteEncodedText($"City Nm: {mailingCityNm}");
                    htmlText.WriteBreak();
                    htmlText.WriteEncodedText($"State Code: {mailingStateCd}");
                    htmlText.WriteBreak();
                    htmlText.WriteEncodedText($"Zip Code: {mailingZipCd}");
                    htmlText.WriteBreak();

                    htmlText.RenderBeginTag(HtmlTextWriterTag.H4);
                    htmlText.WriteEncodedText("Premise Address:");
                    htmlText.RenderEndTag();
                    htmlText.WriteEncodedText($"Collateral Description: {collateralDesc}");
                    htmlText.WriteBreak();
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
                    htmlText.WriteEncodedText($"Lender Address: {lenderAddressTxt}");
                    htmlText.WriteBreak();

                    htmlText.RenderBeginTag(HtmlTextWriterTag.H4);
                    htmlText.WriteEncodedText("Insurance Company Information:");
                    htmlText.RenderEndTag();
                    htmlText.WriteEncodedText($"Insurance Company Name: {insuranceCoNm}");
                    htmlText.WriteBreak();
                    htmlText.WriteEncodedText($"Insurance Company Phone Nbr: {insuranceCoPhoneNbrFormatted}");
                    htmlText.WriteBreak();
                    htmlText.WriteEncodedText($"Agent Name: {agentNm}");
                    htmlText.WriteBreak();
                    htmlText.WriteEncodedText($"Agent Address: {agentAddressTxt}");
                    htmlText.WriteBreak();
                    htmlText.WriteEncodedText($"Agent Phone Number: {agentPhoneNbrFormatted}");
                    htmlText.WriteBreak();

                    htmlText.RenderBeginTag(HtmlTextWriterTag.H4);
                    htmlText.WriteEncodedText("Policy Information:");
                    htmlText.RenderEndTag();
                    htmlText.WriteEncodedText($"Policy Type Code: {policyType}");
                    htmlText.WriteBreak();
                    htmlText.WriteEncodedText($"Policy Number: {policyNbr}");
                    htmlText.WriteBreak();
                    htmlText.WriteEncodedText($"Loan Binder/Missing Policy Number: {loanBinder}");
                    htmlText.WriteBreak();
                    htmlText.WriteEncodedText($"Agent Name: {agentNm}");
                    htmlText.WriteBreak();
                    htmlText.WriteEncodedText($"Payee Dec Page: {mortgageeNm}");
                    htmlText.WriteBreak();
                    htmlText.WriteEncodedText($"Effective Start Dt: {effectiveStartDt}");
                    htmlText.WriteBreak();
                    //htmlText.WriteEncodedText($"Effective End Dt: {effectiveEndDt}");
                    htmlText.WriteBreak();

                    if (includeBusinessNm)
                    {
                        htmlText.WriteEncodedText($"Type of Insurance: {typeofInsurance}");
                        htmlText.WriteBreak();
                    }

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
                primaryInternalEmail.Subject = string.Format(emailSubject + " from {0} {1}", firstNm, lastNm);
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
                        string emailPDFFileNm = firstNm + "_" + lastNm + "_DecPageUpload_" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".pdf";
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
                            string emailPDFFileNm = firstNm + "_" + lastNm + "_DecPageUpload_" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".pdf";
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
                leadEmailBody.Append("Thank you for the submission of your evidence of insurance.");
                leadEmailBody.AppendLine(" ");
                leadEmailBody.AppendLine(" ");
                leadEmailBody.Append("Your submission and subsequent record update will happen within two business days.  Should we have any questions regarding your submission, a representative will contact you directly.");
                leadEmailBody.AppendLine(" ");
                leadEmailBody.AppendLine(" ");
                leadEmailBody.Append("If you have any questions, please feel free to contact us with the phone number printed on the letter you received.");
                leadEmailBody.AppendLine(" ");
                leadEmailBody.AppendLine(" ");
                leadEmailBody.Append("Thank you for your assistance.");
                leadEmailBody.AppendLine(" ");
                leadEmailBody.AppendLine(" ");
                leadEmailBody.Append("Insurance Center");
                leadEmailBody.AppendLine("");
                leadEmailBody.AppendLine("");
                leadEmailBody.AppendLine("");

                //Changing to send the email from noreply@leeandmason.com - ReplyEmailAddress
                //This is the email sent to the online user thanking them for the insurance information
                MailMessage leadEmail = new MailMessage();
                leadEmail.To.Add(new MailAddress(applicantEmail, "The Lead"));
                leadEmail.From = new MailAddress(fromEmailAddress, "Insurance Center");
                leadEmail.Subject = string.Format("Evidence of Insurance Submission", policyType);
                leadEmail.Body = leadEmailBody.ToString();
                leadEmail.IsBodyHtml = false;

                //Check to see if logging the email to disk for archive
                var doLog = Properties.Settings.Default.LogtoFile;

                if (doLog)
                {
                    string tempEmailArchiveDir = Properties.Settings.Default.PathtoLogFile;
                    string emailArchiveDir = tempEmailArchiveDir.Replace("\"", "");
                    bool emailArchiveDirExists = Utility.emailArchiveDirExists(emailArchiveDir);

                    //Save as text file
                    string emailFileNm = firstNm + "_" + lastNm + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".txt";
                    string emailFileLocation = emailArchiveDir + @"\" + emailFileNm;
                    System.IO.File.WriteAllText(emailFileLocation, htmlString);

                    //Create PDF copy of the file to save on disk and to email to send in email to L&M
                    string emailPDFFileNm = firstNm + "_" + lastNm + "_" + policyType + "_" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".pdf";
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
                            string emailTempPDFFileNm = firstNm + "_" + lastNm + "_" + policyType + "_CombinedDoc_" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".pdf";
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

                //Using O365 to send email. Need to add the following code to allow the email to be sent
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                                                      | SecurityProtocolType.Tls11
                                                      | SecurityProtocolType.Tls12;
                }

                SmtpClient client = new SmtpClient
                {
                    UseDefaultCredentials = false,
                    Credentials = new System.Net.NetworkCredential(authenticateEmail, authenticateEmailPassword),
                    Port = 587,
                    Host = "smtp.office365.com",
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    EnableSsl = true
                };

                client.Send((primaryInternalEmail));
                client.Send((leadEmail));
                client.Dispose();

                //Redirect to Thank you page
                if (insType == "f")
                {
                    Response.Redirect("ThankYou.aspx?f");
                }
                else
                {
                    Response.Redirect("ThankYou.aspx?h");
                }

            }
            catch (Exception ex)
            {
                //Log the exception
                Utility.ExceptionOutFile(ex);

                //Redirect the user to the thank you page even if an error occurs
               Response.Redirect("ThankYou.aspx?h");                
            }

        }

        protected void ckMailingSameasPremise_CheckedChanged(object sender, EventArgs e)
        {
            //If checked, copy the values from mailing to property
            if (ckMailingSameasPremise.Checked)
            {
                txtPremiseStreetTxtNm.Text = txtMailingStreetNm.Text;
                txtPremiseStreetTxt2Nm.Text = txtMailingStreet2Nm.Text;
                txtPremiseCityNm.Text = txtMailingCityCd.Text;
                txtPremiseZipCd.Text = txtMailingZipCd.Text;
                lstPremiseStateCd.Text = lstMailingStateCd.SelectedValue;
            }
            else
            {

                txtPremiseStreetTxtNm.Text = "";
                txtPremiseStreetTxt2Nm.Text = "";
                txtPremiseCityNm.Text = "";
                txtPremiseZipCd.Text = "";
                lstPremiseStateCd.Text = "";
            }
        }

        protected void txtEffectiveStartDt_TextChanged(object sender, EventArgs e)
        {
            ////Preset the start and end dates for the policy by one year @522
            //DateTime startDate = Convert.ToDateTime(txtEffectiveStartDt.Text);
            //DateTime endDate = startDate.AddYears(1);

            //txtEffectiveEndDt.Text = startDate.AddYears(1).ToString("yyyy-MM-dd");
        }

   

        //protected void rbPolicyType_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(txtPolicyNbr.Text))
        //    { txtPolicyNbr.Text = "NA"; }
        //}
    }
}