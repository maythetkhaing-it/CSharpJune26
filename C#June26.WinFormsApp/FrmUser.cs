using ClassLibrary.Database.AppDbContextModels;
using Microsoft.VisualBasic.ApplicationServices;

namespace C_June26.WinFormsApp
{
    public partial class FrmUser : Form
    {
        private readonly AppDbContext _db;
        private int editUserId = 0;
        public FrmUser()
        {
            InitializeComponent();
            _db = new AppDbContext();
        }


        private void FrmUser_Load(object sender, EventArgs e)
        {
            BindData();
        }

        //Read
        private void BindData()
        {
            var lst = _db.TblUsers.ToList();
            int rowNo = 0;
            List<UserDto> users = new List<UserDto>();
            foreach (var item in lst)
            {
                rowNo++;
                UserDto user = new UserDto();
                user.RowNo = rowNo;
                user.UserID = item.UserId;
                user.Username = item.UserName;
                user.UserPassword = item.UserPassword;

                users.Add(user);
                //Second Way
                //UserDto user2 = new UserDto()
                //{
                //    UserID = item.UserId,
                //    Username = item.UserName,
                //    UserPassword = item.UserPassword,
                //    RowNo = ++rowNo
                //};
                //users.Add(user);
            }
            dgvData.DataSource = users;

            ClearControls();
        }

        public class UserDto
        {
            public int RowNo { get; set; }

            public int UserID { get; set; }

            public string Username { get; set; }

            public string UserPassword { get; set; }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            ClearControls();
        }

        private void ClearControls()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        //Add
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(editUserId == 0)
            {
                _db.TblUsers.Add(new TblUser
                {
                    UserName = txtUsername.Text.Trim(), //Trim --> " mg mg "
                    UserPassword = txtPassword.Text.Trim(),
                });
                _db.SaveChanges();
            }
            else
            {
                var item = _db.TblUsers.Where(x => x.UserId == editUserId).FirstOrDefault();
                if (item is null) return;

                item.UserName = txtUsername.Text.Trim();
                item.UserPassword = txtPassword.Text.Trim();
            }
            editUserId = 0;
            BindData();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if(e.ColumnIndex == 0)//Edit
            {
                int userId = Convert.ToInt32(dgvData.Rows[e.RowIndex].Cells[nameof(colUserId)].Value);
                var item = _db.TblUsers.Where(x => x.UserId == userId).FirstOrDefault();
                if (item is null) return;
               
                txtUsername.Text = item.UserName;
                txtPassword.Text = item.UserPassword;
                editUserId = item.UserId;
            }
            else if(e.ColumnIndex == 1)//Delete
            { 
                var result = MessageBox.Show("Are you sure you want to Delete?", "Confirm" , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int userId = Convert.ToInt32(dgvData.Rows[e.RowIndex].Cells[nameof(colUserId)].Value);
                    var item = _db.TblUsers.Where(x => x.UserId == userId).FirstOrDefault();
                    if (item is null) return;
                    _db.Remove(item);
                    _db.SaveChanges();

                    BindData();
                }
            }

        }
    }
}
