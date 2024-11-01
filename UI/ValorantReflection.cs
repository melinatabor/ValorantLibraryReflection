using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reflection;

namespace UI
{
    public partial class ValorantReflection : MaterialSkin.Controls.MaterialForm
    {
        public ValorantReflection()
        {
            InitializeComponent();
        }

        private void btnListarClases_Click(object sender, EventArgs e)
        {
            try
            {
                listViewClases.Items.Clear();

                List<string> clases = ReflectionHelper.GetClases();

                foreach (string clase in clases)
                {
                    listViewClases.Items.Add(new ListViewItem(clase));
                }
            }
            catch (Exception ex)
            {
                MaterialDialog materialDialog = new MaterialDialog(this, "Error", $"No se pudieron detectar las clases de la libreria: {ex.Message}.", "OK");
                materialDialog.ShowDialog(this);
                return;
            }
        }

        private void listViewClases_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listViewClases.SelectedItems.Count > 0)
                {
                    listViewPropiedades.Items.Clear();

                    string nombreClase = listViewClases.SelectedItems[0].Text;

                    Type tipoClase = ReflectionHelper.GetTipoClase(nombreClase);
                    if (tipoClase == null) throw new Exception("No se pudo encontrar el tipo de la clase seleccionada.");

                    List<PropertyInfo> propiedades = ReflectionHelper.GetPropiedades(tipoClase);

                    foreach (PropertyInfo propiedad in propiedades)
                    {
                        string tipoRepresentacion = ReflectionHelper.GetTipoRepresentacion(propiedad);
                        listViewPropiedades.Items.Add(new ListViewItem($"{tipoRepresentacion} {propiedad.Name}"));
                    }
                }
            }
            catch (Exception ex)
            {
                MaterialDialog materialDialog = new MaterialDialog(this, "Error", ex.Message, "OK");
                materialDialog.ShowDialog(this);
                return;
            }
        }

        private void btnPrintSQL_Click(object sender, EventArgs e)
        {
            try
            {

                if (listViewClases.SelectedItems.Count == 0)
                    throw new Exception("Seleccione una clase para generar la consulta.");

                string nombreClase = listViewClases.SelectedItems[0].Text;
                Type tipoClase = ReflectionHelper.GetTipoClase(nombreClase);

                if (tipoClase == null)
                {
                    throw new Exception("No se pudo encontrar el tipo de la clase seleccionada.");
                }
                expansionPanel.Show();
                expansionPanel.Collapse = false;
                string tipoQuery = comboBoxConsulta.SelectedItem.ToString().ToLower();

                var sqlBuilder = new SqlQueryBuilder()
                   .SetTable(tipoClase.Name)
                   .SetOperation(tipoQuery);

                string query = sqlBuilder.Build(tipoClase);

                expansionPanel.Title = tipoQuery.ToUpper();
                expansionPanel.Description = $"Comando para la clase {nombreClase}";
                lblConsulta.Text = query;
            }
            catch (Exception ex)
            {
                MaterialDialog materialDialog = new MaterialDialog(this, "Error", ex.Message, "OK");
                materialDialog.ShowDialog(this);
            }
        }

        private void ReflectionProgram_Load(object sender, EventArgs e)
        {
            expansionPanel.Hide();
            var materialSkinManager = MaterialSkinManager.Instance;

            materialSkinManager.AddFormToManage(this);

            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new ColorScheme(
                Color.FromArgb(48, 48, 48),
                Color.FromArgb(230, 30, 77),
                Color.FromArgb(255, 69, 89),
                Color.FromArgb(180, 20, 60),
                TextShade.WHITE
            );
        }

        private void expansionPanel_SaveClick(object sender, EventArgs e)
        {
            Clipboard.SetText(lblConsulta.Text);
            MaterialSnackBar snackBar = new MaterialSnackBar("Consulta copiada al portapapeles", 2000);
            snackBar.Show(this);
        }
    }
}
