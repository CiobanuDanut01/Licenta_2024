using System;
using System.IO;
using DinkToPdf;
using DinkToPdf.Contracts;
using Orientation = DinkToPdf.Orientation;

namespace Licenta
{
    public sealed class Dummy
    {
        public static readonly IConverter converter = new SynchronizedConverter(new PdfTools());
        private Dummy() { }
    }

    public class HtmlToPdfConverter
    {


        public HtmlToPdfConverter()
        {
            var context = new CustomAssemblyLoadContext();
            context.LoadUnmanagedLibrary(Path.Combine(AppContext.BaseDirectory, "libwkhtmltox.dll"));
        }

        public void ConvertHtmlToPdf(string htmlContent, string outputPdfPath)
        {

            var doc = new HtmlToPdfDocument()
            {
                GlobalSettings =
                {
                    ColorMode = ColorMode.Color,
                    Orientation = Orientation.Portrait,
                    PaperSize = PaperKind.A4,
                    Out = outputPdfPath
                },
                Objects =
                {
                    new ObjectSettings()
                    {
                        PagesCount = true,
                        HtmlContent = htmlContent,
                        WebSettings = { DefaultEncoding = "utf-8" },
                        HeaderSettings =
                            { FontName = "Arial", FontSize = 12, Right = "Page [page] of [toPage]", Line = true }
                    }
                }
            };
            Dummy.converter.Convert(doc);
        }
    }

    // Helper class for loading the unmanaged wkhtmltopdf library
    public class CustomAssemblyLoadContext : System.Runtime.Loader.AssemblyLoadContext
    {
        public IntPtr LoadUnmanagedLibrary(string absolutePath)
        {
            return LoadUnmanagedDll(absolutePath);
        }

        protected override IntPtr LoadUnmanagedDll(string unmanagedDllName)
        {
            return LoadUnmanagedDllFromPath(unmanagedDllName);
        }

        protected override System.Reflection.Assembly Load(System.Reflection.AssemblyName assemblyName)
        {
            throw new NotImplementedException();
        }
    }
}
