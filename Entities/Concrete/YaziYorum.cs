﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class YaziYorum
    {
        public int YaziId { get; set; }
        public Yazi Yaz { get; set; }
        public int YorumId { get; set; }
        public Yorum Yorum { get; set; }
    }
}
