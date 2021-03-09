using Base;
using Boss.az;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _Worker
{
    class Worker:User
    {
     
        public string ID { get; set; }
        public string kategory { get; set; }
        public List<CV> CVs { get; set; }
        public Dictionary<string, string> messageBoxes { get; set; }
        public Advertising advertising { get; set; }
    }
}
