using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;



namespace BE
{
    public enum Group { כיסאות, כיסאות_בר, כיסאות_משרד, שולחנות, כורסאות };

    public class Product
    {
        public int CN { get; set; }
        public string Name { get; set; }
        public Group Group { get; set; }
        public string Description { get; set; }
        public float CostPrice { get; set; }
        public float PrivateCustomPrice { get; set; }
        public float BuzinessCustomPrice { get; set; }
        public int AmountInStock { get; set; }
        public int DefectAmount { get; set; }
        public int AmountInDisplay { get; set; }
        public int OederedAmount { get; set; }
        public  Image Image { get; set; }
        public string Color { get; set; }
        public Size Size { get; set; }
        public Provider Provider { get; set; }
        public bool CanOrder { get; set; }
        public bool WithLegs { get; set; }
        public int Legs { get; set; }
        public string Material{ get; set; }
        public string Notes { get; set; }

        public Product() { }

        public Product(int cN, string name, Group group, string description, float costPrice, float privateCustomPrice, float buzinessCustomPrice, int amountInStock, int defectAmount, int amountInDisplay,
           int oederedAmount, Image image, string color, Size size, Provider provider, bool canOrder, bool withLegs, int legs, string material, string notes)
        {
            CN = cN;
            Name = name;
            Group = group;
            Description = description;
            CostPrice = costPrice;
            PrivateCustomPrice = privateCustomPrice;
            BuzinessCustomPrice = buzinessCustomPrice;
            AmountInStock = amountInStock;
            DefectAmount = defectAmount;
            AmountInDisplay = amountInDisplay;
            OederedAmount = oederedAmount;
            Image = image;
            Color = color;
            Size = size;
            Provider = provider;
            CanOrder = canOrder;
            WithLegs = withLegs;
            Legs = legs;
            Material = material;
            Notes = notes;
        }

    }
}
