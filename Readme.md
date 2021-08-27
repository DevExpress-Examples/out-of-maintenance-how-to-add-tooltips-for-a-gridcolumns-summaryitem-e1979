<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128625364/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1979)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/GridControlSummuryItem/Form1.cs) (VB: [Form1.vb](./VB/GridControlSummuryItem/Form1.vb))
* [Program.cs](./CS/GridControlSummuryItem/Program.cs) (VB: [Program.vb](./VB/GridControlSummuryItem/Program.vb))
<!-- default file list end -->
# How to add Tooltips for a GridColumns SummaryItem


<p>The following example shows how to implement custom tooltips for a <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridColumnsGridColumn_SummaryItemtopic">GridColumn.SummaryItem</a>. By default, the <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraGridGridControltopic">GridControl</a> does not support tooltips for a <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridColumnsGridColumn_SummaryItemtopic">GridColumn.SummuryItems</a>. To provide tooltips, drop the <a href="http://documentation.devexpress.com/#CoreLibraries/clsDevExpressUtilsToolTipControllertopic">ToolTipController</a> component onto the grid's form, assign it to the grid control's <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsContainerEditorContainer_ToolTipControllertopic">EditorContainer.ToolTipController</a> property and handle the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressUtilsToolTipController_GetActiveObjectInfotopic">ToolTipController.GetActiveObjectInfo</a> event.</p><p><strong>See Also:</strong><br />
<a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument1964">How to: Add Tooltips for the Row Indicator in XtraGrid </a></p>

<br/>


