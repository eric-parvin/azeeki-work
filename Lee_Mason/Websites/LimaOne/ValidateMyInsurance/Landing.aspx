<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="Landing.aspx.cs"
    Inherits="ValidateMyInsurance._Default" %>
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
            <div class="container text-center">
            <div class="row">
            <div class="col-md-2 col-md-offset-2 col-sm-6 col-xs-5"> <img src="images/lima-one-logo.png" class="img-responsive"></div>
            <div class="col-md-3 col-sm-6 col-xs-7"><a href="Landing.aspx"> <img src="images/logo.png" alt="ValidateMyInsurance.com" class="logo img-responsive center-block">  </a>
          </div>
        </div>     
        </div>
        </header>
        <!--  END HEADER -->

        <form class="form-horizontal" id="formHomeIns" accept-charset="UTF-8" method="post" runat="server">

            <section class="showcase">
                <div class="showcase-overlay"></div>
                <div class="selectit">
                    <div class="container">
                        <div class="row">
                            <div class="col-lg-8 col-lg-offset-2">
                                <h1>Welcome To ValidateMyInsurance.com</h1>

                                <div class="row">
                                    <!-- First Panel -->
                                    <div class="col-md-6 col-sm-12 col-xs-12">
                                        <div class="panel panel-default panel-opacity" style="min-height:185px;">
                                            <div class="panel-body">
                                                <p class="larger">
                                                    If you <strong><em>have</em></strong> a copy of your Insurance
                                                    Policy
                                                    and
                                                    would like to submit it now, please
                                                    <a href="HomeIns.aspx" class="btn btn-primary"> <i
                                                            class="fa fa-chevron-circle-right"></i>&nbsp;click here</a>

                                                </p>
                                            </div>
                                        </div>
                                    </div>
                                    <!-- Second Panel -->
                                    <div class="col-md-6 col-sm-12 col-xs-12">
                                        <div class="panel panel-default panel-opacity" style="min-height:185px;">
                                            <div class="panel-body">
                                                <p class="larger">
                                                    If you <strong><em>do not have</em></strong> a copy of your policy
                                                    and
                                                    would
                                                    like us to contact your insurance agent to request one, please
                                                    <a href="Policy.aspx" class="btn btn-primary"><i
                                                            class="fa fa-chevron-circle-right"></i>&nbsp;click here</a>

                                                </p>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                            </div>
                        </div>
                        <!--END CONTAINER-->
                    </div>
                </div>
            </section>
            <!-- END SHOWCASE  -->

            <section>
                <div class="container">
                    <div class="row">
                        <div class="col-md-12 text-center">
                            <h2>FAST. SECURE. EASY.</h2>
                            <p class="lead">
                                Borrowers who secure loans using real estate, vehicles or other property as collateral
                                often need to show their Lenders that they carry adequate insurance for this property.
                                <strong>ValidateMyInsurance.com</strong> allows borrowers to submit proof of insurance
                                for verification of insurance coverage and insurance status for a variety of lenders.
                            </p>
                        </div>
                    </div>

                    <hr>

                    <div class="row">
                        <div class="col-md-4">
                            <h3><i class="fa fa-check-circle-o text-primary"></i> Meeting Requirements</h3>
                            <p>Maintaining insurance coverage is a primary requirement in any loan agreement. This site
                                provides an easy and secure method for you to verify insurance for a variety of lenders.
                            </p>
                        </div>
                        <div class="col-md-4">
                            <h3><i class="fa fa-check-circle-o text-primary"></i> It's Quick-and-Easy</h3>
                            <p>To complete the verification process on our website, you will need your insurance
                                declarations page and the notification letter from your lender.</p>
                        </div>
                        <div class="col-md-4">
                            <h3><i class="fa fa-check-circle-o text-primary"></i> Proof for Lenders</h3>
                            <p>By completing the forms on our website, various lenders can see that you are maintaining
                                coverage and protecting their interests until your loan is paid in full.</p>
                        </div>
                    </div>
                </div>
            </section>

        </form>

        <footer>
            <div class="container">
                <div class="row">
                    <div class="col-md-6">
                        <p class="rights">Copyright &copy; 2026 ValidateMyInsurance.com | <a href="privacy.html">Our
                                Privacy Policy</a></p>
                        <p class="rights">If you have any questions or are having difficulty with this form, please call
                            866-898-3480 to provide your insurance information.</p>
                    </div>
                    <div class="col-md-6">
                        <p class="small">The federal Fair Credit Reporting Act, 15 USC 1681 et seq. (FCRA) promotes the
                            accuracy, fairness, and privacy of information in the files of consumer reporting agencies.
                            Lender Insurance Verification does not establish a "consumer report" as that term is defined
                            in the FCRA. In addition, Lender Insurance Verification may not be used in whole or in part
                            as a factor in determining eligibility for insurance or another permissible purpose under
                            the FCRA.</p>
                    </div>
                </div>
            </div>
        </footer>
        <!--  END FOOTER  -->

        <script type="text/javascript" src="Scripts/jquery-3.7.1.min.js"></script>
        <script type="text/javascript" src="js/bootstrap.min.js"></script>
        <script type="text/javascript" src="Scripts/main.js"></script>

    </body>

    </html>