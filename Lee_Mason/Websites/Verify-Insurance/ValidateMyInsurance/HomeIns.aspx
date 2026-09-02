<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeIns.aspx.cs" Inherits="ValidateMyInsurance.CondoIns" %>

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
    <div class="container text-center"> <a href="Default.aspx"> <img src="images/logo.png" alt="ValidateMyInsurance.com" class="logo img-responsive center-block">  </a>
  </div>
</header>
<!--  END HEADER -->
<section>
<div class="container">
            <div class="row">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
        
<form class="form-horizontal" id="formHomeIns" accept-charset="UTF-8" method="post" runat="server">

  <h1 class="text-primary"><asp:Label ID="FormLabel"  runat="server" Text="Label"></asp:Label></h1>
      
  <p>Account Information (as it appears on the Insurance Notice). Fields marked with an &#42; are required.</p>
    
 
<asp:Panel ID="Panel1" runat="server" Visible=false>
    <div class="clearfix">
 <div class="col-lg-4 col-md-4 col-sm-12 col-xs-12 alert alert-danger alert-dismissible fade in" role="alert">
    <button type="button" class="close" data-dismiss="alert" aria-label="Close" name="FileWarning">
     <span aria-hidden="true">&times;</span>
  </button>
    <asp:Label ID="lblFileIssues" runat="server" Text="File size must not exceed 4MB" class="container text-center" Visible="True" Font-Bold="True"></asp:Label>
</div>
        </div>
</asp:Panel>

        
  <!--  Validation Summary -->      

<fieldset>
<legend>YOUR INFORMATION</legend>

<!-- ----------- YOUR INFORMATION ------------------ -->
<div class="form-group">
<div class="col-md-6 col-sm-6 col-xs-12">   
 <asp:TextBox ID="txtFirstNm" CssClass="form-control" maxlength="100" placeholder="First Name*" required runat="server"></asp:TextBox> </div>
<div class="col-md-6 col-sm-6 col-xs-12">   <asp:TextBox ID="txtLastNm" CssClass="form-control" maxlength="100" placeholder="Last Name*" required runat="server"></asp:TextBox> </div>
</div>

<div class="form-group">
<div class="col-md-12 col-sm-12 col-xs-12"><asp:TextBox ID="txtBusinessNm" CssClass="form-control input-md" maxlength="255" placeholder="Business Name" runat="server" Visible="False"></asp:TextBox> </div>
</div>

<div class="form-group">
<div class="col-md-12 col-sm-12 col-xs-12"><asp:TextBox ID="txtMailingStreetNm" CssClass="form-control input-md" maxlength="255" placeholder="Mailing Street Address"  runat="server"></asp:TextBox> </div>
</div>

<div class="form-group">
<div class="col-md-12 col-sm-12 col-xs-12"><asp:TextBox ID="txtMailingStreet2Nm" CssClass="form-control input-md" maxlength="255" placeholder="Mailing Street Address 2"  runat="server"></asp:TextBox> </div>
</div>

