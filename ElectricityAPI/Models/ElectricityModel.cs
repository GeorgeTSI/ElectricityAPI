using System.Numerics;

namespace ElectricityAPI.Models
{
    public class ElectricityModel
    {
        public string? TINKLAS { get; set; }
        public string? OBT_PAVADINIMAS { get; set; }
        public string? OBJ_GV_TIPAS { get; set; }
        public int OBJ_NUMERIS { get; set; }
        public float Pplus { get; set; }
        public DateTime PL_T { get; set; }
        public float Pminus { get; set; }
    }
}








