using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaserEngineHmi.View.Controls
{
    public partial class AdobeReaderControl : UserControl
    {
        private string pdfFilePath;

        public AdobeReaderControl()
        {
            InitializeComponent();
            axAcroPdfDrawing.setShowToolbar(false);
            axAcroPdfDrawing.setView("FitH");
        }

        public string PdfFilePath
        {
            get
            {
                return pdfFilePath;
            }

            set
            {
                if (pdfFilePath != value)
                {
                    pdfFilePath = value;
                    ChangeCurrentDisplayedPdf();
                }
            }
        }

        private void ChangeCurrentDisplayedPdf()
        {
            if (PdfFilePath == null) axAcroPdfDrawing.Visible = false;
            else axAcroPdfDrawing.Visible = true;
            axAcroPdfDrawing.LoadFile(PdfFilePath);
            axAcroPdfDrawing.src = PdfFilePath;
            axAcroPdfDrawing.setViewScroll("FitH", 0);

        }
    }
}