<div class="form-group">
<div class="col-md-5 col-sm-5 col-xs-12"><asp:TextBox ID="txtMailingCityCd" CssClass="form-control input-md" maxlength="100" placeholder="City"  runat="server"></asp:TextBox> </div>
 <div class="col-md-4 col-sm-5 col-xs-12">   <asp:DropDownList ID="lstMailingStateCd" CssClass="form-control" runat="server">
     <asp:ListItem value="-- Please Choose One --">-- State (Please Choose One) --</asp:ListItem>
     <asp:ListItem value="AL">Alabama</asp:ListItem>
	<asp:ListItem value="AK">Alaska</asp:ListItem>
	<asp:ListItem value="AZ">Arizona</asp:ListItem>
	<asp:ListItem value="AR">Arkansas</asp:ListItem>
	<asp:ListItem value="CA">California</asp:ListItem>
	<asp:ListItem value="CO">Colorado</asp:ListItem>
	<asp:ListItem value="CT">Connecticut</asp:ListItem>
	<asp:ListItem value="DE">Delaware</asp:ListItem>
	<asp:ListItem value="DC">District Of Columbia</asp:ListItem>
	<asp:ListItem value="FL">Florida</asp:ListItem>
	<asp:ListItem value="GA">Georgia</asp:ListItem>
	<asp:ListItem value="HI">Hawaii</asp:ListItem>
	<asp:ListItem value="ID">Idaho</asp:ListItem>
	<asp:ListItem value="IL">Illinois</asp:ListItem>
	<asp:ListItem value="IN">Indiana</asp:ListItem>
	<asp:ListItem value="IA">Iowa</asp:ListItem>
	<asp:ListItem value="KS">Kansas</asp:ListItem>
	<asp:ListItem value="KY">Kentucky</asp:ListItem>
	<asp:ListItem value="LA">Louisiana</asp:ListItem>
	<asp:ListItem value="ME">Maine</asp:ListItem>
	<asp:ListItem value="MD">Maryland</asp:ListItem>
	<asp:ListItem value="MA">Massachusetts</asp:ListItem>
	<asp:ListItem value="MI">Michigan</asp:ListItem>
	<asp:ListItem value="MN">Minnesota</asp:ListItem>
	<asp:ListItem value="MS">Mississippi</asp:ListItem>
	<asp:ListItem value="MO">Missouri</asp:ListItem>
	<asp:ListItem value="MT">Montana</asp:ListItem>
	<asp:ListItem value="NE">Nebraska</asp:ListItem>
	<asp:ListItem value="NV">Nevada</asp:ListItem>
	<asp:ListItem value="NH">New Hampshire</asp:ListItem>
	<asp:ListItem value="NJ">New Jersey</asp:ListItem>
	<asp:ListItem value="NM">New Mexico</asp:ListItem>
	<asp:ListItem value="NY">New York</asp:ListItem>
	<asp:ListItem value="NC">North Carolina</asp:ListItem>
	<asp:ListItem value="ND">North Dakota</asp:ListItem>
	<asp:ListItem value="OH">Ohio</asp:ListItem>
	<asp:ListItem value="OK">Oklahoma</asp:ListItem>
	<asp:ListItem value="OR">Oregon</asp:ListItem>
	<asp:ListItem value="PA">Pennsylvania</asp:ListItem>
	<asp:ListItem value="RI">Rhode Island</asp:ListItem>
	<asp:ListItem value="SC">South Carolina</asp:ListItem>
	<asp:ListItem value="SD">South Dakota</asp:ListItem>
	<asp:ListItem value="TN">Tennessee</asp:ListItem>
	<asp:ListItem value="TX">Texas</asp:ListItem>
	<asp:ListItem value="UT">Utah</asp:ListItem>
	<asp:ListItem value="VT">Vermont</asp:ListItem>
	<asp:ListItem value="VA">Virginia</asp:ListItem>
	<asp:ListItem value="WA">Washington</asp:ListItem>
	<asp:ListItem value="WV">West Virginia</asp:ListItem>
	<asp:ListItem value="WI">Wisconsin</asp:ListItem>
	<asp:ListItem value="WY">Wyoming</asp:ListItem>
     </asp:DropDownList> </div>

<div class="col-md-3 col-sm-3 col-xs-12"><asp:TextBox ID="txtMailingZipCd" CssClass="form-control input-md" maxlength="10" TextMode="Number" placeholder="Zip Code" runat="server"></asp:TextBox> </div>
</div>

<div class="form-group">
<div class="col-md-12 col-sm-12 col-xs-12">
<label class="checkbox-inline control-label">
<asp:CheckBox ID="ckMailingSameasPremise" placeholder="Mailing Address is the same as Premise?" runat="server" OnCheckedChanged="ckMailingSameasPremise_CheckedChanged" AutoPostBack="True"  /> Select if Property/Colleteral Address is the same as Mailing Address
</label>
</div>
</div>

<hr class="formrule">
<div class="form-group">
<div class="col-md-5 col-sm-5 col-xs-12"><asp:TextBox ID="txtEmail" CssClass="form-control input-md" maxlength="255" placeholder="Email Address*" required runat="server"></asp:TextBox> </div>
<div class="col-md-4 col-sm-4 col-xs-12"><asp:TextBox ID="txtPhoneNbr" CssClass="form-control input-md" maxlength="15" TextMode="Number" placeholder="Contact Phone Number"  runat="server"></asp:TextBox> </div>
<div class="col-md-5 col-sm-5 col-xs-12"><p class="small">We will send an automatic confirmation of receipt to the email address provided. This will not be used for solicitation purposes.</p></div>
</div>
<hr class="formrule clearfix">
</fieldset>


