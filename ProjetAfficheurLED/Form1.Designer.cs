namespace ProjetAfficheurLED
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.sendBtn = new System.Windows.Forms.Button();
            this.textPort = new System.Windows.Forms.TextBox();
            this.panelLed = new System.Windows.Forms.Panel();
            this.listFiles = new System.Windows.Forms.ListBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.textFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(13, 309);
            this.sendBtn.Margin = new System.Windows.Forms.Padding(4);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(119, 38);
            this.sendBtn.TabIndex = 0;
            this.sendBtn.Text = "Envoyer";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(128, 279);
            this.textPort.Margin = new System.Windows.Forms.Padding(4);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(132, 22);
            this.textPort.TabIndex = 1;
            this.textPort.Text = "4444";
            // 
            // panelLed
            // 
            this.panelLed.Location = new System.Drawing.Point(16, 15);
            this.panelLed.Margin = new System.Windows.Forms.Padding(4);
            this.panelLed.Name = "panelLed";
            this.panelLed.Size = new System.Drawing.Size(1015, 255);
            this.panelLed.TabIndex = 3;
            // 
            // listFiles
            // 
            this.listFiles.FormattingEnabled = true;
            this.listFiles.ItemHeight = 16;
            this.listFiles.Location = new System.Drawing.Point(1039, 15);
            this.listFiles.Margin = new System.Windows.Forms.Padding(4);
            this.listFiles.Name = "listFiles";
            this.listFiles.Size = new System.Drawing.Size(279, 260);
            this.listFiles.TabIndex = 6;
            // 
            // saveBtn
            // 
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(1211, 309);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(107, 38);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Sauvegarder";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(1060, 310);
            this.loadBtn.Margin = new System.Windows.Forms.Padding(4);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(143, 37);
            this.loadBtn.TabIndex = 8;
            this.loadBtn.Text = "Charger un fichier";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // textFileName
            // 
            this.textFileName.Location = new System.Drawing.Point(1167, 279);
            this.textFileName.Margin = new System.Windows.Forms.Padding(4);
            this.textFileName.Name = "textFileName";
            this.textFileName.Size = new System.Drawing.Size(151, 22);
            this.textFileName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = " Port d\'écoute : ";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(141, 309);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(119, 38);
            this.clearBtn.TabIndex = 13;
            this.clearBtn.Text = "CLEAR";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(1019, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nom du fichier :";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(904, 310);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(149, 37);
            this.deleteBtn.TabIndex = 15;
            this.deleteBtn.Text = "Supprimer un fichier";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 356);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textFileName);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.listFiles);
            this.Controls.Add(this.panelLed);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.sendBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Control Badge Virtuel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.Panel panelLed;
        private System.Windows.Forms.ListBox listFiles;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.TextBox textFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteBtn;
    }
}

