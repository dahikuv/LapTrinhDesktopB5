namespace TreeView_ListView
{
    partial class frmView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            frmTreeView = new TreeView();
            splitContainer2 = new SplitContainer();
            frmListView = new ListView();
            clmnID = new ColumnHeader();
            clmnName = new ColumnHeader();
            clmnEmail = new ColumnHeader();
            txtEmail = new TextBox();
            txtName = new TextBox();
            txtID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(frmTreeView);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // frmTreeView
            // 
            frmTreeView.Dock = DockStyle.Fill;
            frmTreeView.Location = new Point(0, 0);
            frmTreeView.Name = "frmTreeView";
            frmTreeView.Size = new Size(266, 450);
            frmTreeView.TabIndex = 0;
            frmTreeView.AfterSelect += frmTreeView_AfterSelect;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(frmListView);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(txtEmail);
            splitContainer2.Panel2.Controls.Add(txtName);
            splitContainer2.Panel2.Controls.Add(txtID);
            splitContainer2.Size = new Size(530, 450);
            splitContainer2.SplitterDistance = 176;
            splitContainer2.TabIndex = 0;
            // 
            // frmListView
            // 
            frmListView.Columns.AddRange(new ColumnHeader[] { clmnID, clmnName, clmnEmail });
            frmListView.Dock = DockStyle.Fill;
            frmListView.FullRowSelect = true;
            frmListView.Location = new Point(0, 0);
            frmListView.MultiSelect = false;
            frmListView.Name = "frmListView";
            frmListView.Size = new Size(530, 176);
            frmListView.TabIndex = 0;
            frmListView.UseCompatibleStateImageBehavior = false;
            frmListView.View = View.Details;
            frmListView.SelectedIndexChanged += frmListView_SelectedIndexChanged;
            // 
            // clmnID
            // 
            clmnID.Text = "ID";
            clmnID.Width = 70;
            // 
            // clmnName
            // 
            clmnName.Text = "Name";
            clmnName.Width = 200;
            // 
            // clmnEmail
            // 
            clmnEmail.Text = "Email";
            clmnEmail.Width = 255;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(14, 201);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(502, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(14, 122);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(502, 27);
            txtName.TabIndex = 1;
            // 
            // txtID
            // 
            txtID.Location = new Point(14, 43);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(502, 27);
            txtID.TabIndex = 0;
            // 
            // frmView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "frmView";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TreeView frmTreeView;
        private SplitContainer splitContainer2;
        private ListView frmListView;
        private TextBox txtEmail;
        private TextBox txtName;
        private TextBox txtID;
        private ColumnHeader clmnID;
        private ColumnHeader clmnName;
        private ColumnHeader clmnEmail;
    }
}
