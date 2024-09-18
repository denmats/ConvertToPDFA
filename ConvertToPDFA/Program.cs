using System;
using System.IO;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Parsing;




namespace ConvertToPDFA
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
