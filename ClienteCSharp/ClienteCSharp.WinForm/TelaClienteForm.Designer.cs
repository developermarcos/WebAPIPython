namespace ClienteCSharp.WinForm
{
    partial class TelaClienteForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelStatusCpf = new System.Windows.Forms.Label();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.txtBoxIdade = new System.Windows.Forms.TextBox();
            this.txtBoxCPF = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.groupBoxTipoRequest = new System.Windows.Forms.GroupBox();
            this.rBtnDelete = new System.Windows.Forms.RadioButton();
            this.rBtnPut = new System.Windows.Forms.RadioButton();
            this.rBtnPost = new System.Windows.Forms.RadioButton();
            this.rBtnGet = new System.Windows.Forms.RadioButton();
            this.txtBoxResultado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxTipoRequest.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Idade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "CPF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(509, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Status CPF";
            // 
            // labelStatusCpf
            // 
            this.labelStatusCpf.AutoSize = true;
            this.labelStatusCpf.Location = new System.Drawing.Point(509, 41);
            this.labelStatusCpf.Name = "labelStatusCpf";
            this.labelStatusCpf.Size = new System.Drawing.Size(0, 15);
            this.labelStatusCpf.TabIndex = 5;
            // 
            // txtBoxID
            // 
            this.txtBoxID.Location = new System.Drawing.Point(56, 141);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(100, 23);
            this.txtBoxID.TabIndex = 6;
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(56, 170);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(156, 23);
            this.txtBoxNome.TabIndex = 7;
            // 
            // txtBoxIdade
            // 
            this.txtBoxIdade.Location = new System.Drawing.Point(56, 199);
            this.txtBoxIdade.Name = "txtBoxIdade";
            this.txtBoxIdade.Size = new System.Drawing.Size(100, 23);
            this.txtBoxIdade.TabIndex = 8;
            // 
            // txtBoxCPF
            // 
            this.txtBoxCPF.Location = new System.Drawing.Point(403, 38);
            this.txtBoxCPF.Name = "txtBoxCPF";
            this.txtBoxCPF.Size = new System.Drawing.Size(100, 23);
            this.txtBoxCPF.TabIndex = 9;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(56, 228);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(100, 23);
            this.btnEnviar.TabIndex = 10;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(403, 77);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 11;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // groupBoxTipoRequest
            // 
            this.groupBoxTipoRequest.Controls.Add(this.rBtnDelete);
            this.groupBoxTipoRequest.Controls.Add(this.rBtnPut);
            this.groupBoxTipoRequest.Controls.Add(this.rBtnPost);
            this.groupBoxTipoRequest.Controls.Add(this.rBtnGet);
            this.groupBoxTipoRequest.Location = new System.Drawing.Point(12, 9);
            this.groupBoxTipoRequest.Name = "groupBoxTipoRequest";
            this.groupBoxTipoRequest.Size = new System.Drawing.Size(200, 126);
            this.groupBoxTipoRequest.TabIndex = 12;
            this.groupBoxTipoRequest.TabStop = false;
            this.groupBoxTipoRequest.Text = "Request";
            // 
            // rBtnDelete
            // 
            this.rBtnDelete.AutoSize = true;
            this.rBtnDelete.Location = new System.Drawing.Point(6, 97);
            this.rBtnDelete.Name = "rBtnDelete";
            this.rBtnDelete.Size = new System.Drawing.Size(63, 19);
            this.rBtnDelete.TabIndex = 3;
            this.rBtnDelete.TabStop = true;
            this.rBtnDelete.Text = "DELETE";
            this.rBtnDelete.UseVisualStyleBackColor = true;
            // 
            // rBtnPut
            // 
            this.rBtnPut.AutoSize = true;
            this.rBtnPut.Location = new System.Drawing.Point(6, 72);
            this.rBtnPut.Name = "rBtnPut";
            this.rBtnPut.Size = new System.Drawing.Size(46, 19);
            this.rBtnPut.TabIndex = 2;
            this.rBtnPut.TabStop = true;
            this.rBtnPut.Text = "PUT";
            this.rBtnPut.UseVisualStyleBackColor = true;
            // 
            // rBtnPost
            // 
            this.rBtnPost.AutoSize = true;
            this.rBtnPost.Location = new System.Drawing.Point(6, 47);
            this.rBtnPost.Name = "rBtnPost";
            this.rBtnPost.Size = new System.Drawing.Size(53, 19);
            this.rBtnPost.TabIndex = 1;
            this.rBtnPost.TabStop = true;
            this.rBtnPost.Text = "POST";
            this.rBtnPost.UseVisualStyleBackColor = true;
            // 
            // rBtnGet
            // 
            this.rBtnGet.AutoSize = true;
            this.rBtnGet.Location = new System.Drawing.Point(6, 22);
            this.rBtnGet.Name = "rBtnGet";
            this.rBtnGet.Size = new System.Drawing.Size(45, 19);
            this.rBtnGet.TabIndex = 0;
            this.rBtnGet.TabStop = true;
            this.rBtnGet.Text = "GET";
            this.rBtnGet.UseVisualStyleBackColor = true;
            // 
            // txtBoxResultado
            // 
            this.txtBoxResultado.Location = new System.Drawing.Point(309, 144);
            this.txtBoxResultado.Multiline = true;
            this.txtBoxResultado.Name = "txtBoxResultado";
            this.txtBoxResultado.Size = new System.Drawing.Size(286, 102);
            this.txtBoxResultado.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Resultado";
            // 
            // TelaClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxResultado);
            this.Controls.Add(this.groupBoxTipoRequest);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtBoxCPF);
            this.Controls.Add(this.txtBoxIdade);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.txtBoxID);
            this.Controls.Add(this.labelStatusCpf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaClienteForm";
            this.Text = "Form1";
            this.groupBoxTipoRequest.ResumeLayout(false);
            this.groupBoxTipoRequest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelStatusCpf;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.TextBox txtBoxIdade;
        private System.Windows.Forms.TextBox txtBoxCPF;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox groupBoxTipoRequest;
        private System.Windows.Forms.RadioButton rBtnDelete;
        private System.Windows.Forms.RadioButton rBtnPut;
        private System.Windows.Forms.RadioButton rBtnPost;
        private System.Windows.Forms.RadioButton rBtnGet;
        private System.Windows.Forms.TextBox txtBoxResultado;
        private System.Windows.Forms.Label label6;
    }
}
