namespace Registropelicula
{
    partial class Consultar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.PeliculaDataGridView = new System.Windows.Forms.DataGridView();
            this.ActulizarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.DescripcionRichTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PeliculaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(34, 59);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdTextBox.TabIndex = 1;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(140, 59);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(49, 23);
            this.BuscarButton.TabIndex = 2;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // PeliculaDataGridView
            // 
            this.PeliculaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PeliculaDataGridView.Location = new System.Drawing.Point(12, 159);
            this.PeliculaDataGridView.Name = "PeliculaDataGridView";
            this.PeliculaDataGridView.Size = new System.Drawing.Size(326, 90);
            this.PeliculaDataGridView.TabIndex = 3;
            // 
            // ActulizarButton
            // 
            this.ActulizarButton.Location = new System.Drawing.Point(197, 59);
            this.ActulizarButton.Name = "ActulizarButton";
            this.ActulizarButton.Size = new System.Drawing.Size(61, 23);
            this.ActulizarButton.TabIndex = 4;
            this.ActulizarButton.Text = "Actualizar";
            this.ActulizarButton.UseVisualStyleBackColor = true;
            this.ActulizarButton.Click += new System.EventHandler(this.ActulizarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(264, 58);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(58, 23);
            this.EliminarButton.TabIndex = 5;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // DescripcionRichTextBox
            // 
            this.DescripcionRichTextBox.Location = new System.Drawing.Point(12, 102);
            this.DescripcionRichTextBox.Name = "DescripcionRichTextBox";
            this.DescripcionRichTextBox.Size = new System.Drawing.Size(326, 44);
            this.DescripcionRichTextBox.TabIndex = 6;
            this.DescripcionRichTextBox.Text = "";
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 261);
            this.Controls.Add(this.DescripcionRichTextBox);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.ActulizarButton);
            this.Controls.Add(this.PeliculaDataGridView);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Consultar";
            this.Text = "Consultar";
            ((System.ComponentModel.ISupportInitialize)(this.PeliculaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.DataGridView PeliculaDataGridView;
        private System.Windows.Forms.Button ActulizarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.RichTextBox DescripcionRichTextBox;
    }
}