<!-- ----------- LENDER INFORMATION ------------------ -->
<fieldset>
<legend>LENDER INFORMATION</legend>
<div class="form-group">
<div class="col-md-6 col-sm-6 col-xs-12"><asp:TextBox ID="txtLenderNm" CssClass="form-control input-md" maxlength="255" placeholder="Name of Lender" runat="server"></asp:TextBox> </div>
<div class="col-md-6 col-sm-6 col-xs-12"><asp:TextBox ID="txtAccountNbr" CssClass="form-control input-md" maxlength="255" placeholder="Account Number*" required runat="server"></asp:TextBox> </div>
</div>

<div class="form-group">
<div class="col-md-12 col-sm-12 col-xs-12"><asp:TextBox ID="txtLenderAddress" CssClass="form-control input-md" maxlength="255" placeholder="Address of Lender" runat="server"></asp:TextBox> </div>
</div>

</fieldset>

<!-- ----------- PROPERTY INFORMATION ------------------ -->
<fieldset>
<legend>PROPERTY and INSURANCE INFORMATION</legend>
<div class="form-group">
<div class="col-md-12 col-sm-12 col-xs-12"><asp:TextBox ID="txtCollateralDesc" CssClass="form-control input-md" maxlength="255" placeholder="Collateral Description*" required runat="server"></asp:TextBox> </div>
</div>

<div class="form-group">
<div class="col-md-12 col-sm-12 col-xs-12"><asp:TextBox ID="txtPremiseStreetTxtNm" CssClass="form-control input-md" maxlength="255" placeholder="Street Address*" required runat="server"></asp:TextBox> </div>
</div>

<div class="form-group">
<div class="col-md-12 col-sm-12 col-xs-12"><asp:TextBox ID="txtPremiseStreetTxt2Nm" CssClass="form-control input-md" maxlength="255" placeholder="Street Address 2 (such as Unit Number)"  runat="server"></asp:TextBox> </div>
</div>

<div class="form-group">
<div class="col-md-5 col-sm-4 col-xs-12"><asp:TextBox ID="txtPremiseCityNm" CssClass="form-control input-md" maxlength="255" placeholder="City*" required runat="server"></asp:TextBox> </div>

<div class="col-md-4 col-sm-5 col-xs-12">   <asp:DropDownList ID="lstPremiseStateCd" CssClass="form-control" runat="server">
     <asp:ListItem value="-- Please Choose One --">-- State (Please Choose One) --</asp:ListItem>
     <asp:ListItem value="AL">Alabama</asp:ListItem>
	<asp:ListItem value="AK">Alaska</asp:ListItem>
	<asp:ListItem value="AZ">Arizona</asp:ListItem>
	<asp:ListItem value="AR">Arkansas</asp:ListItem>
	<asp:ListItem value="CA">California</asp:ListItem>
	<asp:ListItem value="CO">Colorado</asp:ListItem>
	<asp:ListItem value="CT">Connecticut</asp:ListItem>
	<asp:ListItem value="DE">Delaware</asp:ListItem>
	<asp:ListItem value="DC">District Of Columbia</asp:ListItem>
	<asp:ListItem value="FL">Florida</asp:ListItem>
	<asp:ListItem value="GA">Georgia</asp:ListItem>
	<asp:ListItem value="HI">Hawaii</asp:ListItem>
	<asp:ListItem value="ID">Idaho</asp:ListItem>
	<asp:ListItem value="IL">Illinois</asp:ListItem>
	<asp:ListItem value="IN">Indiana</asp:ListItem>
	<asp:ListItem value="IA">Iowa</asp:ListItem>
	<asp:ListItem value="KS">Kansas</asp:ListItem>
	<asp:ListItem value="KY">Kentucky</asp:ListItem>
	<asp:ListItem value="LA">Louisiana</asp:ListItem>
	<asp:ListItem value="ME">Maine</asp:ListItem>
	<asp:ListItem value="MD">Maryland</asp:ListItem>
	<asp:ListItem value="MA">Massachusetts</asp:ListItem>
	<asp:ListItem value="MI">Michigan</asp:ListItem>
	<asp:ListItem value="MN">Minnesota</asp:ListItem>
	<asp:ListItem value="MS">Mississippi</asp:ListItem>
	<asp:ListItem value="MO">Missouri</asp:ListItem>
	<asp:ListItem value="MT">Montana</asp:ListItem>
	<asp:ListItem value="NE">Nebraska</asp:ListItem>
	<asp:ListItem value="NV">Nevada</asp:ListItem>
	<asp:ListItem value="NH">New Hampshire</asp:ListItem>
	<asp:ListItem value="NJ">New Jersey</asp:ListItem>
	<asp:ListItem value="NM">New Mexico</asp:ListItem>
	<asp:ListItem value="NY">New York</asp:ListItem>
	<asp:ListItem value="NC">North Carolina</asp:ListItem>
	<asp:ListItem value="ND">North Dakota</asp:ListItem>
	<asp:ListItem value="OH">Ohio</asp:ListItem>
	<asp:ListItem value="OK">Oklahoma</asp:ListItem>
	<asp:ListItem value="OR">Oregon</asp:ListItem>
	<asp:ListItem value="PA">Pennsylvania</asp:ListItem>
	<asp:ListItem value="RI">Rhode Island</asp:ListItem>
	<asp:ListItem value="SC">South Carolina</asp:ListItem>
	<asp:ListItem value="SD">South Dakota</asp:ListItem>
	<asp:ListItem value="TN">Tennessee</asp:ListItem>
	<asp:ListItem value="TX">Texas</asp:ListItem>
	<asp:ListItem value="UT">Utah</asp:ListItem>
	<asp:ListItem value="VT">Vermont</asp:ListItem>
	<asp:ListItem value="VA">Virginia</asp:ListItem>
	<asp:ListItem value="WA">Washington</asp:ListItem>
	<asp:ListItem value="WV">West Virginia</asp:ListItem>
	<asp:ListItem value="WI">Wisconsin</asp:ListItem>
	<asp:ListItem value="WY">Wyoming</asp:ListItem>
     </asp:DropDownList> </div>

