using System.Windows;
using System.Windows.Forms.Integration;

namespace LaserEngineHmi.View.Controls
{
    public class PdfViewerHost : WindowsFormsHost
    {
        public static readonly DependencyProperty PdfPathProperty = DependencyProperty.Register(
            "PdfPath", typeof(string), typeof(PdfViewerHost), new PropertyMetadata(PdfPathPropertyChanged));

        private readonly AdobeReaderControl wrappedControl;

        public PdfViewerHost()
        {
            wrappedControl = new AdobeReaderControl();
            Child = wrappedControl;
        }

        public string PdfPath
        {
            get
            {
                return (string)GetValue(PdfPathProperty);
            }

            set
            {
                SetValue(PdfPathProperty, value);
            }
        }

        private static void PdfPathPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            PdfViewerHost host = (PdfViewerHost)d;
            host.wrappedControl.PdfFilePath = (string)e.NewValue;
        }
    }
}
