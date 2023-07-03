# XAF - How to create and setup an XtraReport report for exporting to a Stream in a non-XAF application

This example illustrates how to access an XAF report stored in the database and populate it with data in a non-XAF application.

Since XAF stores reports in the database and XAF reports use Object Spaces to retrieve data from the database, it is necessary to connect to the XAF database and create an Object Space to use XAF reports in a non-XAF application.

## Implementation Details

1. Create a custom class that implements the `IObjectSpaceProviderFactory` interface. Please refer to the [CustomObjectSpaceProviderFactory.cs](CS/EFCore/ExportReportEF/ExportXAFReport/CustomObjectSpaceProviderFactory.cs) file for implementation details.
2. Create an Object Space using the class you created in step 1.
3. Use the approach described in the [How to: Print a Report Without Displaying a Preview](https://docs.devexpress.com/eXpressAppFramework/113601/shape-export-print-data/reports/task-based-help/how-to-print-a-report-without-displaying-a-preview) article to access and print a report.

## Files to Review

- [CustomObjectSpaceProviderFactory.cs](CS/EFCore/ExportReportEF/ExportXAFReport/CustomObjectSpaceProviderFactory.cs)
- [Program.cs](CS/EFCore/ExportReportEF/ExportXAFReport/Program.cs)

## Documentation

- [How to: Use XAF Reports in a non-XAF Application](https://docs.devexpress.com/eXpressAppFramework/114515/shape-export-print-data/reports/task-based-help/how-to-use-xaf-reports-in-a-non-xaf-application)
- [Access XAF Application Data in a non-XAF Application](https://docs.devexpress.com/eXpressAppFramework/113709/data-manipulation-and-business-logic/access-xaf-application-data-in-a-non-xaf-application)
- [How to: Print a Report Without Displaying a Preview](https://docs.devexpress.com/eXpressAppFramework/113601/shape-export-print-data/reports/task-based-help/how-to-print-a-report-without-displaying-a-preview)

## More Examples

- [How to change the XtraReport layout dynamically via a custom Report Parameters Object](https://github.com/DevExpress-Examples/XAF_how-to-change-the-xtrareport-layout-dynamically-via-a-custom-report-parameters-object-e1930)

