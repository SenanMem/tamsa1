using Base;
using Boss.az;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employer
{
    class _Employer
    {
        public User user { get; set; }
        public string ID { get; set; }
        public string kategory { get; set; }
        public List<CV> JobAnnouncements { get; set; }
        public List<MessageBox> messageBoxes { get; set; }
        public Advertising advertising { get; set; }


    }
}
