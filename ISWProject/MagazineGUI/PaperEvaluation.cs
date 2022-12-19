using Magazine.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagazineGUI
{
    public partial class PaperEvaluation : Form
    {
        private IMagazineISWService service;
        public PaperEvaluation(IMagazineISWService service)
        {
            InitializeComponent();
            this.service = service;
        }
    }
}
