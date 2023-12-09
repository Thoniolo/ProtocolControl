namespace ProtocolControl
{
    partial class ProtocolForm
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
            this.lblCompany = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.btnGenerateProtocol = new System.Windows.Forms.Button();
            this.btnViewProtocols = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(91, 82);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(54, 13);
            this.lblCompany.TabIndex = 5;
            this.lblCompany.Text = "Empresa :";
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(160, 79);
            this.txtCompany.MaxLength = 6;
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(159, 20);
            this.txtCompany.TabIndex = 4;
            // 
            // btnGenerateProtocol
            // 
            this.btnGenerateProtocol.Location = new System.Drawing.Point(210, 105);
            this.btnGenerateProtocol.Name = "btnGenerateProtocol";
            this.btnGenerateProtocol.Size = new System.Drawing.Size(109, 35);
            this.btnGenerateProtocol.TabIndex = 3;
            this.btnGenerateProtocol.Text = "Gerar Protocolo";
            this.btnGenerateProtocol.UseVisualStyleBackColor = true;
            this.btnGenerateProtocol.Click += new System.EventHandler(this.btnGenerateProtocol_Click);
            // 
            // btnViewProtocols
            // 
            this.btnViewProtocols.Location = new System.Drawing.Point(94, 105);
            this.btnViewProtocols.Name = "btnViewProtocols";
            this.btnViewProtocols.Size = new System.Drawing.Size(110, 35);
            this.btnViewProtocols.TabIndex = 6;
            this.btnViewProtocols.Text = "Exibir Protocolos";
            this.btnViewProtocols.UseVisualStyleBackColor = true;
            this.btnViewProtocols.Click += new System.EventHandler(this.btnViewProtocols_Click);
            // 
            // ProtocolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 225);
            this.Controls.Add(this.btnViewProtocols);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.btnGenerateProtocol);
            this.Name = "ProtocolForm";
            this.Text = ".:: Gerar Protocolo ::.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Button btnGenerateProtocol;
        private System.Windows.Forms.Button btnViewProtocols;
    }
}