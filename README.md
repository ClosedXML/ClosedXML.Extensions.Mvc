# ClosedXML.Extensions.Mvc
MVC Extensions for [ClosedXML](https://github.com/ClosedXML/ClosedXML)

## Install via NuGet

To install ClosedXML.Extensions.Mvc for .NET Core, run the following command in the Package Manager Console

```PowerShell
PM> Install-Package ClosedXML.Extensions.Mvc
```

If you're using .NET Framework, please install v0.2.2 

```PowerShell
PM> Install-Package ClosedXML.Extensions.Mvc -Version 0.2.2
```

## Usage
In your MVC controller define an action that will generate and download your file:

```c#
private ClosedXML.Excel.XLWorkbook GenerateClosedXMLWorkbook()
{
    var wb = new ClosedXML.Excel.XLWorkbook();
    var ws = wb.AddWorksheet();
    ws.FirstCell().SetValue("Hello world!");
    ws.FirstCell().CellBelow().FormulaA1 = "RAND()";
    return wb;
}

public ActionResult Download()
{
    using (var wb = GenerateClosedXMLWorkbook())
    {
        // Add ClosedXML.Extensions in your using declarations
        
        return wb.Deliver("generatedfile.xlsx");
        
        // or specify the content type:
        return wb.Deliver("generatedFile.xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
    }
}

```
