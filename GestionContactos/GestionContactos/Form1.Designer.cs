namespace GestionContactos
{
    partial class Form1
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
            btnAñadirContacto = new Button();
            btnModificarTelefono = new Button();
            btnEliminarContacto = new Button();
            btnMostrar = new Button();
            SuspendLayout();
            // 
            // btnAñadirContacto
            // 
            btnAñadirContacto.Location = new Point(137, 93);
            btnAñadirContacto.Name = "btnAñadirContacto";
            btnAñadirContacto.Size = new Size(151, 54);
            btnAñadirContacto.TabIndex = 0;
            btnAñadirContacto.Text = "Añadir Contacto";
            btnAñadirContacto.UseVisualStyleBackColor = true;
            btnAñadirContacto.Click += btnAñadirContacto_Click;
            // 
            // btnModificarTelefono
            // 
            btnModificarTelefono.Location = new Point(334, 93);
            btnModificarTelefono.Name = "btnModificarTelefono";
            btnModificarTelefono.Size = new Size(151, 54);
            btnModificarTelefono.TabIndex = 1;
            btnModificarTelefono.Text = "Modificar Teléfono";
            btnModificarTelefono.UseVisualStyleBackColor = true;
            btnModificarTelefono.Click += btnModificarTelefono_Click;
            // 
            // btnEliminarContacto
            // 
            btnEliminarContacto.Location = new Point(137, 177);
            btnEliminarContacto.Name = "btnEliminarContacto";
            btnEliminarContacto.Size = new Size(151, 54);
            btnEliminarContacto.TabIndex = 2;
            btnEliminarContacto.Text = "Eliminar Contacto";
            btnEliminarContacto.UseVisualStyleBackColor = true;
            btnEliminarContacto.Click += btnEliminarContacto_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(334, 177);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(151, 54);
            btnMostrar.TabIndex = 3;
            btnMostrar.Text = "Mostrar Contactos";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMostrar);
            Controls.Add(btnEliminarContacto);
            Controls.Add(btnModificarTelefono);
            Controls.Add(btnAñadirContacto);
            Name = "Form1";
            Text = "Gestión Contactos";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAñadirContacto;
        private Button btnModificarTelefono;
        private Button btnEliminarContacto;
        private Button btnMostrar;
    }
}
