﻿using PD.Core.Interfaces;
using PD.Entities.Enums;
using PD.Entities.Permisos;
using PD.Presentation.Helpers;

namespace PD.Presentation.Forms.Configuracion
{
    public partial class GestionarPatentes : FormBase
    {
        private readonly IUsuarioManager _usuarioManager;

        private Familia _familiaSeleccionada;

        public GestionarPatentes(IUsuarioManager usuarioManager)
        {
            InitializeComponent();
            _usuarioManager = usuarioManager;
            Load += GestionarPatentes_Load;
        }

        private void GestionarPatentes_Load(object sender, EventArgs e)
        {
            FillPermisos();
            LoadBase();
        }

        private void LoadBase()
        {
            FillCombos();
        }

        internal void ShowAndLoad()
        {
            Show();
        }

        #region Combos

        private void FillPermisos()
        {
            //todo: trasnformar en tabla
            var permisos = _usuarioManager.GetAllPermisos();
            cbx_permisos.DataSource = permisos;
        }

        private void FillCombos()
        {
            List<Familia> familas = _usuarioManager.GetAllFamilias();
            cbx_familias.DataSource = familas;
            cbx_familias.DisplayMember = "Nombre";
            cbx_familias.ValueMember = "Id";

            List<Patente> patentes = _usuarioManager.GetAllPatentes();
            cbx_patentes.DataSource = patentes;
            cbx_patentes.DisplayMember = "Nombre";
            cbx_patentes.ValueMember = "Id";
        }

        #endregion Combos

        #region TreeView

        private void FillTreeView(bool shouldInitialize = false)
        {
            if (_familiaSeleccionada == null) return;
            List<PermisoBase> familia;

            if (shouldInitialize)
                familia = _usuarioManager.GetAllComponentes(_familiaSeleccionada);
            else
                familia = _familiaSeleccionada.ObtenerHijos().ToList();

            tw_permisos.Nodes.Clear();
            TreeNode root = new(_familiaSeleccionada.Nombre) { Tag = _familiaSeleccionada };

            tw_permisos.Nodes.Add(root);
            foreach (var item in familia)
                FillTreeViewNodes(root, item);

            tw_permisos.ExpandAll();
        }

        private void FillTreeViewNodes(TreeNode tree, PermisoBase component)
        {
            TreeNode node = new(component.Nombre);
            tree.Tag = component;
            tree.Nodes.Add(node);
            component
                    .ObtenerHijos()?
                    .ToList()
                    .ForEach(x => { FillTreeViewNodes(node, x); });
        }

        #endregion TreeView

        #region Buttons

        private void btn_guardar_patente_Click(object sender, EventArgs e)
        {
            Patente patente = new()
            {
                Id = Guid.NewGuid(),
                Nombre = txt_nombre_patente.Text,
                Tipo = (TipoPermiso)cbx_permisos.SelectedItem
            };

            _usuarioManager.SaveComponent(patente, false);
            FillCombos();

            MsgBoxHelpers.ShowInfo("Guardada Exitosamente");
        }

        private void btn_guardar_famila_Click(object sender, EventArgs e)
        {
            Familia familia = new()
            {
                Nombre = txt_nombre_familia.Text,
            };

            _usuarioManager.SaveComponent(familia, true);
            FillCombos();
            MsgBoxHelpers.ShowInfo("Guardada Exitosamente");
        }

        private void btn_configurar_Click(object sender, EventArgs e)
        {
            var tmp = (Familia)cbx_familias.SelectedItem;
            _familiaSeleccionada = new Familia
            {
                Id = tmp.Id,
                Nombre = tmp.Nombre
            };

            FillTreeView(true);
        }

        private void btn_agregar_patente_Click(object sender, EventArgs e)
        {
            if (_familiaSeleccionada != null)
            {
                var patente = (Patente)cbx_patentes.SelectedItem;
                if (patente != null)
                {
                    if (_usuarioManager.PatenteExiste(_familiaSeleccionada, patente))
                    {
                        MsgBoxHelpers.ShowWarning("Ya existe la patente indicada");
                        return;
                    }

                    _familiaSeleccionada.AddPermiso(patente);
                    FillTreeView();
                }
            }
        }

        private void btn_agregar_familia_Click(object sender, EventArgs e)
        {
            if (_familiaSeleccionada != null)
            {
                var familia = (Familia)cbx_familias.SelectedItem;
                if (familia != null)
                {
                    if (_usuarioManager.PatenteExiste(_familiaSeleccionada, familia))
                    {
                        MsgBoxHelpers.ShowWarning("Ya existe la familia indicada");
                        return;
                    }

                    _usuarioManager.CompleteComponent(familia);
                    _familiaSeleccionada.AddPermiso(familia);
                    FillTreeView();
                }
            }
        }

        #endregion Buttons

        private void btn_guardar_todo_Click(object sender, EventArgs e)
        {
            try
            {
                _usuarioManager.SaveFamilia(_familiaSeleccionada);
                MsgBoxHelpers.ShowInfo("Guardado Correctamente");
            }
            catch (Exception ex)
            {
                MsgBoxHelpers.ShowError("Ocurrio un error al guardar");
            }
        }
    }
}