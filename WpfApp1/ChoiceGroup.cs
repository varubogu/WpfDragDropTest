﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class ChoiceGroup
    {
        public string Name { set; get; }
        public List<ChoiceExpression> Childs { set; get; }
    }
}
