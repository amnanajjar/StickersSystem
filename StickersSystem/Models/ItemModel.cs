using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace StickersSystem.Models
{
    public class ItemModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Number { get; set; }

        public BitmapImage Image {get; set;}

        public BitmapImage Barcode { get; set; }
    }
}
