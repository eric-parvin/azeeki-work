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

                //Extract the values entered by the user and reduce size of fields
                string policyType, applicantEmail, phoneNbr, businessNm, lenderNm, lenderAcctNbr, lenderAddressTxt, premiseStreetTxt, premiseStreet2Txt, premiseCityNm, premiseStateCd, premiseZipCd
                    , insuranceCoNm, insuranceCoPhoneNbr, agentNm, agentPhoneNbr, agentAddressTxt, policyNbr, mortgageeNm, coverageAmt, commentsTxt, loanBinder, collateralDesc, typeofInsurance, agentPhoneNbrFormatted, phoneNbrFormatted, agentEmailAddr,agentFaxNbr, insuranceCoPhoneNbrFormatted;

                policyType =  applicantEmail = phoneNbr =  businessNm = lenderNm = lenderAcctNbr = lenderAddressTxt =
                premiseStreetTxt = premiseCityNm = premiseStateCd = premiseZipCd = insuranceCoNm = insuranceCoPhoneNbr = agentNm = agentPhoneNbr = agentAddressTxt = policyNbr = agentEmailAddr = agentFaxNbr =
                mortgageeNm = coverageAmt = commentsTxt = loanBinder = collateralDesc = typeofInsurance = premiseStreet2Txt = phoneNbrFormatted = agentPhoneNbrFormatted = insuranceCoPhoneNbrFormatted = string.Empty;

                bool isPDFAttachment = false; //Tracks if the attachment from the user is a PDF
                string policyDefFileNm = null; //Holder for the document upload from the user
                string tempPDFAttachment = null; //Temp location for the PDF attachment from the user
                bool isConvertToPDF = false; //Determine if the file extension is one to convert to PDF


                //Policy Type
                if (!string.IsNullOrWhiteSpace(lstInsuranceType.SelectedValue)) { Utility.ReturnStringLeft(policyType = lstInsuranceType.SelectedValue, 4); }

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
                

                //Insurance and Agent Info
                
                if (!string.IsNullOrWhiteSpace(txtAgentNm.Text)) { Utility.ReturnStringLeft(agentNm = txtAgentNm.Text, 255); }
                if (!string.IsNullOrWhiteSpace(txtAgentEmail.Text)) { Utility.ReturnStringLeft(agentEmailAddr = txtAgentEmail.Text, 255); }
                if (!string.IsNullOrWhiteSpace(txtAgentFax.Text)) { Utility.ReturnStringLeft(agentFaxNbr = txtAgentFax.Text, 255); }

                //Policy
                if (!string.IsNullOrWhiteSpace(txtPolicyNbr.Text)) { Utility.ReturnStringLeft(policyNbr = txtPolicyNbr.Text, 255); }
                if (!string.IsNullOrWhiteSpace(txtComments.Text)) { Utility.ReturnStringLeft(commentsTxt = txtComments.Text, 1000); }
                
                //Determine if Policy Number is not included and compare to radio buttons
                if (string.IsNullOrEmpty(policyNbr))
                {
                  policyNbr = "Not Entered by User.";
                    
                }                

                //format the phone numbers entered
                agentPhoneNbrFormatted = Utility.returnPhoneNbr(agentPhoneNbr);
                phoneNbrFormatted = Utility.returnPhoneNbr(agentFaxNbr);
                insuranceCoPhoneNbrFormatted = Utility.returnPhoneNbr(insuranceCoPhoneNbr);


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
                    
                    htmlText.RenderBeginTag(HtmlTextWriterTag.H4);
                    htmlText.WriteEncodedText("Insurance Company Information:");
                    htmlText.RenderEndTag();
                    htmlText.WriteEncodedText($"Insurance Company Name: {insuranceCoNm}");
                    htmlText.WriteBreak();
                    htmlText.WriteEncodedText($"Agent Name: {agentNm}");
                    htmlText.WriteBreak();
                    htmlText.WriteEncodedText($"Agent Phone Number: {agentPhoneNbrFormatted}");
                    htmlText.WriteBreak();
                    htmlText.WriteEncodedText($"Agent Fax Number: {phoneNbrFormatted}");
                    htmlText.WriteBreak();
                    htmlText.WriteEncodedText($"Agent Email: {agentEmailAddr}");
                    htmlText.WriteBreak();

                    htmlText.RenderBeginTag(HtmlTextWriterTag.H4);
                    htmlText.WriteEncodedText("Policy Information:");
                    htmlText.RenderEndTag();
                    htmlText.WriteEncodedText($"Policy Type Code: {policyType}");
                    htmlText.WriteBreak();
                    htmlText.WriteEncodedText($"Policy Number: {policyNbr}");
                    htmlText.WriteBreak();
                    htmlText.WriteEncodedText($"Agent Name: {agentNm}");
                    htmlText.WriteBreak();
               
                    //htmlText.WriteEncodedText($"Effective End Dt: {effectiveEndDt}");
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


                //Generate Thank you Response email to user submitting data
                leadEmailBody.Append("Thank you for submitting your evidence of insurance for the collateral below.");
                leadEmailBody.Append("<br><br>");
                leadEmailBody.Append($"Insurance Type: {policyType}");
                leadEmailBody.Append("<br><br>");
                leadEmailBody.Append($"Property: {premiseFullAddress}");
                leadEmailBody.Append("<br><br>");
                leadEmailBody.Append("We will contact your agent within two business days and update your record accordingly.");
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
                leadEmail.Subject = string.Format("Evidence of Insurance Submission", policyType);
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
                    string emailFileNm = businessNm + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".txt";
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

                }
                //Switch to internal SMTP server if setting is selected, otherwise use Office365 with credentials
                bool useInternalSMTP = Properties.Settings.Default.UseInternalSMTP;
                SmtpClient client;

                try
                {
                    // Log email attempt
                    System.Diagnostics.Debug.WriteLine($"[EMAIL DEBUG] UseInternalSMTP={useInternalSMTP}");
                    System.Diagnostics.Debug.WriteLine($"[EMAIL DEBUG] FromAddress={fromEmailAddress}");
                    System.Diagnostics.Debug.WriteLine($"[EMAIL DEBUG] ToAddress={toPrimaryEmail}");
                    System.Diagnostics.Debug.WriteLine($"[EMAIL DEBUG] ApplicantEmail={applicantEmail}");

                    if (useInternalSMTP)
                    {
                        System.Diagnostics.Debug.WriteLine("[EMAIL DEBUG] Using Internal SMTP from Web.config");
                        client = new SmtpClient();
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine($"[EMAIL DEBUG] Using O365 SMTP - Host: smtp.office365.com, Port: 587");
                        System.Diagnostics.Debug.WriteLine($"[EMAIL DEBUG] Authenticating as: {authenticateEmail}");

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

                    System.Diagnostics.Debug.WriteLine("[EMAIL DEBUG] Sending internal email...");
                    client.Send((primaryInternalEmail));
                    System.Diagnostics.Debug.WriteLine("[EMAIL DEBUG] Internal email sent successfully");

                    System.Diagnostics.Debug.WriteLine("[EMAIL DEBUG] Sending user confirmation email...");
                    client.Send((leadEmail));
                    System.Diagnostics.Debug.WriteLine("[EMAIL DEBUG] User confirmation email sent successfully");

                    client.Dispose();
                }
                catch (SmtpException smtpEx)
                {
                    // Log SMTP-specific errors
                    string smtpError = $"[SMTP ERROR] StatusCode: {smtpEx.StatusCode}, Message: {smtpEx.Message}, InnerException: {smtpEx.InnerException?.Message}";
                    System.Diagnostics.Debug.WriteLine(smtpError);
                    System.IO.File.AppendAllText(@"C:\ValidateInsuranceTempFiles\Error\EmailDebug.txt", 
                        $"{DateTime.Now}: {smtpError}{Environment.NewLine}");
                    throw; // Re-throw to be caught by outer catch
                }

                //Redirect to Thank you page
                 Response.Redirect("ThankYou.aspx?f");


            }
            catch (Exception ex)
            {
                //Log the exception with more detail
                string errorDetails = $"{DateTime.Now}: Exception Type: {ex.GetType().Name}, Message: {ex.Message}, StackTrace: {ex.StackTrace}";
                System.Diagnostics.Debug.WriteLine($"[ERROR] {errorDetails}");

                Utility.ExceptionOutFile(ex);

                //Redirect the user to the thank you page even if an error occurs
               Response.Redirect("ThankYou.aspx?h");                
            }

        }

 

       
    }
}