using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Printing;
using System.IO;
using System.IO.Ports;
using System.Web;
using System.Windows.Forms;

namespace NhuaTienPhong.Core.Helper
{
    public class GeneralHelper
    {
        public static bool IsNumericType(Type type)
        {
            HashSet<Type> NumericTypes = new HashSet<Type>
            {
                typeof(decimal), typeof(byte), typeof(sbyte),
                typeof(short), typeof(ushort), typeof(float)
            };
            return NumericTypes.Contains(type) || NumericTypes.Contains(Nullable.GetUnderlyingType(type));
        }

        public static bool IsStringDouble(string stringNumber)
        {
            double number;
            return double.TryParse(stringNumber, out number);
        }

        public static void ExportExcel(DevExpress.XtraGrid.GridControl gridControl)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Excel|*.xls;*.xlsx";
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    gridControl.ExportToXlsx(saveFileDialog1.FileName);
                    // Open the created XLSX file with the default application. 
                    try
                    {
                        Process.Start(saveFileDialog1.FileName);
                    }
                    catch { }
                }
            }
            catch { }

        }

        public static bool ValidPrinter(string printerName)
        {
            bool result = false;
            try
            {
                foreach (string prtName in PrinterSettings.InstalledPrinters)
                {
                    if (printerName == prtName)
                    {
                        result = true;
                        break;
                    }
                }
            }
            catch { }
            return result;
        }

        public static bool ValidPortCOM(string portCOM)
        {
            bool result = false;
            try
            {
                foreach (string portName in SerialPort.GetPortNames())
                {
                    if (portCOM == portName)
                    {
                        result = true;
                        break;
                    }
                }
            }
            catch { }
            return result;
        }
    }
}