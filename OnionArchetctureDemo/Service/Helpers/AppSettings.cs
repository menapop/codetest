﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Helpers
{
    public class AppSettings
    {
        public string Secret { get; set; }
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public string ConnectionString { get; set; }
        public EmailSetting EmailSetting{ get; set; }

    }


}
