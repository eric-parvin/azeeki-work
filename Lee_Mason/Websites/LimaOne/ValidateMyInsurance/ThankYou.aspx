<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThankYou.aspx.cs" Inherits="ValidateMyInsurance.ThankYou" %>

<!DOCTYPE html>
<html lang="en">
<head>
<meta charset="utf-8">
<meta http-equiv="X-UA-Compatible" content="IE=edge">
<meta name="viewport" content="width=device-width, initial-scale=1">
<meta http-equiv="Refresh" content="20; url=Landing.aspx" />
<title>My Insurance Info | Home Insurance</title>
<link href="css/bootstrap.min.css" rel="stylesheet">
<link href="css/custom.css" rel="stylesheet">
<link href="css/font-awesome.min.css" rel="stylesheet">
<link rel="stylesheet" href="css/bootstrap-datetimepicker.min.css" />
<!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
<script type="text/javascript">
var sdkInstance="appInsightsSDK";window[sdkInstance]="appInsights";var aiName=window[sdkInstance],aisdk=window[aiName]||function(e){function n(e){t[e]=function(){var n=arguments;t.queue.push(function(){t[e].apply(t,n)})}}var t={config:e};t.initialize=!0;var i=document,a=window;setTimeout(function(){var n=i.createElement("script");n.src=e.url||"https://az416426.vo.msecnd.net/scripts/b/ai.2.min.js",i.getElementsByTagName("script")[0].parentNode.appendChild(n)});try{t.cookie=i.cookie}catch(e){}t.queue=[],t.version=2;for(var r=["Event","PageView","Exception","Trace","DependencyData","Metric","PageViewPerformance"];r.length;)n("track"+r.pop());n("startTrackPage"),n("stopTrackPage");var s="Track"+r[0];if(n("start"+s),n("stop"+s),n("setAuthenticatedUserContext"),n("clearAuthenticatedUserContext"),n("flush"),!(!0===e.disableExceptionTracking||e.extensionConfig&&e.extensionConfig.ApplicationInsightsAnalytics&&!0===e.extensionConfig.ApplicationInsightsAnalytics.disableExceptionTracking)){n("_"+(r="onerror"));var o=a[r];a[r]=function(e,n,i,a,s){var c=o&&o(e,n,i,a,s);return!0!==c&&t["_"+r]({message:e,url:n,lineNumber:i,columnNumber:a,error:s}),c},e.autoExceptionInstrumented=!0}return t}(
{
  instrumentationKey:"76fb99b0-1e39-429b-bb70-dfa4c1c7fe80"
}
);window[aiName]=aisdk,aisdk.queue&&0===aisdk.queue.length&&aisdk.trackPageView({});
</script>
</head>
<body>
<header>
  <div class="container text-center"> <img src="images/logo.png" alt="" class="logo img-responsive center-block"> </div>
</header>
<!--  END HEADER --> 
<!--  END HEADER -->

<section>
<div class="container text-center">
   
 <form id="form1" runat="server">   
    <div class="row">
  <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
    <h2>SUCCESS!</h2>
    <h2>Your insurance information has been submitted.</h2>
    <h3>Your insurance information will be verified and updated in our system within 48 hours.  Should you have any questions about your submission, feel free to call our Customer Service Department at 866-898-3480.</h3>
     
  </div>
</div>
 </form>

<hr>

<div class="row">
  <div class="panel-body">
    <div class="row">
      <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
        <p>You will now be redirected back to the homepage where you may select and enter additional insurance policy information if needed.</p>
        <p>If you aren't redirected within 20 seconds, <a class="text-primary" href="Landing.aspx">please click here</a></p>
      </div>
    </div>
  </div>
</div>

</div>

</section>


<footer>
  <div class="container">
    <div class="col-md-6">
      <p class="rights">Copyright &copy; 2026 ValidateMyInsurance.com | <a href="privacy.html">Our Privacy Policy</a></p>
    </div>
    <div class="col-md-6">
            <p class="small">The federal Fair Credit Reporting Act, 15 USC 1681 et seq. (FCRA) promotes the accuracy, fairness, and privacy of information in the files of consumer reporting agencies.  Lender Insurance Verification does not establish a "consumer report" as that term is defined in the FCRA. In addition, Lender Insurance Verification may not be used in whole or in part as a factor in determining eligibility for insurance or another permissible purpose under the FCRA.</p>
    </div>
  </div>
</footer>
<!--  END FOOTER  -->
<script type="text/javascript" src="Scripts/jquery-3.6.0.min.js"></script>
<script type="text/javascript" src="../js/bootstrap.min.js"></script>
<script type="text/javascript" src="../js/main.js"></script>
</body>
</html>
