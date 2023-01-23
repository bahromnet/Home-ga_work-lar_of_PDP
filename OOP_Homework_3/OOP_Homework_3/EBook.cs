using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_3
{
    public class EBook : Book
    {
        private string downloadSite;
        private double size;

        public EBook(string downloadSite, double size) 
            : base()
        {
            this.downloadSite = downloadSite;
            this.size = size;
        }
        public string DownloadSite
        {
            get { return downloadSite; }
            set { downloadSite = value; }
        }
        public double Size
        {
            get { return size;}
            set { size = value; }
        }
        
        public string PrintTitle()
        {
            return Title;
        }
    }
}
