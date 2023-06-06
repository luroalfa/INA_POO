namespace ProyectoEscritorio
{
    partial class Frm_Notas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Notas));
            groupBox1 = new GroupBox();
            txtListas = new ListBox();
            labelResult = new Label();
            btnResult = new Button();
            deleteSelected = new Button();
            btnClearNotes = new Button();
            txtNotaSelecciona = new TextBox();
            label2 = new Label();
            btnAdd = new Button();
            txtNota = new TextBox();
            label1 = new Label();
            btnExit = new Button();
            label3 = new Label();
            labelMessage = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtListas);
            groupBox1.Controls.Add(labelResult);
            groupBox1.Controls.Add(btnResult);
            groupBox1.Controls.Add(deleteSelected);
            groupBox1.Controls.Add(btnClearNotes);
            groupBox1.Controls.Add(txtNotaSelecciona);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtNota);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 402);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro de Notas";
            // 
            // txtListas
            // 
            txtListas.FormattingEnabled = true;
            txtListas.ItemHeight = 25;
            txtListas.Location = new Point(427, 39);
            txtListas.Name = "txtListas";
            txtListas.Size = new Size(338, 354);
            txtListas.TabIndex = 8;
            txtListas.SelectedIndexChanged += txtListas_SelectedIndexChanged;
            // 
            // labelResult
            // 
            labelResult.BackColor = SystemColors.Info;
            labelResult.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            labelResult.ForeColor = SystemColors.ActiveCaptionText;
            labelResult.Location = new Point(15, 307);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(381, 81);
            labelResult.TabIndex = 7;
            // 
            // btnResult
            // 
            btnResult.Location = new Point(233, 258);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(162, 39);
            btnResult.TabIndex = 2;
            btnResult.Text = "Ver Resultados";
            btnResult.UseVisualStyleBackColor = true;
            btnResult.Click += btnResult_Click;
            // 
            // deleteSelected
            // 
            deleteSelected.Location = new Point(6, 166);
            deleteSelected.Name = "deleteSelected";
            deleteSelected.Size = new Size(266, 31);
            deleteSelected.TabIndex = 6;
            deleteSelected.Text = "Eliminar Seleccionado";
            deleteSelected.UseVisualStyleBackColor = true;
            deleteSelected.Click += deleteSelected_Click;
            // 
            // btnClearNotes
            // 
            btnClearNotes.Location = new Point(6, 217);
            btnClearNotes.Name = "btnClearNotes";
            btnClearNotes.Size = new Size(266, 31);
            btnClearNotes.TabIndex = 5;
            btnClearNotes.Text = "Limpiar Lista de Notas";
            btnClearNotes.UseVisualStyleBackColor = true;
            btnClearNotes.Click += btnClearNotes_Click;
            // 
            // txtNotaSelecciona
            // 
            txtNotaSelecciona.Location = new Point(270, 112);
            txtNotaSelecciona.Name = "txtNotaSelecciona";
            txtNotaSelecciona.ReadOnly = true;
            txtNotaSelecciona.Size = new Size(125, 31);
            txtNotaSelecciona.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 115);
            label2.Name = "label2";
            label2.Size = new Size(158, 25);
            label2.TabIndex = 3;
            label2.Text = "Nota Seleccionada";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(302, 40);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 31);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtNota
            // 
            txtNota.Location = new Point(133, 40);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(139, 31);
            txtNota.TabIndex = 1;
            txtNota.TextChanged += txtNota_TextChanged;
            txtNota.KeyPress += txtNota_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 43);
            label1.Name = "label1";
            label1.Size = new Size(121, 25);
            label1.TabIndex = 0;
            label1.Text = "Digita la Nota";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(694, 420);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 39);
            btnExit.TabIndex = 1;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 427);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 2;
            // 
            // labelMessage
            // 
            labelMessage.Location = new Point(22, 429);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(657, 31);
            labelMessage.TabIndex = 3;
            // 
            // Frm_Notas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 466);
            Controls.Add(labelMessage);
            Controls.Add(label3);
            Controls.Add(btnExit);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Frm_Notas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Notas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnExit;
        private Button btnAdd;
        private TextBox txtNota;
        private Label label1;
        private Button deleteSelected;
        private Button btnClearNotes;
        private TextBox txtNotaSelecciona;
        private Label label2;
        private Button btnResult;
        private Label labelResult;
        private Label label3;
        private Label labelMessage;
        private ListBox txtListas;
    }
}