using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml;
using System.Windows.Forms;

namespace CSWT.src.shared.utils
{
    public class SaveToFile
    {
        public void SaveReportToDocx(string filePath, ListView listView, string reportTitle)
        {
            using (WordprocessingDocument wordDocument =
                WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                mainPart.Document = new Document();
                Body body = mainPart.Document.AppendChild(new Body());

                Paragraph titleParagraph = body.AppendChild(new Paragraph());
                Run titleRun = titleParagraph.AppendChild(new Run());
                titleRun.AppendChild(new Text(reportTitle));

                titleRun.RunProperties = new RunProperties(
                    new Bold(),
                    new FontSize() { Val = "28" },
                    new Color() { Val = "2E74B5" } 
                );
                titleParagraph.ParagraphProperties = new ParagraphProperties(
                    new Justification() { Val = JustificationValues.Center },
                    new SpacingBetweenLines() { After = "200" } 
                );

                Paragraph dateParagraph = body.AppendChild(new Paragraph());
                Run dateRun = dateParagraph.AppendChild(new Run());
                dateRun.AppendChild(new Text($"Сгенерировано: {DateTime.Now:dd.MM.yyyy HH:mm}"));
                dateRun.RunProperties = new RunProperties(
                    new Italic(),
                    new FontSize() { Val = "20" },
                    new Color() { Val = "7F7F7F" } 
                );
                dateParagraph.ParagraphProperties = new ParagraphProperties(
                    new Justification() { Val = JustificationValues.Center },
                    new SpacingBetweenLines() { After = "300" }
                );

                Table table = new Table();

                TableProperties tableProperties = new TableProperties(
                    new TableBorders(
                        new TopBorder() { Val = BorderValues.Single, Size = 8, Color = "000000" },
                        new BottomBorder() { Val = BorderValues.Single, Size = 8, Color = "000000" },
                        new LeftBorder() { Val = BorderValues.Single, Size = 8, Color = "000000" },
                        new RightBorder() { Val = BorderValues.Single, Size = 8, Color = "000000" },
                        new InsideHorizontalBorder() { Val = BorderValues.Single, Size = 4, Color = "000000" },
                        new InsideVerticalBorder() { Val = BorderValues.Single, Size = 4, Color = "000000" }
                    ),
                    new TableWidth() { Width = "100%", Type = TableWidthUnitValues.Pct },
                    new TableLayout() { Type = TableLayoutValues.Fixed }
                );
                table.AppendChild(tableProperties);

                TableRow headerRow = new TableRow();
                foreach (ColumnHeader column in listView.Columns)
                {
                    TableCell cell = new TableCell();
                    cell.Append(new Paragraph(new Run(new Text(column.Text))
                    {
                        RunProperties = new RunProperties(
                            new Bold(),
                            new Color() { Val = "FFFFFF" }, 
                            new FontSize() { Val = "22" }
                        )
                    }));

                    cell.TableCellProperties = new TableCellProperties(
                        new Shading() { Fill = "4472C4" }, 
                        new TableCellWidth() { Width = "2000", Type = TableWidthUnitValues.Dxa }
                    );

                    headerRow.Append(cell);
                }
                table.Append(headerRow);

                bool alternate = false;
                foreach (ListViewItem item in listView.Items)
                {
                    TableRow row = new TableRow();

                    string rowColor = alternate ? "D9E1F2" : "FFFFFF";
                    alternate = !alternate;

                    foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                    {
                        TableCell cell = new TableCell();
                        cell.Append(new Paragraph(new Run(new Text(subItem.Text ?? "-"))
                        {
                            RunProperties = new RunProperties(
                                new FontSize() { Val = "20" }
                            )
                        }));

                        cell.TableCellProperties = new TableCellProperties(
                            new Shading() { Fill = rowColor },
                            new TableCellWidth() { Width = "2000", Type = TableWidthUnitValues.Dxa }
                        );

                        row.Append(cell);
                    }
                    table.Append(row);
                }

                body.Append(table);

                Paragraph footerParagraph = body.AppendChild(new Paragraph());
                Run footerRun = footerParagraph.AppendChild(new Run());
                footerRun.AppendChild(new Text("Сгенерировано системой CSWT"));
                footerRun.RunProperties = new RunProperties(
                    new Italic(),
                    new FontSize() { Val = "18" },
                    new Color() { Val = "7F7F7F" }
                );
                footerParagraph.ParagraphProperties = new ParagraphProperties(
                    new Justification() { Val = JustificationValues.Right },
                    new SpacingBetweenLines() { Before = "300" }
                );
            }
        }
    }
}
