using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using CSWT.src.shared.services.comment;
using CSWT.src.shared.services.ticket;

namespace CSWT.src.shared.utils
{
    public class PrintReport
    {
        private ListView _listView;
        private string _reportTitle;
        private int _currentRowIndex;
        private int _pageNumber;
        private Font _titleFont;
        private Font _dateFont;
        private Font _headerFont;
        private Font _contentFont;
        private Font _footerFont;
        private Brush _headerBrush;
        private Brush _rowBrush;
        private Brush _alternateRowBrush;
        private Brush _textBrush;
        private Brush _footerBrush;
        private Pen _borderPen;

        public void Print(ListView listView, string reportTitle)
        {
            _listView = listView;
            _reportTitle = reportTitle;
            _currentRowIndex = 0;
            _pageNumber = 1;

            InitializeStyles();

            using (PrintDocument printDoc = new PrintDocument())
            {
                printDoc.PrintPage += new PrintPageEventHandler(PrintPageHandler);

                using (PrintPreviewDialog previewDialog = new PrintPreviewDialog())
                {
                    previewDialog.Document = printDoc;
                    previewDialog.ShowDialog();
                }

                // Если нужно сразу печатать без предпросмотра:
                // printDoc.Print();
            }
        }

        private void InitializeStyles()
        {
            _titleFont = new Font("Arial", 16, FontStyle.Bold);
            _dateFont = new Font("Arial", 12, FontStyle.Italic);
            _headerFont = new Font("Arial", 11, FontStyle.Bold);
            _contentFont = new Font("Arial", 10);
            _footerFont = new Font("Arial", 9, FontStyle.Italic);

            _headerBrush = new SolidBrush(Color.FromArgb(68, 114, 196));
            _rowBrush = Brushes.White;
            _alternateRowBrush = new SolidBrush(Color.FromArgb(217, 225, 242));
            _textBrush = Brushes.Black;
            _footerBrush = new SolidBrush(Color.FromArgb(127, 127, 127));

            _borderPen = new Pen(Color.Black, 1);
        }

        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            float yPos = topMargin;

            SizeF titleSize = g.MeasureString(_reportTitle, _titleFont);
            g.DrawString(_reportTitle, _titleFont, Brushes.Blue,
                leftMargin + (e.MarginBounds.Width - titleSize.Width) / 2, yPos);
            yPos += titleSize.Height + 20;

            string dateString = $"Сгенерировано: {DateTime.Now:dd.MM.yyyy HH:mm}";
            SizeF dateSize = g.MeasureString(dateString, _dateFont);
            g.DrawString(dateString, _dateFont, _footerBrush,
                leftMargin + (e.MarginBounds.Width - dateSize.Width) / 2, yPos);
            yPos += dateSize.Height + 30;

            float[] columnWidths = new float[_listView.Columns.Count];
            float totalWidth = 0;

            for (int i = 0; i < _listView.Columns.Count; i++)
            {
                columnWidths[i] = _listView.Columns[i].Width * 0.8f;
                totalWidth += columnWidths[i];
            }

            if (totalWidth > e.MarginBounds.Width)
            {
                float scale = e.MarginBounds.Width / totalWidth;
                for (int i = 0; i < columnWidths.Length; i++)
                {
                    columnWidths[i] *= scale;
                }
                totalWidth = e.MarginBounds.Width;
            }

            float xPos = leftMargin;
            float rowHeight = _headerFont.GetHeight() + 10;

            for (int i = 0; i < _listView.Columns.Count; i++)
            {
                RectangleF headerRect = new RectangleF(xPos, yPos, columnWidths[i], rowHeight);
                g.FillRectangle(_headerBrush, headerRect);
                g.DrawRectangle(_borderPen, Rectangle.Round(headerRect));

                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;

                g.DrawString(_listView.Columns[i].Text, _headerFont, Brushes.White, headerRect, sf);
                xPos += columnWidths[i];
            }
            yPos += rowHeight;

