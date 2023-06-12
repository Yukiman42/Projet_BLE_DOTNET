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
            this.panelLed = new System.Windows.Forms.Panel();
            this.clearBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textPort = new System.Windows.Forms.TextBox();
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
            // panelLed
            // 
            this.panelLed.Location = new System.Drawing.Point(16, 15);
            this.panelLed.Margin = new System.Windows.Forms.Padding(4);
            this.panelLed.Name = "panelLed";
            this.panelLed.Size = new System.Drawing.Size(1015, 255);
            this.panelLed.TabIndex = 3;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = " Port d\'écoute : ";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 356);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelLed);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.sendBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Projet Afficheur LED";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Panel panelLed;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPort;
    }
}

