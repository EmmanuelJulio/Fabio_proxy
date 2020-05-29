using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNegocio;

namespace UiFabio.Configuraciones.Asignaciones
{
    public partial class frmAsignaciones : PadreFormularios
    {
        public frmAsignaciones()
        {
            InitializeComponent();
        }

        private void FrmAsignaciones_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Maquinas_sectores.Visible = true;
            ComboSectores.DisplayMember = "nombre";
            ComboSectores.DataSource = ClsTerminosDiccionario.GetTerminosDiccionario().GetTerminosDeDicc(1);
           

        }

        private void ComboSectores_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