            bool alternate = false;
            while (_currentRowIndex < _listView.Items.Count)
            {
                xPos = leftMargin;
                float maxCellHeight = 0;

                if (yPos + rowHeight > e.MarginBounds.Bottom)
                {
                    PrintFooter(g, e, ref yPos);
                    e.HasMorePages = true;
                    _pageNumber++;
                    return;
                }

                for (int i = 0; i < _listView.Columns.Count; i++)
                {
                    string cellText = _listView.Items[_currentRowIndex].SubItems[i].Text ?? "-";
                    SizeF cellSize = g.MeasureString(cellText, _contentFont, (int)columnWidths[i]);

                    float cellHeight = cellSize.Height + 10;
                    if (cellHeight > maxCellHeight) maxCellHeight = cellHeight;

                    RectangleF cellRect = new RectangleF(xPos, yPos, columnWidths[i], cellHeight);
                    g.FillRectangle(alternate ? _alternateRowBrush : _rowBrush, cellRect);
                    g.DrawRectangle(_borderPen, Rectangle.Round(cellRect));

                    StringFormat sf = new StringFormat();
                    sf.Alignment = StringAlignment.Near;
                    sf.LineAlignment = StringAlignment.Center;
                    sf.Trimming = StringTrimming.EllipsisCharacter;
                    sf.FormatFlags = StringFormatFlags.LineLimit;

                    g.DrawString(cellText, _contentFont, _textBrush,
                        new RectangleF(xPos + 5, yPos, columnWidths[i] - 10, cellHeight), sf);
                    xPos += columnWidths[i];
                }

                yPos += maxCellHeight;
                _currentRowIndex++;
                alternate = !alternate;
            }

            PrintFooter(g, e, ref yPos);
            e.HasMorePages = false;
        }

