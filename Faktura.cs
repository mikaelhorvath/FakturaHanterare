using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakturaHanterare
{
    /// <summary>
    /// Class handles Faktura
    /// </summary>
    class Faktura
    {
        private String invoiceNbr;
        private String ocrNbr;
        private String payDate;
        private String companyName;

        /// <summary>
        /// This Method sets/gets the InvoiceNbr
        /// </summary>
        public String InvoiceNbr
        {
            get
            {
                return this.invoiceNbr;
            }
            set
            {
                this.invoiceNbr = value;
            }
        }

        /// <summary>
        /// This method sets/gets ocrNbr
        /// </summary>
        public String OcrNbr
        {
            get
            {
                return this.ocrNbr;
            }

            set
            {
                this.ocrNbr = value;
            }
        }

        /// <summary>
        /// This method sets/gets payDate
        /// </summary>
        public String PayDate
        {
            get
            {
                return this.payDate;
            }
            set
            {
                this.payDate = value;
            }
        }

        /// <summary>
        /// This method sets/gets CompanyName
        /// </summary>
        public String CompanyName
        {
            get
            {
                return this.companyName;
            }
            set
            {
                this.companyName = value;
            }
        }

        public override string ToString()
        {
            return this.payDate +" "+ this.companyName + " " + this.invoiceNbr + " " + this.ocrNbr;
        }
    }
}
