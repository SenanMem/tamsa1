using Boss.az;
using Employer;
using System;
using System.Collections.Generic;
using System.Text;
using Worker;

namespace Base
{
    class DataBase
    {
        public List<_Worker> workers { get; set; }
        public List<_Employer> employers { get; set; }
        public List<CV> workerCVs { get; set; } //iscilerin hazir CV-leri
        public List<CV> employerCVs { get; set; } //is verenlerin hazir CV-leri
        public List<string> category { get; set; }
        public StringBuilder informationAbout { get; set; }
        public ChatBot chatBot { get; set; }
        public List<Admin> admins { get; set; }
    }
}
