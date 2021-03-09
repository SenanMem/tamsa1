using Boss.az;
using Employer;
using System;
using System.Collections.Generic;
using System.Text;
using _Worker;
using System.Collections;

namespace Base
{
    class DataBase
    {
        public List<Worker> workers { get; set; } = null;
        public List<_Employer> employers { get; set; } = null;
        public List<CV> workerCVs { get; set; } = null; //iscilerin hazir CV-leri
        public List<CV> employerCVs { get; set; } = null; //is verenlerin hazir CV-leri
        public Dictionary<string,string> category { get; set; } = null;
        public StringBuilder informationAbout { get; set; } = null;
        public ChatBot chatBot { get; set; } = null;
        public List<Admin> admins { get; set; } = null;
       
    }
}