        private void PrintFooter(Graphics g, PrintPageEventArgs e, ref float yPos)
        {
            string footerText = $"Сгенерировано системой CSWT - Страница {_pageNumber}";
            SizeF footerSize = g.MeasureString(footerText, _footerFont);

            if (yPos + footerSize.Height > e.MarginBounds.Bottom)
            {
                yPos = e.MarginBounds.Bottom - footerSize.Height;
            }

            g.DrawString(footerText, _footerFont, _footerBrush,
                e.MarginBounds.Right - footerSize.Width, yPos);
            yPos += footerSize.Height;
        }
    }

    public class PrintTicket
    {
        private TicketWithJoinDTO _ticket;
        private CommentDTO[] _comments;
        private int _currentRowIndex;
        private int _pageNumber;

        private Font _titleFont;
        private Font _subtitleFont;
        private Font _headerFont;
        private Font _contentFont;
        private Font _footerFont;
        private Brush _titleBrush;
        private Brush _subtitleBrush;
        private Brush _headerBrush;
        private Brush _contentBrush;
        private Brush _footerBrush;
        private Brush _alternateBrush;
        private Pen _borderPen;

        public void Print(TicketWithJoinDTO ticket, CommentDTO[] comments)
        {
            _ticket = ticket;
            _comments = comments;
            _currentRowIndex = 0;
            _pageNumber = 1;

            InitializeStyles();

            using (PrintDocument printDoc = new PrintDocument())
            {
                printDoc.PrintPage += new PrintPageEventHandler(PrintTicketPageHandler);

                using (PrintPreviewDialog previewDialog = new PrintPreviewDialog())
                {
                    previewDialog.Document = printDoc;
                    previewDialog.ShowDialog();
                }
            }
        }

        private void InitializeStyles()
        {
            _titleFont = new Font("Arial", 20, FontStyle.Bold);
            _subtitleFont = new Font("Arial", 12);
            _headerFont = new Font("Arial", 11, FontStyle.Bold);
            _contentFont = new Font("Arial", 10);
            _footerFont = new Font("Arial", 9, FontStyle.Italic);

            _titleBrush = new SolidBrush(Color.FromArgb(46, 116, 181));
            _subtitleBrush = Brushes.Black;
            _headerBrush = new SolidBrush(Color.FromArgb(68, 114, 196));
            _contentBrush = Brushes.Black;
            _footerBrush = new SolidBrush(Color.FromArgb(127, 127, 127));
            _alternateBrush = new SolidBrush(Color.FromArgb(217, 225, 242));

            _borderPen = new Pen(Color.Black, 1);
        }

        private void PrintTicketPageHandler(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            float yPos = topMargin;

            string title = $"Заявка #{_ticket.ID}: {_ticket.title}";
            SizeF titleSize = g.MeasureString(title, _titleFont);
            g.DrawString(title, _titleFont, _titleBrush,
                leftMargin + (e.MarginBounds.Width - titleSize.Width) / 2, yPos);
            yPos += titleSize.Height + 20;

            PrintTicketInfo(g, ref yPos, leftMargin, "Дата создания:", _ticket.created_at.ToString("dd.MM.yyyy HH:mm"));
            PrintTicketInfo(g, ref yPos, leftMargin, "Дата обновления:", _ticket.updated_at.ToString("dd.MM.yyyy HH:mm"));

            if (_ticket.closed_at.HasValue)
            {
                PrintTicketInfo(g, ref yPos, leftMargin, "Дата закрытия:", _ticket.closed_at.Value.ToString("dd.MM.yyyy HH:mm"));
            }

            PrintTicketInfo(g, ref yPos, leftMargin, "Клиент:", _ticket.client_name);
            PrintTicketInfo(g, ref yPos, leftMargin, "Приоритет:", _ticket.priority_name);
            PrintTicketInfo(g, ref yPos, leftMargin, "Статус:", _ticket.status_name);
            PrintTicketInfo(g, ref yPos, leftMargin, "Исполнитель:", _ticket.assigned_user_name);
            yPos += 20;

            PrintSectionHeader(g, ref yPos, leftMargin, "Описание:");
            yPos = PrintMultilineText(g, _ticket.description ?? "-", leftMargin, yPos, e.MarginBounds.Right);
            yPos += 20;

            if (!string.IsNullOrEmpty(_ticket.solution))
            {
                PrintSectionHeader(g, ref yPos, leftMargin, "Решение:");
                yPos = PrintMultilineText(g, _ticket.solution, leftMargin, yPos, e.MarginBounds.Right);
                yPos += 20;
            }

            PrintSectionHeader(g, ref yPos, leftMargin, "Комментарии:");

            if (_comments.Length > 0)
            {
                float[] columnWidths = { 150, 150, e.MarginBounds.Width - 300 }; // Ширина колонок
                float rowHeight = _headerFont.GetHeight() + 10;
                float xPos = leftMargin;

                if (yPos + rowHeight > e.MarginBounds.Bottom)
                {
                    PrintFooter(g, e, ref yPos);
                    e.HasMorePages = true;
                    _pageNumber++;
                    return;
                }

                string[] headers = { "Автор", "Дата", "Комментарий" };
                for (int i = 0; i < headers.Length; i++)
                {
                    RectangleF headerRect = new RectangleF(xPos, yPos, columnWidths[i], rowHeight);
                    g.FillRectangle(_headerBrush, headerRect);
                    g.DrawRectangle(_borderPen, Rectangle.Round(headerRect));

                    StringFormat sf = new StringFormat();
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;

                    g.DrawString(headers[i], _headerFont, Brushes.White, headerRect, sf);
                    xPos += columnWidths[i];
                }
                yPos += rowHeight;

                bool alternate = false;
                while (_currentRowIndex < _comments.Length)
                {
                    var comment = _comments[_currentRowIndex];
                    xPos = leftMargin;
                    float maxCellHeight = 0;

                    if (yPos + rowHeight > e.MarginBounds.Bottom)
                    {
                        PrintFooter(g, e, ref yPos);
                        e.HasMorePages = true;
                        _pageNumber++;
                        return;
                    }

                    string author = $"{comment.last_name} {comment.first_name}";
                    float authorHeight = PrintTableCell(g, author, xPos, yPos, columnWidths[0],
                        alternate ? _alternateBrush : Brushes.White,
                        StringAlignment.Near);
                    if (authorHeight > maxCellHeight) maxCellHeight = authorHeight;
                    xPos += columnWidths[0];

                    string date = comment.created_at.ToString("dd.MM.yyyy HH:mm");
                    float dateHeight = PrintTableCell(g, date, xPos, yPos, columnWidths[1],
                        alternate ? _alternateBrush : Brushes.White,
                        StringAlignment.Center);
                    if (dateHeight > maxCellHeight) maxCellHeight = dateHeight;
                    xPos += columnWidths[1];

                    float commentHeight = PrintTableCell(g, comment.comment_text, xPos, yPos, columnWidths[2],
                        alternate ? _alternateBrush : Brushes.White,
                        StringAlignment.Near);
                    if (commentHeight > maxCellHeight) maxCellHeight = commentHeight;

                    yPos += maxCellHeight;
                    _currentRowIndex++;
                    alternate = !alternate;
                }
            }
            else
            {
                string noComments = "Нет комментариев";
                SizeF noCommentsSize = g.MeasureString(noComments, _contentFont);
                g.DrawString(noComments, _contentFont, _footerBrush,
                    leftMargin + (e.MarginBounds.Width - noCommentsSize.Width) / 2, yPos);
                yPos += noCommentsSize.Height + 20;
            }

            PrintFooter(g, e, ref yPos);
            e.HasMorePages = false;
        }

        private void PrintTicketInfo(Graphics g, ref float yPos, float leftMargin, string label, string value)
        {
            string text = $"{label} {value}";
            g.DrawString(text, _subtitleFont, _subtitleBrush, leftMargin, yPos);
            yPos += _subtitleFont.GetHeight() + 5;
        }

        private void PrintSectionHeader(Graphics g, ref float yPos, float leftMargin, string text)
        {
            g.DrawString(text, _headerFont, _titleBrush, leftMargin, yPos);
            yPos += _headerFont.GetHeight() + 10;
        }

        private float PrintMultilineText(Graphics g, string text, float x, float y, float maxWidth)
        {
            StringFormat sf = new StringFormat();
            sf.Trimming = StringTrimming.Word;

            SizeF size = g.MeasureString(text, _contentFont, (int)maxWidth, sf);
            RectangleF rect = new RectangleF(x, y, maxWidth, size.Height);
            g.DrawString(text, _contentFont, _contentBrush, rect, sf);

            return y + size.Height;
        }

        private float PrintTableCell(Graphics g, string text, float x, float y, float width, Brush background, StringAlignment alignment)
        {
            StringFormat sf = new StringFormat();
            sf.Alignment = alignment;
            sf.LineAlignment = StringAlignment.Center;
            sf.Trimming = StringTrimming.EllipsisWord;
            sf.FormatFlags = StringFormatFlags.LineLimit;

            SizeF size = g.MeasureString(text, _contentFont, (int)width, sf);
            RectangleF rect = new RectangleF(x, y, width, size.Height + 10);

            g.FillRectangle(background, rect);
            g.DrawRectangle(_borderPen, rect.X, rect.Y, rect.Width, rect.Height);
            g.DrawString(text, _contentFont, _contentBrush,
                new RectangleF(x + 5, y, width - 10, size.Height + 10), sf);

            return rect.Height;
        }

        private void PrintFooter(Graphics g, PrintPageEventArgs e, ref float yPos)
        {
            string footerText = $"Сгенерировано: {DateTime.Now:dd.MM.yyyy HH:mm} | Система CSWT | Страница {_pageNumber}";
            SizeF footerSize = g.MeasureString(footerText, _footerFont);

            if (yPos + footerSize.Height > e.MarginBounds.Bottom)
            {
                yPos = e.MarginBounds.Bottom - footerSize.Height;
            }

            g.DrawString(footerText, _footerFont, _footerBrush,
                e.MarginBounds.Right - footerSize.Width, yPos);
            yPos += footerSize.Height;
        }
    }
}
