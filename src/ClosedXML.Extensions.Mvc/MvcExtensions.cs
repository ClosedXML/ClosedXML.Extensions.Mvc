using ClosedXML.Excel;
using System.IO;
using System.Web.Mvc;

namespace ClosedXML.Extensions
{
    public static class MvcExtensions
    {
        public static FileStreamResult Deliver(this XLWorkbook workbook, string fileName, string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
        {
            var memoryStream = new MemoryStream();

            workbook.SaveAs(memoryStream);
            memoryStream.Seek(0, SeekOrigin.Begin);

            return new FileStreamResult(memoryStream, contentType)
            {
                FileDownloadName = fileName
            };

        }
    }
}
