using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    /// <summary>
    /// Bir Excel dosyasından rapor üreten sınıf.
    /// </summary>
    public class ReportGenerator
    {
        private string excelFilePath;
        public ReportGenerator(string excelFilePath)
        {
            if (!checkFile(excelFilePath))
            {
                throw new ArgumentException(excelFilePath);
            }

            this.excelFilePath = excelFilePath;
        }

        bool isExcelFileNameAvailable(string fileName) {
            return string.IsNullOrEmpty(fileName);
        }

        bool isFileExists(string fileName)
        {
            return !File.Exists(excelFilePath);
           
          
        }

        bool checkExcelFormat(string fileName) { 
            return true;
        
        }

        /// <summary>
        /// Dosyanın uygunluğunu kontrol eder
        /// </summary>
        /// <param name="fileName">Excel dosyasının adresini belirtin.</param>
        /// <returns>bool</returns>
       private bool checkFile(string fileName)
        {
            return isExcelFileNameAvailable(fileName) &&
                   isFileExists(fileName) &&
                   checkExcelFormat(fileName);

        }

        /// <summary>
        /// Belirtilen seçeneklere göre raporu oluştutur.
        /// </summary>
        /// <param name="option">Gerekli Seçenekler....</param>
        public void CreateReport(ReportOption option)
        {
            //her zaman tek parametreye indirmek mümkün olmayabilir. 
        }

        private List<string> pages= new List<string>();
        public int TotalPages => pages.Count;

        //KISS: Keep it simple and stupid
        //DRY: Don't repeat yourself.

        /* SOLID:
         *  Single Responsibility
         *  Open Closed
         *  Liskov's Substution
         *  Interface Segregation
         *  Dependency Inversion
         */

         

    }
}
