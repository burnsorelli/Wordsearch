using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewWordSearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.Name = "form";
            Form _wholeForm = this;

            InitializeComponent();
            Styling.WholeForm.TheForm = _wholeForm;

            Styling.WholeForm.GetElements();
            Methods.GetFormInternalWidth.GetWidth();
            Styling.HelpPanel.GetElements();
            Methods.GetUserChoiceStart.GetChoice();
        }
    }
}
