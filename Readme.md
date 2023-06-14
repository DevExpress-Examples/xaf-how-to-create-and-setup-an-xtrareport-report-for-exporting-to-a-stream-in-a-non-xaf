<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128588873/22.2.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T275059)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to create and setup an XtraReport report for exporting to a Stream in a non-XAF application


<p><strong>Scenario</strong><br />This example illustrates how to access XAF report stored in the database and populate it with data in a non-XAF application.<br />Since XAF stores reports in the database, and XAF reports use the ObjectSpace to retrieve data from database, it is necessary to connect to the XAF database and create ObjectSpace to use XAF reports in a non-XAF application.<br /><br /><strong>Steps to implement: </strong><br /><br />1) Create a custom class which implements the IReportObjectSpaceProvider interface. Please refer to the <em>ExportXafReport\MyReportObjectSpaceProvider.xx</em> file for implementation details.<br />2) Create a custom class which inherits the ReportDataSourceHelper class and override the <strong>CreateReportObjectSpaceProvider</strong> method as shown in the <em>ExportXafReport/MyReportDataSourceHelper.xx </em>class.<br />3) Create ObjectSpace using the approach from the <a href="https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument113709">Access XAF Application Data in a non-XAF Application</a> article and register required types in the TypesInfo. Please refer <em>ExportXafReport/Program.xx</em> file.<br />4) Use the approach described in the <a href="https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113601.aspx">How to: Print a Report Without Displaying a Preview</a> article to access and print a report.<br /><br />This example contains XPO and EF implementations.<br /><br /><strong>See also: </strong><a href="http://help.devexpress.com/#eXpressAppFramework/CustomDocument114515">How to: Use XAF Reports in a non-XAF Application</a></p>

<br/>


