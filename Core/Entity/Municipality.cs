﻿using System.Collections.Generic;

namespace Core.Entity
{
    public class Municipality
    {
        public int MunicipalityId { get; set; }
        public string MunicipalityName { get; set; }
        public Province Province { get; set; }

        public List<Branch> Branches { get; set; }
    }
}