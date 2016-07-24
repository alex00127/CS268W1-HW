using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;  // it should include the Combox's folder(namespace) ( should reference this namespace at first.)
using System.Drawing;

namespace StoreLibrary.Componets
{
    public class ProductComboBox : ComboBox
    {

        

        public ProductComboBox()
            : base()
        {
            this.DrawMode = DrawMode.OwnerDrawVariable;
            this.DropDownHeight = 1000;
            //this.DropDownWidth = 500;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);
            if (e.Index < 0)
            {
                return;
            } 
            
            e.DrawBackground();
            if (this.Items[e.Index] is Product)
            {
                Product product = this.Items[e.Index] as Product;
                Font font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
                Brush brush = new SolidBrush(product.Color);
                e.Graphics.DrawString(product.ToString(),font,brush,e.Bounds.X,e.Bounds.Y);
            }
        }

        protected override void OnMeasureItem(MeasureItemEventArgs e)
        {
            base.OnMeasureItem(e);
            e.ItemHeight = 30;
        }

        
        
        
    }
}
