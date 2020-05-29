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

namespace UiFabio.Of_tecnica.Planos
{
    public partial class frmPlanosVijentes : PadreFormularios
    {
        public frmPlanosVijentes()
        {
            InitializeComponent();
        }

        private void FrmPlanosVijentes_Load(object sender, EventArgs e)
        {

            ComboSectores.DisplayMember = "nombre";
            ComboSectores.DataSource = ClsTerminosDiccionario.GetTerminosDiccionario().GetTerminosDeDicc(1);

            
            dgvMaquinas.DataSource = ClsTerminosDiccionario.GetTerminosDiccionario().GetTerminosDeDicc(4);
            dgvMaquinas.Columns["abreviatura"].Visible = false;
            dgvMaquinas.Columns["id"].Visible = false;
        }
    }
}
