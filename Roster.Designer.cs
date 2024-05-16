namespace WH40K_GUI_UAT_MS539_ML_Week2
{
    partial class Roster
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
            this.rosterNameTxt = new System.Windows.Forms.TextBox();
            this.rosterCharactersLbl = new System.Windows.Forms.Label();
            this.rosterBattleLineLbl = new System.Windows.Forms.Label();
            this.dedicatedTransportLbl = new System.Windows.Forms.Label();
            this.otherDatasheetsLbl = new System.Windows.Forms.Label();
            this.alliedUnitsLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rosterNameTxt
            // 
            this.rosterNameTxt.Location = new System.Drawing.Point(12, 12);
            this.rosterNameTxt.Name = "rosterNameTxt";
            this.rosterNameTxt.Size = new System.Drawing.Size(100, 26);
            this.rosterNameTxt.TabIndex = 0;
            this.rosterNameTxt.Text = "RosterName";
            // 
            // rosterCharactersLbl
            // 
            this.rosterCharactersLbl.AutoSize = true;
            this.rosterCharactersLbl.Location = new System.Drawing.Point(8, 45);
            this.rosterCharactersLbl.Name = "rosterCharactersLbl";
            this.rosterCharactersLbl.Size = new System.Drawing.Size(87, 20);
            this.rosterCharactersLbl.TabIndex = 1;
            this.rosterCharactersLbl.Text = "Characters";
            // 
            // rosterBattleLineLbl
            // 
            this.rosterBattleLineLbl.AutoSize = true;
            this.rosterBattleLineLbl.Location = new System.Drawing.Point(8, 65);
            this.rosterBattleLineLbl.Name = "rosterBattleLineLbl";
            this.rosterBattleLineLbl.Size = new System.Drawing.Size(81, 20);
            this.rosterBattleLineLbl.TabIndex = 2;
            this.rosterBattleLineLbl.Text = "BattleLine";
            // 
            // dedicatedTransportLbl
            // 
            this.dedicatedTransportLbl.AutoSize = true;
            this.dedicatedTransportLbl.Location = new System.Drawing.Point(8, 85);
            this.dedicatedTransportLbl.Name = "dedicatedTransportLbl";
            this.dedicatedTransportLbl.Size = new System.Drawing.Size(154, 20);
            this.dedicatedTransportLbl.TabIndex = 3;
            this.dedicatedTransportLbl.Text = "Dedicated Transport";
            // 
            // otherDatasheetsLbl
            // 
            this.otherDatasheetsLbl.AutoSize = true;
            this.otherDatasheetsLbl.Location = new System.Drawing.Point(8, 105);
            this.otherDatasheetsLbl.Name = "otherDatasheetsLbl";
            this.otherDatasheetsLbl.Size = new System.Drawing.Size(136, 20);
            this.otherDatasheetsLbl.TabIndex = 4;
            this.otherDatasheetsLbl.Text = "Other Datasheets";
            // 
            // alliedUnitsLbl
            // 
            this.alliedUnitsLbl.AutoSize = true;
            this.alliedUnitsLbl.Location = new System.Drawing.Point(8, 125);
            this.alliedUnitsLbl.Name = "alliedUnitsLbl";
            this.alliedUnitsLbl.Size = new System.Drawing.Size(88, 20);
            this.alliedUnitsLbl.TabIndex = 5;
            this.alliedUnitsLbl.Text = "Allied Units";
            // 
            // Roster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.alliedUnitsLbl);
            this.Controls.Add(this.otherDatasheetsLbl);
            this.Controls.Add(this.dedicatedTransportLbl);
            this.Controls.Add(this.rosterBattleLineLbl);
            this.Controls.Add(this.rosterCharactersLbl);
            this.Controls.Add(this.rosterNameTxt);
            this.Name = "Roster";
            this.Text = "Roster";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rosterNameTxt;
        private System.Windows.Forms.Label rosterCharactersLbl;
        private System.Windows.Forms.Label rosterBattleLineLbl;
        private System.Windows.Forms.Label dedicatedTransportLbl;
        private System.Windows.Forms.Label otherDatasheetsLbl;
        private System.Windows.Forms.Label alliedUnitsLbl;
    }
}