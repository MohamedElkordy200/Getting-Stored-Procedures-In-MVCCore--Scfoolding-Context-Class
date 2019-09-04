using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyadCapital.Base.EntitiesConverterMVCToCore
{
    public partial class logsForm : Form
    {
        public logsForm(string logsText)
        {
            InitializeComponent();
            txt_Logs.Text = logsText;
        }
    }
}
