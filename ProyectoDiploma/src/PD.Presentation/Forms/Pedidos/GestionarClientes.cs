using PD.Core.DTOs;
using PD.Core.Interfaces;
using PD.Entities;
using PD.Presentation.Helpers;

namespace PD.Presentation.Forms.Pedidos
{
    public partial class GestionarClientes : FormBase
    {
        private readonly IClienteManager _clientesManager;

        private List<Cliente> _clientes;
        private Cliente _selected = new();

        public GestionarClientes(
            IClienteManager clientesManager)
        {
            InitializeComponent();
            _clientesManager = clientesManager;
        }

        public void ShowAndLoad()
        {
            FillGrid();

            this.Show();
        }

        private void FillGrid()
        {
            dgv_clientes.DataSource = null;
            _clientes = _clientesManager.GetAll();

            var source = _clientes.Select(x => new ClienteListaDTO()
            {
                Id = x.Id,
                Nombre = x.Nombre,
                Documento = x.Documento,
                Telefono = x.Telefono,
                Direccion = x.Direccion,
                TipoDocumentoId = x.TipoDocumentoId,
                TipoClienteId = x.TipoClienteId,
                TipoCliente = x.TipoCliente.Nombre,
                TipoDocumento = x.TipoDocumento.Nombre,
            });

            dgv_clientes.AutoGenerateColumns = false;
            dgv_clientes.DataSource = source.ToList();
        }

        private void FormatGrid()
        {
            dgv_clientes.RowTemplate.Height = 20;
            dgv_clientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_clientes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Nombre",
                DataPropertyName = "Nombre",
                Width = 200,
            });

            dgv_clientes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Documento",
                HeaderText = "DNI/CUIT",
                DataPropertyName = "Documento",
                Width = 90,
            });

            dgv_clientes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "TipoDocumento",
                HeaderText = "Tipo",
                DataPropertyName = "TipoDocumento",
                Width = 40,
            });

            dgv_clientes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Telefono",
                HeaderText = "Tel.",
                DataPropertyName = "Telefono",
                Width = 90,
            });

            dgv_clientes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Direccion",
                HeaderText = "Dir.",
                DataPropertyName = "Direccion",
                Width = 150,
            });

            dgv_clientes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "TipoCliente",
                HeaderText = "IVA",
                DataPropertyName = "TipoCliente",
                Width = 100,
            });
        }

        private void FillCombos()
        {
            var tipoClientes = _clientesManager.GetAllTipoClientes();
            cbx_tipo_cliente.DataSource = tipoClientes;
            cbx_tipo_cliente.DisplayMember = "Nombre";
            cbx_tipo_cliente.ValueMember = "Id";

            var tipoDocumentos = _clientesManager.GetAllTipoDocumentos();
            cbx_tipo_dni.DataSource = tipoDocumentos;
            cbx_tipo_dni.DisplayMember = "Nombre";
            cbx_tipo_dni.ValueMember = "Id";
        }

        private void BindGrid()
        {
            dgv_clientes.SelectionChanged += OnSelectionChange;
        }

        private void OnSelectionChange(object? sender, EventArgs e)
        {
            if (dgv_clientes.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_clientes.SelectedRows[0];
                ClienteListaDTO select = (ClienteListaDTO)selectedRow.DataBoundItem;
                _selected = _clientes.Where(x => x.Id == select.Id).FirstOrDefault();
                FillInputs();
            }
        }

        private void GestionarClientes_Load(object sender, EventArgs e)
        {
            FillCombos();
            FillGrid();
            FormatGrid();
            BindGrid();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            _selected = new Cliente();
            txt_cuit.Text = string.Empty;
            txt_direccion.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_nombre.Text = string.Empty;
            txt_telefono.Text = string.Empty;
        }

        private void FillInputs()
        {
            if (_selected != null)
            {
                txt_cuit.Text = _selected.Documento;
                txt_direccion.Text = _selected.Direccion;
                txt_email.Text = _selected.Email;
                txt_nombre.Text = _selected.Nombre;
                txt_telefono.Text = _selected.Telefono;

                var index = 0;

                foreach (var item in cbx_tipo_cliente.Items)
                {
                    if (((TipoCliente)item).Id == _selected.TipoClienteId)
                    {
                        cbx_tipo_cliente.SelectedIndex = index;
                        continue;
                    }
                    index++;
                }

                index = 0;
                foreach (TipoDocumento item in cbx_tipo_dni.Items)
                {
                    if (item.Id == _selected.TipoDocumentoId)
                    {
                        cbx_tipo_dni.SelectedIndex = index;
                        continue;
                    }
                    index++;
                }

                // todo set combos selection
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (IsValid()) { return; }

            try
            {
                string? action;

                if (_selected.Id == Guid.Empty)
                {
                    action = "CREADO";

                    _selected = new Cliente()
                    {
                        Direccion = txt_direccion.Text,
                        Documento = txt_cuit.Text,
                        Email = txt_email.Text,
                        Nombre = txt_nombre.Text,
                        Telefono = txt_telefono.Text,
                        TipoClienteId = ((TipoCliente)cbx_tipo_cliente.SelectedItem).Id,
                        TipoDocumentoId = ((TipoDocumento)cbx_tipo_dni.SelectedItem).Id
                    };
                }
                else
                {
                    action = "ACTUALIZADO";

                    _selected.Direccion = txt_direccion.Text;
                    _selected.Documento = txt_cuit.Text;
                    _selected.Email = txt_email.Text;
                    _selected.Nombre = txt_nombre.Text;
                    _selected.Telefono = txt_telefono.Text;
                    _selected.TipoClienteId = ((TipoCliente)cbx_tipo_cliente.SelectedItem).Id;
                    _selected.TipoDocumentoId = ((TipoDocumento)cbx_tipo_dni.SelectedItem).Id;
                }

                _selected = _clientesManager.SaveOrCreate(_selected);

                MessageBox.Show($"Se ha {action} exitosamente el cliente {_selected.Nombre}", "Successs", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearInputs();
                FillGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al crear o actualizar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValid()
        {
            //TODO : agregar validaciones faltantes

            var errores = new List<string>();

            if (txt_nombre.IsTextInvalid())
            {
                errores.Add(GetMessageFieldEmptyError("Nombre"));
            }

            if (txt_cuit.IsTextInvalid())
            {
                errores.Add(GetMessageFieldEmptyError("DNI/CUIT"));
            }

            if (((TipoCliente)cbx_tipo_cliente.SelectedItem).Tipo != "CF")
            {
                //validacion cuit
            }

            if (txt_direccion.IsTextInvalid())
            {
                errores.Add(GetMessageFieldEmptyError("Direccion"));
            }

            if (txt_telefono.IsTextInvalid())
            {
                errores.Add(GetMessageFieldEmptyError("Telefono"));
            }

            if (errores.Any()) { ShowMessageFieldsEmptyError(errores); }

            return errores.Any();
        }

        private void ShowMessageFieldsEmptyError(List<string> fields)
        {
            var messages = string.Join("\n", fields);
            MessageBox.Show(messages, "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private string GetMessageFieldEmptyError(string value)
        {
            return $"{value} no puede estar vacio";
        }
    }
}