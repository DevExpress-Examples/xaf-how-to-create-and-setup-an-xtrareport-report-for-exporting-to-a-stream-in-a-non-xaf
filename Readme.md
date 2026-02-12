<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128588873/22.2.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T275059)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# XAF - How to create and setup an XtraReport report for exporting to a Stream in a non-XAF application

This example illustrates how to access XAF report stored in the database and populate it with data in a non-XAF application.

Since XAF stores reports in the database, and XAF reports use the ObjectSpace to retrieve data from database, it is necessary to connect to the XAF database and create ObjectSpace to use XAF reports in a non-XAF application.

## Implementation Details

1. Create a custom class which implements the IReportObjectSpaceProvider interface. Please refer to the [MyReportObjectSpaceProvider](CS/EFCore/ExportReportEF/ExportXAFReport/MyReportObjectSpaceProvider.cs) file for implementation details.
2. Create a custom class which inherits the [ReportDataSourceHelper](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ReportsV2.ReportDataSourceHelper) class and override the `CreateReportObjectSpaceProvider` method as shown in the [MyReportDataSourceHelper](CS/EFCore/ExportReportEF/ExportXAFReport/MyReportDataSourceHelper.cs) class.
3. Create ObjectSpace using the approach from the [Access XAF Application Data in a non-XAF Application](https://docs.devexpress.com/eXpressAppFramework/113709/data-manipulation-and-business-logic/access-xaf-application-data-in-a-non-xaf-application) article and register required types in the TypesInfo. Please refer _ExportXafReport/Program.xx_ file.
4. Use the approach described in the [How to: Print a Report Without Displaying a Preview](https://docs.devexpress.com/eXpressAppFramework/113601/shape-export-print-data/reports/task-based-help/how-to-print-a-report-without-displaying-a-preview) article to access and print a report.
 

## Files to Review

- [MyReportObjectSpaceProvider](CS/EFCore/ExportReportEF/ExportXAFReport/MyReportObjectSpaceProvider.cs)
- [MyReportDataSourceHelper](CS/EFCore/ExportReportEF/ExportXAFReport/MyReportDataSourceHelper.cs)
- [Program.cs](CS/EFCore/ExportReportEF/ExportXAFReport/Program.cs)

## Documentation

- [How to: Use XAF Reports in a non-XAF Application](https://docs.devexpress.com/eXpressAppFramework/114515/shape-export-print-data/reports/task-based-help/how-to-use-xaf-reports-in-a-non-xaf-application)
- [Access XAF Application Data in a non-XAF Application](https://docs.devexpress.com/eXpressAppFramework/113709/data-manipulation-and-business-logic/access-xaf-application-data-in-a-non-xaf-application)
- [How to: Print a Report Without Displaying a Preview](https://docs.devexpress.com/eXpressAppFramework/113601/shape-export-print-data/reports/task-based-help/how-to-print-a-report-without-displaying-a-preview)

## More Examples

- [How to change the XtraReport layout dynamically via a custom Report Parameters Object](https://github.com/DevExpress-Examples/XAF_how-to-change-the-xtrareport-layout-dynamically-via-a-custom-report-parameters-object-e1930)

<!-- feedback -->
## Does This Example Address Your Development Requirements/Objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=xaf-how-to-create-and-setup-an-xtrareport-report-for-exporting-to-a-stream-in-a-non-xaf&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=xaf-how-to-create-and-setup-an-xtrareport-report-for-exporting-to-a-stream-in-a-non-xaf&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
