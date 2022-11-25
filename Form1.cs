
// Pour avoir accès aux méthodes de l'autre projet
using AssociationCRMDawanPoe.Persistance.Menu_DAO;
using AssociationCRMDawanPoe.Service;

namespace WinFormsMenu
{
    public partial class Form1 : Form
    {
        readonly IMenuService _service;
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
    }
}