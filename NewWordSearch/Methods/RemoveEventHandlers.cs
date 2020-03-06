using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.ComponentModel;

namespace NewWordSearch.Methods
{
    class RemoveEventHandlers
    {
        public static void RemoveAllHandlers(PictureBox _picBox)
        {
            FieldInfo f1 = typeof(Control).GetField("EventClick", BindingFlags.Static | BindingFlags.NonPublic);
            object obj = f1.GetValue(_picBox);
            PropertyInfo pi = _picBox.GetType().GetProperty("Events", BindingFlags.NonPublic | BindingFlags.Instance);
            EventHandlerList list = (EventHandlerList)pi.GetValue(_picBox, null);
            list.RemoveHandler(obj, list[obj]);
        }
    }
}
