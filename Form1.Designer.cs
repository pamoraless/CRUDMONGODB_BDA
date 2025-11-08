namespace CRUDMONGODB_BDA
{
    partial class Form1
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
            this.GridViewUsers = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.textContrasena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.textSeguidores = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textSeguidos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textLikes = new System.Windows.Forms.TextBox();
            this.textPosts = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewUsers
            // 
            this.GridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewUsers.Location = new System.Drawing.Point(27, 148);
            this.GridViewUsers.Name = "GridViewUsers";
            this.GridViewUsers.Size = new System.Drawing.Size(1050, 276);
            this.GridViewUsers.TabIndex = 0;
            this.GridViewUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewUsers_CellContentClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AccessibleName = "btnAgregar";
            this.btnAgregar.Location = new System.Drawing.Point(1002, 28);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AccessibleName = "btnEliminar";
            this.btnEliminar.Location = new System.Drawing.Point(1002, 58);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // button3
            // 
            this.button3.AccessibleName = "btnEditar";
            this.button3.Location = new System.Drawing.Point(1002, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textName
            // 
            this.textName.AccessibleName = "textName";
            this.textName.Location = new System.Drawing.Point(115, 25);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 20);
            this.textName.TabIndex = 0;
            // 
            // textUsername
            // 
            this.textUsername.AccessibleName = "textUsername";
            this.textUsername.Location = new System.Drawing.Point(115, 54);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(100, 20);
            this.textUsername.TabIndex = 4;
            // 
            // textCorreo
            // 
            this.textCorreo.AccessibleName = "textCorreo";
            this.textCorreo.Location = new System.Drawing.Point(115, 84);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(159, 20);
            this.textCorreo.TabIndex = 5;
            // 
            // textContrasena
            // 
            this.textContrasena.AccessibleName = "textContrasena";
            this.textContrasena.Location = new System.Drawing.Point(115, 111);
            this.textContrasena.Name = "textContrasena";
            this.textContrasena.Size = new System.Drawing.Size(100, 20);
            this.textContrasena.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Contraseña";
            // 
            // textBio
            // 
            this.textBio.AccessibleName = "textBio";
            this.textBio.Location = new System.Drawing.Point(644, 21);
            this.textBio.Multiline = true;
            this.textBio.Name = "textBio";
            this.textBio.Size = new System.Drawing.Size(100, 109);
            this.textBio.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(604, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Bio";
            // 
            // dateFechaNacimiento
            // 
            this.dateFechaNacimiento.AccessibleName = "dateFechaNacimiento";
            this.dateFechaNacimiento.Location = new System.Drawing.Point(398, 27);
            this.dateFechaNacimiento.Name = "dateFechaNacimiento";
            this.dateFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dateFechaNacimiento.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Fecha de Nacimiento";
            // 
            // textSeguidores
            // 
            this.textSeguidores.AccessibleName = "textSeguidores";
            this.textSeguidores.Location = new System.Drawing.Point(398, 54);
            this.textSeguidores.Name = "textSeguidores";
            this.textSeguidores.Size = new System.Drawing.Size(100, 20);
            this.textSeguidores.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Seguidores";
            // 
            // textSeguidos
            // 
            this.textSeguidos.AccessibleName = "textSeguidos";
            this.textSeguidos.Location = new System.Drawing.Point(398, 79);
            this.textSeguidos.Name = "textSeguidos";
            this.textSeguidos.Size = new System.Drawing.Size(100, 20);
            this.textSeguidos.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(341, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Seguidos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(299, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Likes";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(465, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Posts";
            // 
            // textLikes
            // 
            this.textLikes.AccessibleName = "textLikes";
            this.textLikes.Location = new System.Drawing.Point(338, 118);
            this.textLikes.Name = "textLikes";
            this.textLikes.Size = new System.Drawing.Size(100, 20);
            this.textLikes.TabIndex = 24;
            // 
            // textPosts
            // 
            this.textPosts.AccessibleName = "textPosts";
            this.textPosts.Location = new System.Drawing.Point(505, 118);
            this.textPosts.Name = "textPosts";
            this.textPosts.Size = new System.Drawing.Size(100, 20);
            this.textPosts.TabIndex = 25;
            // 
            // textId
            // 
            this.textId.AccessibleName = "textId";
            this.textId.Location = new System.Drawing.Point(896, 30);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(100, 20);
            this.textId.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(874, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.textPosts);
            this.Controls.Add(this.textLikes);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textSeguidos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textSeguidores);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateFechaNacimiento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textContrasena);
            this.Controls.Add(this.textCorreo);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.GridViewUsers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewUsers;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.TextBox textContrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateFechaNacimiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textSeguidores;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textSeguidos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textLikes;
        private System.Windows.Forms.TextBox textPosts;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label11;
    }
}