<div class="col-md-3 col-sm-3 col-xs-12"><asp:TextBox ID="txtPremiseZipCd" CssClass="form-control input-md" maxlength="10" placeholder="Zip Code*" required runat="server" TextMode="Number"></asp:TextBox> </div>
</div>
    
<div class="form-group">
<div class="col-md-12 col-sm-12 col-xs-12"><asp:TextBox ID="txtFloodZoneCd" CssClass="form-control input-md" maxlength="10" placeholder="Flood Zone/FIRM Zone" runat="server" Visible="False" ></asp:TextBox> </div>
</div>

<div class="form-group">
<div class="col-md-8 col-sm-8 col-xs-12"><asp:TextBox ID="txtInsuranceCoNm" CssClass="form-control input-md" maxlength="255" placeholder="Name of Insurance Company*" required runat="server"></asp:TextBox> </div>
<div class="col-md-4 col-sm-4 col-xs-12"><asp:TextBox ID="txtInsuranceCoPhoneNbr" CssClass="form-control input-md" maxlength="15" placeholder="Phone Number (if available)" runat="server"></asp:TextBox> </div>
</div>

<div class="form-group">
<div class="col-md-8 col-sm-8 col-xs-12"><asp:TextBox ID="txtAgentNm" CssClass="form-control input-md" maxlength="255" placeholder="Name of Insurance Agent*" required runat="server"></asp:TextBox> </div>
<div class="col-md-4 col-sm-4 col-xs-12"><asp:TextBox ID="txtAgentPhoneNbr" CssClass="form-control input-md" maxlength="15" placeholder="Phone Number of Insurance Agency*" required runat="server"></asp:TextBox> </div>
</div>

<div class="form-group">
<div class="col-md-8 col-sm-8 col-xs-12"><asp:TextBox ID="txtAgentAddress" CssClass="form-control input-md" maxlength="255" placeholder="Address of Insurance Agency" runat="server"></asp:TextBox> </div>
<div class="col-md-4 col-sm-4 col-xs-12"><asp:TextBox ID="txtPolicyNbr" CssClass="form-control input-md" maxlength="255" placeholder="Policy Number" runat="server"></asp:TextBox> </div>
</div>

<div class="form-group">
<div class="col-md-12 col-sm-12 col-xs-12"><asp:TextBox ID="txtTypeofInsurance" CssClass="form-control input-md" maxlength="255" placeholder="Type of Insurance*" required Visible="False" runat="server"></asp:TextBox> </div>
</div>


<div class="form-group">
<label class="col-md-5 col-sm-5 col-xs-12 control-label">If the insurance policy number is unavailable, please select one:</label>

<div class="col-md-5 col-sm-5 col-xs-12">
 <asp:RadioButtonList ID="rbPolicyType" CssClass="radio-inline control-label" runat="server">     
     <asp:ListItem Value="LoanBinder">Binder/Acord</asp:ListItem>
     <asp:ListItem>Application</asp:ListItem>
     <asp:ListItem>Other</asp:ListItem>
    </asp:RadioButtonList>
