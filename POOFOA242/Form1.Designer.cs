namespace POOFOA242
{
    partial class frmPrincipal
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
            lblNome = new Label();
            txtNome = new TextBox();
            btnCliqueMe = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(453, 192);
            lblNome.Margin = new Padding(4, 0, 4, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(65, 25);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(537, 189);
            txtNome.Margin = new Padding(4, 5, 4, 5);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(141, 31);
            txtNome.TabIndex = 1;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // btnCliqueMe
            // 
            btnCliqueMe.Enabled = false;
            btnCliqueMe.Location = new Point(534, 386);
            btnCliqueMe.Margin = new Padding(4, 5, 4, 5);
            btnCliqueMe.Name = "btnCliqueMe";
            btnCliqueMe.Size = new Size(107, 38);
            btnCliqueMe.TabIndex = 2;
            btnCliqueMe.Text = "Clique-me";
            btnCliqueMe.UseVisualStyleBackColor = true;
            btnCliqueMe.Click += btnCliqueMe_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(btnCliqueMe);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmPrincipal";
            Text = "Formulário Principal";
            Load += frmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private Button btnCliqueMe;
    }
}
