﻿namespace InsertBlob {
  partial class Hauptfenster {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent() {
      this.BttnBild = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // BttnBild
      // 
      this.BttnBild.Location = new System.Drawing.Point(13, 13);
      this.BttnBild.Name = "BttnBild";
      this.BttnBild.Size = new System.Drawing.Size(91, 23);
      this.BttnBild.TabIndex = 0;
      this.BttnBild.Text = "Bild";
      this.BttnBild.UseVisualStyleBackColor = true;
      this.BttnBild.Click += new System.EventHandler(this.BttnBild_Click);
      // 
      // Hauptfenster
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(116, 51);
      this.Controls.Add(this.BttnBild);
      this.Name = "Hauptfenster";
      this.Text = "Form1";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button BttnBild;
  }
}

