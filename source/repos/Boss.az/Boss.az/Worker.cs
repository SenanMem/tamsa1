using Base;
using Boss.az;
using System;
using System.Collections.Generic;
using System.Text;

namespace Worker
{
    class _Worker//buna static field atrir cv listi 3-deneden artiq sayda olmasin
    {
        public User user { get; set; }
        public string ID { get; set; }
        public string kategory { get; set; }
        public List<CV> CVs { get; set; }
        public List<MessageBox> messageBoxes { get; set; }
        public Advertising advertising { get; set; }
    }
}
