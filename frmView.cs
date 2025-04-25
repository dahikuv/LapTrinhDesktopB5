namespace TreeView_ListView
{
    public partial class frmView : Form
    {
        // Sample data
        private List<Department> departments;

        public frmView()
        {
            InitializeComponent();
            InitializeData();
            PopulateTreeView();
        }

        private void InitializeData()
        {
            // Create sample data
            departments = new List<Department>();

            // Department 1: CNTT Kinh doanh
            Department dept1 = new Department { Id = 1, Name = "Khoa CNTT Kinh doanh" };
            Class class1 = new Class { ClassCode = "Class 111-22-111", ClassName = "Class 111-22-111", Department = dept1 };
            Class class2 = new Class { ClassCode = "Class 111-22-222", ClassName = "Class 111-22-222", Department = dept1 };

            // Add students to class1
            class1.Students.Add(new Student { Id = 105, FullName = "Full name H5", Email = "email5@ueh.edu.vn", Class = class1 });
            class1.Students.Add(new Student { Id = 106, FullName = "Full name H6", Email = "email6@ueh.edu.vn", Class = class1 });

            // Add students to class2
            class2.Students.Add(new Student { Id = 107, FullName = "Full name H7", Email = "email7@ueh.edu.vn", Class = class2 });
            class2.Students.Add(new Student { Id = 108, FullName = "Full name H8", Email = "email8@ueh.edu.vn", Class = class2 });
            class2.Students.Add(new Student { Id = 109, FullName = "Full name H9", Email = "email9@ueh.edu.vn", Class = class2 });

            // Add classes to department
            dept1.Classes.Add(class1);
            dept1.Classes.Add(class2);

            // Department 2: Kế toán
            Department dept2 = new Department { Id = 2, Name = "Khoa Kế toán" };
            Class class3 = new Class { ClassCode = "Class 222-33-111", ClassName = "Class 222-33-111", Department = dept2 };
            Class class4 = new Class { ClassCode = "Class 222-33-222", ClassName = "Class 222-33-222", Department = dept2 };
            Class class5 = new Class { ClassCode = "Class 222-33-333", ClassName = "Class 222-33-333", Department = dept2 };

            // Add students to classes
            class3.Students.Add(new Student { Id = 110, FullName = "Full name H10", Email = "email10@ueh.edu.vn", Class = class3 });
            class4.Students.Add(new Student { Id = 111, FullName = "Full name H11", Email = "email11@ueh.edu.vn", Class = class4 });
            class5.Students.Add(new Student { Id = 112, FullName = "Full name H12", Email = "email12@ueh.edu.vn", Class = class5 });

            // Add classes to department
            dept2.Classes.Add(class3);
            dept2.Classes.Add(class4);
            dept2.Classes.Add(class5);

            // Add departments to list
            departments.Add(dept1);
            departments.Add(dept2);
        }

        private void PopulateTreeView()
        {
            frmTreeView.Nodes.Clear();

            // Create nodes for each department
            foreach (Department dept in departments)
            {
                TreeNode deptNode = new TreeNode(dept.Name);
                deptNode.Tag = dept;

                // Add class nodes to department node
                foreach (Class cls in dept.Classes)
                {
                    TreeNode classNode = new TreeNode(cls.ClassCode);
                    classNode.Tag = cls;
                    deptNode.Nodes.Add(classNode);
                }

                frmTreeView.Nodes.Add(deptNode);
            }

            // Expand all nodes by default
            frmTreeView.ExpandAll();
        }

        private void frmTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Clear the ListView
            frmListView.Items.Clear();
            txtID.Clear();
            txtName.Clear();

            // If a class node is selected, display its students
            if (e.Node.Tag is Class selectedClass)
            {
                foreach (Student student in selectedClass.Students)
                {
                    ListViewItem item = new ListViewItem(student.Id.ToString());
                    item.SubItems.Add(student.FullName);
                    item.SubItems.Add(student.Email);
                    item.Tag = student;
                    frmListView.Items.Add(item);
                }
            }
        }

        private void frmListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if a student is selected
            if (frmListView.SelectedItems.Count > 0)
            {
                // Get the selected student
                ListViewItem selectedItem = frmListView.SelectedItems[0];
                Student selectedStudent = (Student)selectedItem.Tag;

                // Display student details
                txtID.Text = selectedStudent.Id.ToString();
                txtName.Text = selectedStudent.FullName;
                txtEmail.Text = selectedStudent.Email;
            }
        }
    }
}