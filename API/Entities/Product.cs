using System;

namespace API.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public char Type { get; set; }         // 0/1 plan /addon
        public char Period { get; set; }       // montly / yearly 0/1
        public string Name { get; set; }
        public string Desc { get; set; }
        public long Price { get; set; }
        public string Comment { get; set; }
        public char Active{ get; set; }         // Not/Active/Canceled  0/1/2
        public char Swap  { get; set; }         // 0/1 (Only can swap once per/ Can swap files in your gallery at any time)
        public char SearchFr { get; set; }      // Once per month / Weekly / Daily 0/1/2 , 3 - 3 times daily​+manually
        public char Notifications { get; set; } // None / Either SMS or email / SMS, email, or both 0/1/2
        public long ImagesNumber { get; set; }
        public char Commercial { get; set; }
        public char AddOn { get; set; }

}
}

