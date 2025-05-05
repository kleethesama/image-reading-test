using Tesseract;

string text;
using (var engine = new TesseractEngine(@"C:\Users\fck\source\repos\image-reading-test\image-reading-test\TessData",
    "eng",
    EngineMode.Default))
{
    using Pix? image = Pix.LoadFromFile(@"C:\Users\fck\source\repos\image-reading-test\image-reading-test\test-plate.jpg");
    using Page? page = engine.Process(image);
    text = page.GetText().Trim();
}

string textNoWhiteSpace = String.Concat(text.Where(c => !Char.IsWhiteSpace(c)));

Console.WriteLine(textNoWhiteSpace);

//File.WriteAllText(@"C:\output.txt", text);