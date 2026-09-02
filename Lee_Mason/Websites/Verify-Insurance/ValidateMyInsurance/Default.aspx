<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ValidateMyInsurance._Default" %>

<!DOCTYPE html>
<html lang="en">
<head>
<meta charset="utf-8">
<meta http-equiv="X-UA-Compatible" content="IE=edge">
<meta name="viewport" content="width=device-width, initial-scale=1">
<title>Validate My Insurance - ValidateMyInsurance.com</title>
<link href="css/bootstrap.min.css" rel="stylesheet">
<link href="css/custom.css" rel="stylesheet">
<link href="css/font-awesome.min.css" rel="stylesheet">

</head>
<body>

<header>
  <div class="container text-center"> <img src="images/logo.png" alt="" class="logo img-responsive center-block">
  </div>
</header>
<!--  END HEADER -->

<form class="form-horizontal" id="formHomeIns" accept-charset="UTF-8" method="post" runat="server">

<section class="showcase">
  <div class="showcase-overlay"></div>
  <div class="selectit">
    <div class="container">
      <div class="col-lg-8 col-lg-offset-2">
        <h1>Welcome To ValidateMyInsurance.com</h1>
        <div class="panel panel-default"> 
          <!--<div class="panel-heading"><span class="text-primary">WELCOME TO ValidateMyInsurance.COM</span></div>-->
          <div class="panel-body">
            <div class="row">
              <div class="col-md-7">
                <p class="larger">The <span class="text-primary">fast</span>, <span class="text-primary">secure</span>, and <span class="text-primary">easy</span> way to register your insurance coverage with participating lenders. <i class="fa fa fa-chevron-circle-right"></i></p>
              </div>
              <div class="col-md-5">
                <p>First, please Select the type of policy that you'd like to register:</p>
                <div class="dropdown" style="display: block;">
                  <button class="btn btn-success btn-lg dropdown-toggle" type="button" data-toggle="dropdown"> Select Your Insurance Type <span class="caret"></span> </button>
                  <ul class="dropdown-menu">
                    <li><a href="HomeIns.aspx?h" tabindex="-1">Home Insurance</a></li>
                    <li><a href="AutoIns.aspx?a" tabindex="-1">Auto/Other Insurance</a></li>
                    <li><a href="Homeins.aspx?f" tabindex="-1">Flood Insurance</a></li>
                    <li role="separator" class="divider"></li>
                    <li><a href="CondoIns.aspx?c" tabindex="-1">Condo Association</a></li>
                    <li><a href="Homeins.aspx?co" tabindex="-1">Commercial Real Estate</a></li>
                    <li><a href="Homeins.aspx?b" tabindex="-1">Commercial Other</a></li>
                  </ul>
                </div>                 
              </div>
            </div>
          </div>
        </div>
        <!--END PANEL--> 
      </div>
    </div>
    <!--END CONTAINER--> 
  </div>
</section>
<!-- END SHOWCASE  -->
 

<section>
  <div class="container">
    <div class="row">
      <div class="col-md-12 text-center">
        <h2>FAST. SECURE. EASY.</h2>
        <p class="lead">Borrowers who secure loans using real estate, vehicles or other property as collateral often need to show their Lenders that they carry adequate insurance for this property. <strong>ValidateMyInsurance.com<span class="text-info"></span></strong> allows borrows to submit proof of insurance for verification of insurance coverage and insurance status for a variety of lenders. </p>
      </div>
    </div>
    <hr>
    <div class="row">
      <div class="col-md-4">
        <h3><i class="fa fa-check-circle-o text-primary"></i> Meeting Requirements</h3>
        <p>Maintaining insurance coverage is a primary requirement in any loan agreement. This site provides an easy and secure method for you to verify insurance for a variety of lenders.</p>
      </div>
      <div class="col-md-4">
        <h3><i class="fa fa-check-circle-o text-primary"></i> It's Quick-and-Easy</h3>
        <p>To complete the verification process on our website, you will need your insurance declarations page and the notification letter from your lender.</p>
      </div>
      <div class="col-md-4">
        <h3><i class="fa fa-check-circle-o text-primary"></i> Proof for Lenders</h3>
        <p>By completing the forms on our website, various lenders can see that you are maintaining coverage and protecting their interests until your loan is paid in full.</p>
      </div>
    </div>
  </div>
</section>

</form>
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
 <script type="text/javascript" src="Scripts/jquery-3.7.1.min.js"></script>
 <script type="text/javascript" src="js/bootstrap.min.js"></script>
 <script type="text/javascript" src="Scripts/main.js"></script>

</body>
 
  
</html>


