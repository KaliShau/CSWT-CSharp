using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
}
