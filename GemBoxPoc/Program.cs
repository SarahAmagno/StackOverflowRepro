using System.IO;
using GemBox.Document;

ComponentInfo.SetLicense("LICENSE KEY");

var pages = DocumentModel.Load("crash.html").GetPaginator().Pages;

for (var index = 0; index < pages.Count; index++)
{
    var fileName = $"Page-{index}.bmp";
            
    var page = pages[index];
            
    using var stream = new FileStream(Path.Combine(@"..\..\..\OutputFiles", fileName), FileMode.Create);
            
    page.Save(stream, new ImageSaveOptions(ImageSaveFormat.Bmp));
}