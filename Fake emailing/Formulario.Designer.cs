namespace Fake_emailing
{
    partial class Formulario
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
            components = new System.ComponentModel.Container();
            contenedor_listaproductos = new TextBox();
            contenedor_falsoemail = new TextBox();
            etiqueta_tiempotranscurrido = new Label();
            label1 = new Label();
            etiqueta_tiempo = new Label();
            btn_agregar = new Button();
            etiqueta_correospendientes = new Label();
            label2 = new Label();
            Temporizador = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // contenedor_listaproductos
            // 
            contenedor_listaproductos.Location = new Point(12, 44);
            contenedor_listaproductos.Multiline = true;
            contenedor_listaproductos.Name = "contenedor_listaproductos";
            contenedor_listaproductos.ReadOnly = true;
            contenedor_listaproductos.Size = new Size(418, 394);
            contenedor_listaproductos.TabIndex = 0;
            // 
            // contenedor_falsoemail
            // 
            contenedor_falsoemail.Location = new Point(436, 71);
            contenedor_falsoemail.Multiline = true;
            contenedor_falsoemail.Name = "contenedor_falsoemail";
            contenedor_falsoemail.ReadOnly = true;
            contenedor_falsoemail.Size = new Size(548, 367);
            contenedor_falsoemail.TabIndex = 1;
            // 
            // etiqueta_tiempotranscurrido
            // 
            etiqueta_tiempotranscurrido.AutoSize = true;
            etiqueta_tiempotranscurrido.Location = new Point(499, 44);
            etiqueta_tiempotranscurrido.Name = "etiqueta_tiempotranscurrido";
            etiqueta_tiempotranscurrido.Size = new Size(118, 15);
            etiqueta_tiempotranscurrido.TabIndex = 2;
            etiqueta_tiempotranscurrido.Text = "Tiempo transcurrido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(499, 15);
            label1.Name = "label1";
            label1.Size = new Size(174, 15);
            label1.TabIndex = 3;
            label1.Text = "Escala de tiempo - 1 min  : 1 día";
            // 
            // etiqueta_tiempo
            // 
            etiqueta_tiempo.AutoSize = true;
            etiqueta_tiempo.Location = new Point(623, 44);
            etiqueta_tiempo.Name = "etiqueta_tiempo";
            etiqueta_tiempo.Size = new Size(37, 15);
            etiqueta_tiempo.TabIndex = 4;
            etiqueta_tiempo.Text = "0 días";
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(12, 11);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(285, 23);
            btn_agregar.TabIndex = 5;
            btn_agregar.Text = "Simular producto seleccionado";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // etiqueta_correospendientes
            // 
            etiqueta_correospendientes.AutoSize = true;
            etiqueta_correospendientes.Location = new Point(803, 15);
            etiqueta_correospendientes.Name = "etiqueta_correospendientes";
            etiqueta_correospendientes.Size = new Size(13, 15);
            etiqueta_correospendientes.TabIndex = 6;
            etiqueta_correospendientes.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(705, 15);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 7;
            label2.Text = "Correos en cola:";
            // 
            // Temporizador
            // 
            Temporizador.Enabled = true;
            Temporizador.Interval = 1000;
            Temporizador.Tick += Temporizador_Tick;
            // 
            // Formulario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 450);
            Controls.Add(label2);
            Controls.Add(etiqueta_correospendientes);
            Controls.Add(btn_agregar);
            Controls.Add(etiqueta_tiempo);
            Controls.Add(label1);
            Controls.Add(etiqueta_tiempotranscurrido);
            Controls.Add(contenedor_falsoemail);
            Controls.Add(contenedor_listaproductos);
            Name = "Formulario";
            Text = "Index";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox contenedor_listaproductos;
        private TextBox contenedor_falsoemail;
        private Label etiqueta_tiempotranscurrido;
        private Label label1;
        private Label etiqueta_tiempo;
        private Button btn_agregar;
        private Label etiqueta_correospendientes;
        private Label label2;
        private System.Windows.Forms.Timer Temporizador;
    }
}
