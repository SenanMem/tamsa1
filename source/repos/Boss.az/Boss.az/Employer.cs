using Base;
using Boss.az;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Employer
{
    class _Employer:User
    {
        public User user { get; set; }
        public string ID { get; set; }
        public string kategory { get; set; }
        public List<CV> JobAnnouncements { get; set; }
        public Dictionary<string, string> messageBoxes { get; set; }
        public Advertising advertising { get; set; }
    }
}
