using System.Collections.Generic;

namespace Core.Entity
{
    public class Province
    {
        public int ProvinceId { get; set; }
        public string ProvinceName { get; set; }
        public List<Municipality> Municipalities { get; set; }
    }
}