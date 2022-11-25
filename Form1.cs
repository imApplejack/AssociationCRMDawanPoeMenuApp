
// Pour avoir accès aux méthodes de l'autre projet
using AssociationCRMDawanPoe.Persistance.Menu_DAO;
using AssociationCRMDawanPoe.Service;

namespace WinFormsMenu
{
    public partial class Form1 : Form
    {
        readonly MenuServiceImpl _service;
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            _service = new MenuServiceImpl(new MenuDAO()) ;
            buttonDelete.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _service.GetAll();
            dataGridView1.Refresh();
            dataGridView1.Columns["id"].Visible = false;


            dataGridView1.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
       
            

            dataGridView1.Columns["name"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
          
            

            dataGridView1.Columns["name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
           

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string name = (string)dataGridView1.SelectedRows[0].Cells[0].Value;
            if (name != string.Empty)
            {
                _service.Delete((string)dataGridView1.SelectedRows[0].Cells[0].Value);
                dataGridView1.DataSource = _service.GetAll();
                dataGridView1.ClearSelection();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (buttonAdd.Text == "Ajouter")
            {
               
                AddMenu formMenuAjouter = new(_service);
                
                formMenuAjouter.ShowDialog(this);
            }
            else if (dataGridView1.SelectedRows.Count != 0)
            {
                /*throw new Exception("test");*/
                string name = (string)dataGridView1.SelectedRows[0].Cells[0].Value;
                if (name != string.Empty)
                {
                    AddMenu formMenuAjouter = new(_service, _service.GetByName(name));
                    
                    formMenuAjouter.ShowDialog(this);
                }
            }
            else
            {
                MessageBox.Show("Aucun produit séléctionné");
            }
        }
        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                buttonAdd.Text = "Modifier";
                buttonDelete.Enabled = true;

            }
            else
            {
                buttonAdd.Text = "Ajouter";
                buttonDelete.Enabled = false;
            }

            dataGridView1.Refresh();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
            
                if (dataGridView1.SelectedRows.Count == 1)
                {
                
                    buttonAdd.Text = "Modifier";
                    buttonDelete.Enabled = true;

                }
                else
                {
                    buttonAdd.Text = "Ajouter";
                    buttonDelete.Enabled = false;
                }
            dataGridView1.Refresh();
        }
    }
}