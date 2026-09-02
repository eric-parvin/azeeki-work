<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Policy.aspx.cs" Inherits="ValidateMyInsurance.CondoIns" %>

    <!DOCTYPE html>
    <html lang="en">

    <head>
        <meta charset="utf-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <title>Validate My Insurance - Home Insurance</title>
        <link href="css/bootstrap.min.css" rel="stylesheet">
        <link href="css/custom.css" rel="stylesheet">
        <link href="css/font-awesome.min.css" rel="stylesheet">

        <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
    </head>

    <body>

<header>
<div class="container text-center">
        <div class="row">
        <div class="col-md-2 col-md-offset-2 col-sm-6 col-xs-5"> <img src="images/lima-one-logo.png" class="img-responsive"></div>
        <div class="col-md-3 col-sm-6 col-xs-7"><a href="Landing.aspx"> <img src="images/logo.png" alt="ValidateMyInsurance.com" class="logo img-responsive center-block">  </a>
  </div>
</div>     
</div>
</header>
        <!--  END HEADER -->

        <section>
            <div class="container">
                <div class="row">
                    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">

                        <form class="form-horizontal" id="formHomeIns" accept-charset="UTF-8" method="post"
                            runat="server">

                            <h1 class="text-primary">
                                <asp:Label ID="FormLabel" runat="server" Text="Label" Visible="False"></asp:Label>
                            </h1>

                            <p>Account Information (as it appears on the Insurance Notice). Fields marked with an &#42;
                                are required.</p>

                            <asp:Panel ID="Panel1" runat="server" Visible="false">
                                <div class="clearfix">
                                    <div class="col-lg-4 col-md-4 col-sm-12 col-xs-12 alert alert-danger alert-dismissible fade in"
                                        role="alert">
                                        <button type="button" class="close" data-dismiss="alert" aria-label="Close"
                                            name="FileWarning">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                        <asp:Label ID="lblFileIssues" runat="server"
                                            Text="File size must not exceed 4MB" CssClass="container text-center"
                                            Visible="True" Font-Bold="True"></asp:Label>
                                    </div>
                                </div>
                            </asp:Panel>

                            <!--  Validation Summary -->

                            <fieldset>
                                <legend>YOUR INFORMATION</legend>

                                <!-- ----------- YOUR INFORMATION ------------------ -->

                                <div class="form-group">
                                    <div class="col-md-12 col-sm-12 col-xs-12">
                                        <asp:TextBox ID="txtBusinessNm" CssClass="form-control input-md" MaxLength="255"
                                            placeholder="LLC Name*" required runat="server" Visible="True">
                                        </asp:TextBox>
                                    </div>
                                </div>

                                <hr class="formrule">

                                <div class="form-group">
                                    <div class="col-md-4 col-sm-4 col-xs-12">
                                        <asp:TextBox ID="txtEmail" CssClass="form-control input-md" MaxLength="255"
                                            placeholder="Email Address*" required runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-md-5 col-sm-5 col-xs-12">
                                        <asp:TextBox ID="txtPhoneNbr" CssClass="form-control input-md" MaxLength="15"
                                            TextMode="Number" placeholder="Contact Phone Number" 
                                            runat="server"></asp:TextBox>
                                    </div>


                                    <div class="form-group">
                                        <div class="col-md-3 col-sm-3 col-xs-12">
                                            <p class="small">We will send an automatic confirmation of receipt to the
                                                email address provided. This will not be used for solicitation purposes.
                                            </p>
                                        </div>
                                    </div>
                                </div>
                                <hr class="formrule clearfix">
                            </fieldset>

                            <!-- ----------- LENDER INFORMATION ------------------ -->
                            <fieldset>
                                <legend>LENDER INFORMATION</legend>

                                <div class="form-group">
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <asp:TextBox ID="txtLenderNm" CssClass="form-control input-md" MaxLength="255"
                                            placeholder="Name of Lender" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <asp:TextBox ID="txtAccountNbr" CssClass="form-control input-md" MaxLength="255"
                                            placeholder="Account Number" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </fieldset>

                            <!-- ----------- PROPERTY INFORMATION ------------------ -->
                            <fieldset>
                                <legend>PROPERTY and INSURANCE INFORMATION</legend>

                                <div class="form-group">
                                    <div class="col-md-12 col-sm-12 col-xs-12">
                                        <asp:TextBox ID="txtPremiseStreetTxtNm" CssClass="form-control input-md"
                                            MaxLength="255" placeholder="Street Address*" required runat="server">
                                        </asp:TextBox>
                                    </div>
                                </div>

                                <div class="form-group">
                                    <div class="col-md-12 col-sm-12 col-xs-12">
                                        <asp:TextBox ID="txtPremiseStreetTxt2Nm" CssClass="form-control input-md"
                                            MaxLength="255" placeholder="Street Address 2 (such as Unit Number)"
                                            runat="server"></asp:TextBox>
                                    </div>
                                </div>

                                <div class="form-group">
                                    <div class="col-md-5 col-sm-4 col-xs-12">
                                        <asp:TextBox ID="txtPremiseCityNm" CssClass="form-control input-md"
                                            MaxLength="255" placeholder="City*" required runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-md-4 col-sm-5 col-xs-12">
                                        <asp:DropDownList ID="lstPremiseStateCd" CssClass="form-control" required runat="server">
                                            <asp:ListItem Value="">-- State (Please Choose One) * --
                                            </asp:ListItem>
                                            <asp:ListItem Value="AL">Alabama</asp:ListItem>
                                            <asp:ListItem Value="AK">Alaska</asp:ListItem>
                                            <asp:ListItem Value="AZ">Arizona</asp:ListItem>
                                            <asp:ListItem Value="AR">Arkansas</asp:ListItem>
                                            <asp:ListItem Value="CA">California</asp:ListItem>
                                            <asp:ListItem Value="CO">Colorado</asp:ListItem>
                                            <asp:ListItem Value="CT">Connecticut</asp:ListItem>
                                            <asp:ListItem Value="DE">Delaware</asp:ListItem>
                                            <asp:ListItem Value="DC">District Of Columbia</asp:ListItem>
                                            <asp:ListItem Value="FL">Florida</asp:ListItem>
                                            <asp:ListItem Value="GA">Georgia</asp:ListItem>
                                            <asp:ListItem Value="HI">Hawaii</asp:ListItem>
                                            <asp:ListItem Value="ID">Idaho</asp:ListItem>
                                            <asp:ListItem Value="IL">Illinois</asp:ListItem>
                                            <asp:ListItem Value="IN">Indiana</asp:ListItem>
                                            <asp:ListItem Value="IA">Iowa</asp:ListItem>
                                            <asp:ListItem Value="KS">Kansas</asp:ListItem>
                                            <asp:ListItem Value="KY">Kentucky</asp:ListItem>
                                            <asp:ListItem Value="LA">Louisiana</asp:ListItem>
                                            <asp:ListItem Value="ME">Maine</asp:ListItem>
                                            <asp:ListItem Value="MD">Maryland</asp:ListItem>
                                            <asp:ListItem Value="MA">Massachusetts</asp:ListItem>
                                            <asp:ListItem Value="MI">Michigan</asp:ListItem>
                                            <asp:ListItem Value="MN">Minnesota</asp:ListItem>
                                            <asp:ListItem Value="MS">Mississippi</asp:ListItem>
                                            <asp:ListItem Value="MO">Missouri</asp:ListItem>
                                            <asp:ListItem Value="MT">Montana</asp:ListItem>
                                            <asp:ListItem Value="NE">Nebraska</asp:ListItem>
                                            <asp:ListItem Value="NV">Nevada</asp:ListItem>
                                            <asp:ListItem Value="NH">New Hampshire</asp:ListItem>
                                            <asp:ListItem Value="NJ">New Jersey</asp:ListItem>
                                            <asp:ListItem Value="NM">New Mexico</asp:ListItem>
                                            <asp:ListItem Value="NY">New York</asp:ListItem>
                                            <asp:ListItem Value="NC">North Carolina</asp:ListItem>
                                            <asp:ListItem Value="ND">North Dakota</asp:ListItem>
                                            <asp:ListItem Value="OH">Ohio</asp:ListItem>
                                            <asp:ListItem Value="OK">Oklahoma</asp:ListItem>
                                            <asp:ListItem Value="OR">Oregon</asp:ListItem>
                                            <asp:ListItem Value="PA">Pennsylvania</asp:ListItem>
                                            <asp:ListItem Value="RI">Rhode Island</asp:ListItem>
                                            <asp:ListItem Value="SC">South Carolina</asp:ListItem>
                                            <asp:ListItem Value="SD">South Dakota</asp:ListItem>
                                            <asp:ListItem Value="TN">Tennessee</asp:ListItem>
                                            <asp:ListItem Value="TX">Texas</asp:ListItem>
                                            <asp:ListItem Value="UT">Utah</asp:ListItem>
                                            <asp:ListItem Value="VT">Vermont</asp:ListItem>
                                            <asp:ListItem Value="VA">Virginia</asp:ListItem>
                                            <asp:ListItem Value="WA">Washington</asp:ListItem>
                                            <asp:ListItem Value="WV">West Virginia</asp:ListItem>
                                            <asp:ListItem Value="WI">Wisconsin</asp:ListItem>
                                            <asp:ListItem Value="WY">Wyoming</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="col-md-3 col-sm-3 col-xs-12">
                                        <asp:TextBox ID="txtPremiseZipCd" CssClass="form-control input-md"
                                            MaxLength="10" placeholder="Zip Code*" required runat="server"
                                            TextMode="Number"></asp:TextBox>
                                    </div>
                                </div>

                                <div class="form-group">
                                    <div class="col-md-8 col-sm-8 col-xs-12">
                                        <asp:TextBox ID="txtAgentNm" CssClass="form-control input-md" MaxLength="255"
                                            placeholder="Name of Insurance Agent*" required runat="server">
                                        </asp:TextBox>
                                    </div>
                                    <div class="col-md-4 col-sm-4 col-xs-12">
                                        <asp:TextBox ID="txtAgentPhoneNbr" CssClass="form-control input-md"
                                            MaxLength="15" placeholder="Phone Number of Insurance Agency*" required
                                            runat="server"></asp:TextBox>
                                    </div>
                                </div>

                                <div class="form-group">
                                    <div class="col-md-8 col-sm-8 col-xs-12">
                                        <asp:TextBox ID="txtAgentEmail" CssClass="form-control input-md" MaxLength="255"
                                            placeholder="Insurance Agent Email*" required runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-md-4 col-sm-4 col-xs-12">
                                        <asp:TextBox ID="txtCarrierNm" CssClass="form-control input-md" MaxLength="255"
                                            placeholder="Carrier Name" runat="server"></asp:TextBox>
                                    </div>
                                </div>

                                <div class="form-group">
                                    <div class="col-md-12 col-sm-12 col-xs-12">
                                        <asp:TextBox ID="txtAgentFax" CssClass="form-control input-md" MaxLength="255"
                                            placeholder="Insurance Agent Fax Number" runat="server"></asp:TextBox>
                                    </div>
                                </div>

                                <div class="form-group">
                                    <div class="col-md-4 col-sm-4 col-xs-12">
                                        <asp:TextBox ID="txtPolicyNbr" CssClass="form-control input-md" MaxLength="255"
                                            placeholder="Policy Number" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-md-4 col-sm-5 col-xs-12">
                                        <asp:DropDownList ID="lstInsuranceType" CssClass="form-control" required runat="server">
                                            <asp:ListItem Value="">-- Policy Type (Please Choose One)* --</asp:ListItem>
                                            <asp:ListItem Value="HI">Hazard Insurance</asp:ListItem>
                                            <asp:ListItem Value="FI">Flood Insurance</asp:ListItem>
                                            <asp:ListItem Value="BRI">Builders Risk Insurance</asp:ListItem>
                                            <asp:ListItem Value="LI">Liability Insurance</asp:ListItem>
                                            <asp:ListItem Value="WI">Wind Insurance</asp:ListItem>
                                            <asp:ListItem Value="CAHI">Condo Association Hazard Insurance</asp:ListItem>
                                            <asp:ListItem Value="CAFI">Condo Association Flood Insurance</asp:ListItem>
                                            <asp:ListItem Value="UOHI">Unit Owner Hazard Insurance</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                </div>

                                <div class="form-group">
                                    <label class="col-md-2 col-sm-2 col-xs-12 control-label">Comments</label>
                                    <div class="col-md-9 col-sm-9 col-xs-12">
                                        <asp:TextBox ID="txtComments" CssClass="form-control input-md" runat="server"
                                            MaxLength="1000" TextMode="MultiLine"
                                            ToolTip="Please add a few words on the type of coverage"></asp:TextBox>
                                    </div>
                                </div>

                                <div class="form-group">
                                    <div class="col-md-12 col-sm-12 col-xs-12 col-md-offset-2">
                                        <asp:Button ID="btnSubmit" runat="server" CssClass="btn btn-primary"
                                            Text="SUBMIT FORM" OnClick="btnSubmit_Click" />
                                    </div>
                                </div>

                                <div class="form-group">
                                    <div class="col-md-12 col-sm-12 col-xs-12">
                                        <label class="control-label">Please allow 30 seconds for this process to
                                            complete before selecting the Submit button again.</label>
                                        <br />
                                        <p class="small" style="margin-top:15px;">Your insurance submission is handled by an independent third party service provider. Lima One Capital is not directly notified of submission completion or status updates and will only be contacted in the event that a discrepancy, error, or clarification is required.</p>
                                         
                                    </div>
                                 </div>

                            </fieldset>
                        </form>

                    </div>
                </div>
            </div>
        </section>

        <footer>
            <div class="container">
                <div class="col-md-6">
                    <p class="rights">Copyright &copy; 2026 ValidateMyInsurance.com | <a href="privacy.html">Our Privacy
                            Policy</a></p>
                    <p class="rights">If you have any questions or are having difficulty with this form, please call
                        866-898-3480 to provide your insurance information.</p>
                </div>
                <div class="col-md-6">
                    <p class="small">The federal Fair Credit Reporting Act, 15 USC 1681 et seq. (FCRA) promotes the
                        accuracy, fairness, and privacy of information in the files of consumer reporting agencies.
                        Lender Insurance Verification does not establish a "consumer report" as that term is defined in
                        the FCRA. In addition, Lender Insurance Verification may not be used in whole or in part as a
                        factor in determining eligibility for insurance or another permissible purpose under the FCRA.
                    </p>
                </div>
            </div>
        </footer>
        <!--  END FOOTER  -->

        <script type="text/javascript" src="Scripts/jquery-3.7.0.min.js"></script>
        <script type="text/javascript" src="js/bootstrap.min.js"></script>
        <script type="text/javascript" src="js/main.js"></script>

    </body>

    </html>