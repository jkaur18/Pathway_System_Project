﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathway_System.Entities.DTOs
{
     public class ProgramByType
    {
        public string ProgramName { get; set; }
        public string CredentialType { get; set; }
        public string CategoryName { get; set; }
        public int CategoryID { get; set; }
        public string CategoryDescription { get; set; }
        public int ProgramID { get; set; }
    }
}
