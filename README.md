# ClosedXML.Extensions.Mvc
MVC Extensions for ClosedXML

## Install via NuGet

To install ClosedXML.Extensions.Mvc, run the following command in the Package Manager Console

```
PM> Install-Package ClosedXML.Extensions.Mvc
```


## Usage
In your MVC controller define an action that will generate and download your file:

```c#
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
