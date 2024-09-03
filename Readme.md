<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128588873/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T275059)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# XAF - How to create and set up an XtraReport report for exporting to a Stream in a non-XAF application

This example illustrates how to access an XAF report stored in the database and populate it with data in a non-XAF application.

Since XAF stores reports in the database and XAF reports use Object Spaces to retrieve data from the database, it is necessary to connect to the XAF database and create an Object Space to use XAF reports in a non-XAF application.

## Implementation Details

1. Create a custom class that implements the `IObjectSpaceProviderFactory` interface. Please refer to the [CustomObjectSpaceProviderFactory.cs](CS/EFCore/ExportReportEF/ExportXAFReport/CustomObjectSpaceProviderFactory.cs) file for implementation details. This class is used as a service to create `IObjectSpace` objects on demand.
2. Create the `ServiceCollection` to register required XAF services and your `CustomObjectSpaceProviderFactory` service.
3. Use the `IReportExportService` service to load and prepare a report.


## Files to Review

- [CustomObjectSpaceProviderFactory.cs](CS/EFCore/ExportReportEF/ExportXAFReport/CustomObjectSpaceProviderFactory.cs)
- [Program.cs](CS/EFCore/ExportReportEF/ExportXAFReport/Program.cs)

## Documentation

- [How to: Use XAF Reports in a non-XAF Application](https://docs.devexpress.com/eXpressAppFramework/114515/shape-export-print-data/reports/task-based-help/how-to-use-xaf-reports-in-a-non-xaf-application)
- [Access XAF Application Data in a non-XAF Application](https://docs.devexpress.com/eXpressAppFramework/113709/data-manipulation-and-business-logic/access-xaf-application-data-in-a-non-xaf-application)

## More Examples

- [How to change the XtraReport layout dynamically via a custom Report Parameters Object](https://github.com/DevExpress-Examples/XAF_how-to-change-the-xtrareport-layout-dynamically-via-a-custom-report-parameters-object-e1930)

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=xaf-how-to-create-and-setup-an-xtrareport-report-for-exporting-to-a-stream-in-a-non-xaf&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=xaf-how-to-create-and-setup-an-xtrareport-report-for-exporting-to-a-stream-in-a-non-xaf&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
