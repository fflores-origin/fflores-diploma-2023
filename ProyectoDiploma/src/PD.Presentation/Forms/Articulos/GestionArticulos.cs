using PD.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PD.Presentation.Forms.Articulos
{
    public partial class GestionArticulos : Form
    {
        private readonly IArticulosManager _articuloManager;
        public GestionArticulos(IArticulosManager articuloManager)
        {
            InitializeComponent();
            _articuloManager = articuloManager;

            _articuloManager.GetAll();
        }
    }
}
