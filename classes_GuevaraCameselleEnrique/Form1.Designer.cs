namespace classes_GuevaraCameselleEnrique
{
    partial class FormFilm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.groupBoxTopics = new System.Windows.Forms.GroupBox();
            this.listBoxTopics = new System.Windows.Forms.ListBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxDirector = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelDirector = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBoxFilms = new System.Windows.Forms.GroupBox();
            this.listBoxFilms = new System.Windows.Forms.ListBox();
            this.groupBoxData.SuspendLayout();
            this.groupBoxTopics.SuspendLayout();
            this.groupBoxFilms.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.groupBoxTopics);
            this.groupBoxData.Controls.Add(this.textBoxYear);
            this.groupBoxData.Controls.Add(this.textBoxDirector);
            this.groupBoxData.Controls.Add(this.textBoxTitle);
            this.groupBoxData.Controls.Add(this.labelYear);
            this.groupBoxData.Controls.Add(this.labelDirector);
            this.groupBoxData.Controls.Add(this.labelTitle);
            this.groupBoxData.Location = new System.Drawing.Point(12, 12);
            this.groupBoxData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxData.Size = new System.Drawing.Size(376, 426);
            this.groupBoxData.TabIndex = 0;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Datos";
            // 
            // groupBoxTopics
            // 
            this.groupBoxTopics.Controls.Add(this.listBoxTopics);
            this.groupBoxTopics.Location = new System.Drawing.Point(20, 165);
            this.groupBoxTopics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTopics.Name = "groupBoxTopics";
            this.groupBoxTopics.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTopics.Size = new System.Drawing.Size(337, 245);
            this.groupBoxTopics.TabIndex = 2;
            this.groupBoxTopics.TabStop = false;
            this.groupBoxTopics.Text = "Temas";
            // 
            // listBoxTopics
            // 
            this.listBoxTopics.FormattingEnabled = true;
            this.listBoxTopics.ItemHeight = 16;
            this.listBoxTopics.Items.AddRange(new object[] {
            "Ciencia ficción",
            "Western",
            "Dibujos animados",
            "Acción",
            "Terror",
            "Fantasía",
            "Romántica",
            "Drama",
            "Comedia",
            "Aventuras",
            "Suspense"});
            this.listBoxTopics.Location = new System.Drawing.Point(5, 38);
            this.listBoxTopics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxTopics.Name = "listBoxTopics";
            this.listBoxTopics.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxTopics.Size = new System.Drawing.Size(325, 196);
            this.listBoxTopics.TabIndex = 0;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(152, 122);
            this.textBoxYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(207, 22);
            this.textBoxYear.TabIndex = 1;
            // 
            // textBoxDirector
            // 
            this.textBoxDirector.Location = new System.Drawing.Point(152, 81);
            this.textBoxDirector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDirector.Name = "textBoxDirector";
            this.textBoxDirector.Size = new System.Drawing.Size(207, 22);
            this.textBoxDirector.TabIndex = 1;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(152, 42);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(207, 22);
            this.textBoxTitle.TabIndex = 1;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(37, 128);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(98, 16);
            this.labelYear.TabIndex = 0;
            this.labelYear.Text = "Año de estreno";
            // 
            // labelDirector
            // 
            this.labelDirector.AutoSize = true;
            this.labelDirector.Location = new System.Drawing.Point(37, 87);
            this.labelDirector.Name = "labelDirector";
            this.labelDirector.Size = new System.Drawing.Size(54, 16);
            this.labelDirector.TabIndex = 0;
            this.labelDirector.Text = "Director";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(37, 48);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(40, 16);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Título";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(424, 26);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(145, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Añadir";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(573, 26);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(200, 23);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Eliminar seleccionada";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupBoxFilms
            // 
            this.groupBoxFilms.Controls.Add(this.listBoxFilms);
            this.groupBoxFilms.Location = new System.Drawing.Point(405, 60);
            this.groupBoxFilms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxFilms.Name = "groupBoxFilms";
            this.groupBoxFilms.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxFilms.Size = new System.Drawing.Size(369, 378);
            this.groupBoxFilms.TabIndex = 2;
            this.groupBoxFilms.TabStop = false;
            this.groupBoxFilms.Text = "Películas";
            // 
            // listBoxFilms
            // 
            this.listBoxFilms.FormattingEnabled = true;
            this.listBoxFilms.ItemHeight = 16;
            this.listBoxFilms.Location = new System.Drawing.Point(5, 17);
            this.listBoxFilms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxFilms.Name = "listBoxFilms";
            this.listBoxFilms.Size = new System.Drawing.Size(357, 356);
            this.listBoxFilms.TabIndex = 0;
            this.listBoxFilms.SelectedIndexChanged += new System.EventHandler(this.listBoxFilms_SelectedIndexChanged);
            // 
            // FormFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxFilms);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxData);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormFilm";
            this.Text = "Película";
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxData.PerformLayout();
            this.groupBoxTopics.ResumeLayout(false);
            this.groupBoxFilms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.GroupBox groupBoxTopics;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxDirector;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelDirector;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ListBox listBoxTopics;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBoxFilms;
        private System.Windows.Forms.ListBox listBoxFilms;
    }
}

