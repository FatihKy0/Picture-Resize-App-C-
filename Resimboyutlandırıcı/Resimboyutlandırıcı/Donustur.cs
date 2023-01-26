using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;


namespace Resimboyutlandırıcı
{
   abstract class Donustur
    {
       
       abstract public string kaydet(string txtyndd, ComboBox comboBox, string txtkayy, Object sender);
       abstract public string gozat(string txtkayy);
      
      
    }
}
