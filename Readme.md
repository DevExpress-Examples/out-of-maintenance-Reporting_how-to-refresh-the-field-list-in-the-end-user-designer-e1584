<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1584)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Record.cs](./CS/Record.cs) (VB: [Record.vb](./VB/Record.vb))
<!-- default file list end -->
# How to refresh the Field List in the End-User Designer


<p>This example demonstrates how to programmatically update the Field List in the End-User Designer. This may be required when a data source is created and bound to a report at runtime, and isn't present in the designer host of the End-User Designer. For instance, this situation occurs when a data source is represented by a list (e.g. <strong>ArrayList</strong>), as demonstrated in the sample below.</p><p>To accomplish this task, we've introduced the <strong>FieldListDockPanel.UpdateDataSource</strong> method, which should be called after assigning a data source to a report.</p>

<br/>