</div>
</div>

<hr class="formrule">

<div class="form-group">
<label class="col-md-4 col-sm-4 col-xs-12 control-label">Named Mortgagee/Loss Payee as shown on declarations page</label>
<div class="col-md-8 col-sm-8 col-xs-12"><asp:TextBox ID="txtPayeeDecPage" CssClass="form-control input-md" maxlength="255" runat="server"></asp:TextBox> </div>
</div>

<div class="form-group">
<asp:Label ID="lblCoverageAmt" CssClass="col-md-4 col-sm-4 col-xs-12 control-label" runat="server" Text="Dwelling/Building Coverage Amount"></asp:Label>
<div class="col-md-3 col-sm-3"><asp:TextBox ID="txtCoverageAmt" CssClass="form-control input-md" maxlength="15" placeholder="$" runat="server" TextMode="Number"></asp:TextBox> </div>
<asp:RegularExpressionValidator ID="ReqExpCoverageAmt" ControlToValidate="txtCoverageAmt" CssClass="form-control input-md" runat="server" ErrorMessage="Only Numbers allowed" ValidationExpression="\d+"></asp:RegularExpressionValidator>
</div>

<hr class="formrule clearfix">


<div class="form-group">
   <label class="col-md-4 col-sm-4 col-xs-12 control-label">Policy Effective Start Date</label>
    <div class="col-md-2 col-sm-2 col-xs-12 date">
          
      <div class='input-group date'>
         <div><asp:TextBox ID="txtEffectiveStartDt" CssClass="form-control input-md" maxlength="20" runat="server" TextMode="Date" ToolTip="Policy Coverage Start Date" ></asp:TextBox> </div>                
          <span class="input-group-addon">
           <span class="fa fa-calendar"></span>
          </span>
        </div>
      </div>
</div>

<div class="form-group">
 <label class="col-md-4 col-sm-4 col-xs-12 control-label" style="margin-bottom:.5em;">Upload Policy File (PDF or JPEG) - A copy of your policy is not required, but is strongly encouraged.  We cannot guarantee we will be able to update your insurance record if we are unable to verify the information provided. The size of the file is limited to 4 MB.</label>
    <div class="col-md-3 col-sm-3">
        <asp:FileUpload ID="FileUpload1"  runat="server" />
    </div>
</div>

<hr class="formrule clearfix">

<div class="form-group">
<label class="col-md-2 col-sm-2 col-xs-12 control-label">Comments</label>
<div class="col-md-9 col-sm-9 col-xs-12"><asp:TextBox ID="txtComments" CssClass="form-control input-md" runat="server" MaxLength="1000" TextMode="MultiLine" ToolTip="Please add a few words on the type of coverage"></asp:TextBox> </div>
</div>


<div class="form-group">
  <div class="col-md-12 col-sm-12 col-xs-12 col-md-offset-2">
  <asp:Button ID="btnSubmit" runat="server" CssClass="btn btn-primary" Text="SUBMIT FORM" type="submit" OnClick="btnSubmit_Click" />	  
  </div>
	<label class="col-md-2 col-sm-2 col-xs-12 control-label">Please allow 30 seconds for this process to complete before selecting the Submit button again.</label>
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
      <p class="rights">Copyright &copy; 2024 ValidateMyInsurance.com | <a href="privacy.html">Our Privacy Policy</a></p>
      <p class="rights">If you have any questions or are having difficulty with this form, please call 888-248-9499 to provide your insurance information.</p>
    </div>
    <div class="col-md-6">
            <p class="small">The federal Fair Credit Reporting Act, 15 USC 1681 et seq. (FCRA) promotes the accuracy, fairness, and privacy of information in the files of consumer reporting agencies.  Lender Insurance Verification does not establish a "consumer report" as that term is defined in the FCRA. In addition, Lender Insurance Verification may not be used in whole or in part as a factor in determining eligibility for insurance or another permissible purpose under the FCRA.</p>
    </div>
  </div>
</footer>
<!--  END FOOTER  --> 

<script type="text/javascript" src="Scripts/jquery-3.7.0.min.js"></script>
<script type="text/javascript" src="../js/bootstrap.min.js"></script>
<script type="text/javascript" src="../js/main.js"></script>

    
</body>
</html>