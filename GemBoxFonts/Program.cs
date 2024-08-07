using GemBox.Document;

class Program
{
    static void Main()
    {
        FontSettings.FontsBaseDirectory = Path.Combine(AppContext.BaseDirectory, "Assets/PrivateFonts");
        FontSettings.FontsBaseResourceLocation = Path.Combine(AppContext.BaseDirectory, "/Assets/AssemblyFonts/");
        ComponentInfo.SetLicense("FREE-LIMITED-KEY");

        DocumentModel document = new DocumentModel();
        Section section = new Section(document);
        document.Sections.Add(section);

        Run robotoRun = new Run(document, "Assembly Font Tiny5")
        {
            CharacterFormat = new CharacterFormat
            {
                FontName = "Tiny5"
            }
        };
        Run playWriteRun = new Run(document, "Private Font Playwrite CU")
        {
            CharacterFormat = new CharacterFormat
            {
                FontName = "Playwrite CU"
            }
        };

        Paragraph paragraph1 = new Paragraph(document);
        Paragraph paragraph2 = new Paragraph(document);
        section.Blocks.Add(paragraph1);
        section.Blocks.Add(paragraph2);
        paragraph1.Inlines.Add(robotoRun);
        paragraph2.Inlines.Add(playWriteRun);

        document.Save("HelloWorld.pdf");
    }
}