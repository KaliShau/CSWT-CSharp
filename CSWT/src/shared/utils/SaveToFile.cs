using System;
using System.Linq;
using System.Windows.Forms;
using CSWT.src.shared.services.comment;
using CSWT.src.shared.services.ticket;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

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
        public void SaveTicketToDocx(string filePath, TicketWithJoinDTO ticket, CommentDTO[] comments)
        {
            using (WordprocessingDocument wordDocument =
                WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                mainPart.Document = new Document();
                Body body = mainPart.Document.AppendChild(new Body());

                Paragraph titleParagraph = body.AppendChild(new Paragraph());
                Run titleRun = titleParagraph.AppendChild(new Run());
                titleRun.AppendChild(new Text($"Заявка #{ticket.ID}: {ticket.title}"));

                titleRun.RunProperties = new RunProperties(
                    new Bold(),
                    new FontSize() { Val = "28" },
                    new Color() { Val = "2E74B5" }
                );
                titleParagraph.ParagraphProperties = new ParagraphProperties(
                    new Justification() { Val = JustificationValues.Center },
                    new SpacingBetweenLines() { After = "200" }
                );

                AddTicketInfo(body, "Дата создания:", ticket.created_at.ToString("dd.MM.yyyy HH:mm"));
                AddTicketInfo(body, "Дата обновления:", ticket.updated_at.ToString("dd.MM.yyyy HH:mm"));
                if (ticket.closed_at.HasValue)
                    AddTicketInfo(body, "Дата закрытия:", ticket.closed_at.Value.ToString("dd.MM.yyyy HH:mm"));
                AddTicketInfo(body, "Клиент:", ticket.client_name);
                AddTicketInfo(body, "Приоритет:", ticket.priority_name);
                AddTicketInfo(body, "Статус:", ticket.status_name);
                AddTicketInfo(body, "Исполнитель:", ticket.assigned_user_name);

                Paragraph descTitle = body.AppendChild(new Paragraph());
                Run descTitleRun = descTitle.AppendChild(new Run());
                descTitleRun.AppendChild(new Text("Описание:"));
                descTitleRun.RunProperties = new RunProperties(
                    new Bold(),
                    new FontSize() { Val = "22" }
                );
                descTitle.ParagraphProperties = new ParagraphProperties(
                    new SpacingBetweenLines() { Before = "200", After = "100" }
                );

                Paragraph descParagraph = body.AppendChild(new Paragraph());
                Run descRun = descParagraph.AppendChild(new Run());
                descRun.AppendChild(new Text(ticket.description ?? "-"));
                descRun.RunProperties = new RunProperties(
                    new FontSize() { Val = "20" }
                );

                if (!string.IsNullOrEmpty(ticket.solution))
                {
                    Paragraph solutionTitle = body.AppendChild(new Paragraph());
                    Run solutionTitleRun = solutionTitle.AppendChild(new Run());
                    solutionTitleRun.AppendChild(new Text("Решение:"));
                    solutionTitleRun.RunProperties = new RunProperties(
                        new Bold(),
                        new FontSize() { Val = "22" }
                    );
                    solutionTitle.ParagraphProperties = new ParagraphProperties(
                        new SpacingBetweenLines() { Before = "200", After = "100" }
                    );

                    Paragraph solutionParagraph = body.AppendChild(new Paragraph());
                    Run solutionRun = solutionParagraph.AppendChild(new Run());
                    solutionRun.AppendChild(new Text(ticket.solution));
                    solutionRun.RunProperties = new RunProperties(
                        new FontSize() { Val = "20" }
                    );
                }

                Paragraph commentsTitle = body.AppendChild(new Paragraph());
                Run commentsTitleRun = commentsTitle.AppendChild(new Run());
                commentsTitleRun.AppendChild(new Text("Комментарии:"));
                commentsTitleRun.RunProperties = new RunProperties(
                    new Bold(),
                    new FontSize() { Val = "24" },
                    new Color() { Val = "4472C4" }
                );
                commentsTitle.ParagraphProperties = new ParagraphProperties(
                    new SpacingBetweenLines() { Before = "300", After = "150" }
                );

                if (comments.Any())
                {
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
                        new TableWidth() { Width = "5000", Type = TableWidthUnitValues.Pct },
                        new TableLayout() { Type = TableLayoutValues.Fixed },
                        new TableLook() { Val = "04A0" }
                    );
                    table.AppendChild(tableProperties);

                    int[] columnWidths = { 1500, 1500, 2000 };

                    TableRow headerRow = new TableRow();
                    string[] headers = { "Автор", "Дата", "Комментарий" };

                    for (int i = 0; i < headers.Length; i++)
                    {
                        TableCell cell = new TableCell();
                        Run run = new Run();
                        run.AppendChild(new Text(headers[i]));
                        run.RunProperties = new RunProperties(
                            new Bold(),
                            new Color() { Val = "FFFFFF" },
                            new FontSize() { Val = "20" }
                        );

                        cell.Append(new Paragraph(run));
                        cell.TableCellProperties = new TableCellProperties(
                            new Shading() { Fill = "4472C4" },
                            new TableCellWidth() { Width = columnWidths[i].ToString(), Type = TableWidthUnitValues.Dxa },
                            new GridSpan() { Val = 1 }
                        );

                        headerRow.Append(cell);
                    }
                    table.Append(headerRow);

                    bool alternate = false;
                    foreach (var comment in comments)
                    {
                        TableRow row = new TableRow();
                        string rowColor = alternate ? "D9E1F2" : "FFFFFF";
                        alternate = !alternate;

                        TableCell authorCell = CreateTableCell(
                            $"{comment.last_name} {comment.first_name}",
                            rowColor,
                            columnWidths[0],
                            JustificationValues.Left);

                        TableCell dateCell = CreateTableCell(
                            comment.created_at.ToString("dd.MM.yyyy HH:mm"),
                            rowColor,
                            columnWidths[1],
                            JustificationValues.Center);

                        TableCell commentCell = CreateTableCell(
                            comment.comment_text,
                            rowColor,
                            columnWidths[2],
                            JustificationValues.Left);

                        row.Append(authorCell);
                        row.Append(dateCell);
                        row.Append(commentCell);
                        table.Append(row);
                    }

                    body.Append(table);
                }
                else
                {
                    Paragraph noComments = body.AppendChild(new Paragraph());
                    Run noCommentsRun = noComments.AppendChild(new Run());
                    noCommentsRun.AppendChild(new Text("Нет комментариев"));
                    noCommentsRun.RunProperties = new RunProperties(
                        new Italic(),
                        new FontSize() { Val = "20" },
                        new Color() { Val = "7F7F7F" }
                    );
                    noComments.ParagraphProperties = new ParagraphProperties(
                        new Justification() { Val = JustificationValues.Center },
                        new SpacingBetweenLines() { Before = "150", After = "150" }
                    );
                }

                Paragraph footerParagraph = body.AppendChild(new Paragraph());
                Run footerRun = footerParagraph.AppendChild(new Run());
                footerRun.AppendChild(new Text($"Сгенерировано: {DateTime.Now:dd.MM.yyyy HH:mm} | Система CSWT"));
                footerRun.RunProperties = new RunProperties(
                    new Italic(),
                    new FontSize() { Val = "16" },
                    new Color() { Val = "7F7F7F" }
                );
                footerParagraph.ParagraphProperties = new ParagraphProperties(
                    new Justification() { Val = JustificationValues.Right },
                    new SpacingBetweenLines() { Before = "300" }
                );
            }
        }

        private void AddTicketInfo(Body body, string title, string value)
        {
            Paragraph paragraph = body.AppendChild(new Paragraph());
            Run run = paragraph.AppendChild(new Run());

            Run titleRun = new Run();
            titleRun.AppendChild(new Text(title + " "));
            titleRun.RunProperties = new RunProperties(
                new Bold(),
                new FontSize() { Val = "20" }
            );

            Run valueRun = new Run();
            valueRun.AppendChild(new Text(value));
            valueRun.RunProperties = new RunProperties(
                new FontSize() { Val = "20" }
            );

            run.Append(titleRun);
            run.Append(valueRun);

            paragraph.ParagraphProperties = new ParagraphProperties(
                new SpacingBetweenLines() { After = "100" }
            );
        }
        private TableCell CreateTableCell(string text, string fillColor, int width, JustificationValues alignment)
        {
            TableCell cell = new TableCell();
            Run run = new Run();
            run.AppendChild(new Text(text));
            run.RunProperties = new RunProperties(new FontSize() { Val = "18" });

            cell.Append(new Paragraph(new ParagraphProperties(
                new Justification() { Val = alignment }
            ), run));

            cell.TableCellProperties = new TableCellProperties(
                new Shading() { Fill = fillColor },
                new TableCellWidth() { Width = width.ToString(), Type = TableWidthUnitValues.Dxa },
                new GridSpan() { Val = 1 },
                new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center }
            );

            return cell;
        }
    }
}
