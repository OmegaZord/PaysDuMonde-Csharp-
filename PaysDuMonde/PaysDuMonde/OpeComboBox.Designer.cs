namespace OperationComboBox
{
    partial class OpeComboBox
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
            this.lbCultures = new System.Windows.Forms.ListBox();
            this.cbCultures = new System.Windows.Forms.ComboBox();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnFullRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnFullLeft = new System.Windows.Forms.Button();
            this.btnBottom = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.btnLess = new System.Windows.Forms.Button();
            this.btnMore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCultures
            // 
            this.lbCultures.FormattingEnabled = true;
            this.lbCultures.Location = new System.Drawing.Point(282, 13);
            this.lbCultures.Name = "lbCultures";
            this.lbCultures.Size = new System.Drawing.Size(279, 277);
            this.lbCultures.TabIndex = 9;
            this.lbCultures.SelectedIndexChanged += new System.EventHandler(this.lbCultures_SelectedIndexChanged);
            // 
            // cbCultures
            // 
            this.cbCultures.FormattingEnabled = true;
            this.cbCultures.Location = new System.Drawing.Point(26, 13);
            this.cbCultures.Name = "cbCultures";
            this.cbCultures.Size = new System.Drawing.Size(121, 21);
            this.cbCultures.TabIndex = 0;
            this.cbCultures.SelectedIndexChanged += new System.EventHandler(this.cbCultures_SelectedIndexChanged);
            this.cbCultures.TextChanged += new System.EventHandler(this.cbCultures_TextChanged);
            this.cbCultures.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbCultures_KeyDown);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(183, 103);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 1;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnFullRight
            // 
            this.btnFullRight.Location = new System.Drawing.Point(182, 161);
            this.btnFullRight.Name = "btnFullRight";
            this.btnFullRight.Size = new System.Drawing.Size(75, 23);
            this.btnFullRight.TabIndex = 3;
            this.btnFullRight.Text = ">>";
            this.btnFullRight.UseVisualStyleBackColor = true;
            this.btnFullRight.Click += new System.EventHandler(this.btnFullRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(183, 132);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnFullLeft
            // 
            this.btnFullLeft.Location = new System.Drawing.Point(182, 190);
            this.btnFullLeft.Name = "btnFullLeft";
            this.btnFullLeft.Size = new System.Drawing.Size(75, 23);
            this.btnFullLeft.TabIndex = 4;
            this.btnFullLeft.Text = "<<";
            this.btnFullLeft.UseVisualStyleBackColor = true;
            this.btnFullLeft.Click += new System.EventHandler(this.btnFullLeft_Click);
            // 
            // btnBottom
            // 
            this.btnBottom.Location = new System.Drawing.Point(421, 325);
            this.btnBottom.Name = "btnBottom";
            this.btnBottom.Size = new System.Drawing.Size(75, 23);
            this.btnBottom.TabIndex = 8;
            this.btnBottom.Text = "Bottom";
            this.btnBottom.UseVisualStyleBackColor = true;
            this.btnBottom.Click += new System.EventHandler(this.btnBottom_Click);
            // 
            // btnTop
            // 
            this.btnTop.Location = new System.Drawing.Point(340, 325);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(75, 23);
            this.btnTop.TabIndex = 7;
            this.btnTop.Text = "Top";
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // btnLess
            // 
            this.btnLess.Location = new System.Drawing.Point(340, 296);
            this.btnLess.Name = "btnLess";
            this.btnLess.Size = new System.Drawing.Size(75, 23);
            this.btnLess.TabIndex = 5;
            this.btnLess.Text = "-";
            this.btnLess.UseVisualStyleBackColor = true;
            this.btnLess.Click += new System.EventHandler(this.btnLess_Click);
            // 
            // btnMore
            // 
            this.btnMore.Location = new System.Drawing.Point(421, 296);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(75, 23);
            this.btnMore.TabIndex = 6;
            this.btnMore.Text = "+";
            this.btnMore.UseVisualStyleBackColor = true;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // OpeComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 363);
            this.Controls.Add(this.btnMore);
            this.Controls.Add(this.btnFullLeft);
            this.Controls.Add(this.btnLess);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.btnFullRight);
            this.Controls.Add(this.btnBottom);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.lbCultures);
            this.Controls.Add(this.cbCultures);
            this.Name = "OpeComboBox";
            this.Text = "ComboBox et ListBox";
            this.Load += new System.EventHandler(this.OpeComboBox_Load);
            this.Click += new System.EventHandler(this.OpeComboBox_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbCultures;
        private System.Windows.Forms.ComboBox cbCultures;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnFullRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnFullLeft;
        private System.Windows.Forms.Button btnBottom;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.Button btnLess;
        private System.Windows.Forms.Button btnMore;
    }
}

