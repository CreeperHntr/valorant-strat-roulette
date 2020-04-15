namespace ValorantStratRoulette
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
            this.playerLabel = new System.Windows.Forms.Label();
            this.mapLabel = new System.Windows.Forms.Label();
            this.numOfPlayers = new System.Windows.Forms.ComboBox();
            this.mapSelected = new System.Windows.Forms.ComboBox();
            this.heroList = new System.Windows.Forms.CheckedListBox();
            this.heroListLabel = new System.Windows.Forms.Label();
            this.weaponListLabel = new System.Windows.Forms.Label();
            this.weaponsList = new System.Windows.Forms.CheckedListBox();
            this.output = new System.Windows.Forms.TextBox();
            this.randomizeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLabel.Location = new System.Drawing.Point(14, 14);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(142, 20);
            this.playerLabel.TabIndex = 0;
            this.playerLabel.Text = "Number of Players:";
            // 
            // mapLabel
            // 
            this.mapLabel.AutoSize = true;
            this.mapLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapLabel.Location = new System.Drawing.Point(13, 46);
            this.mapLabel.Name = "mapLabel";
            this.mapLabel.Size = new System.Drawing.Size(48, 20);
            this.mapLabel.TabIndex = 1;
            this.mapLabel.Text = "Map: ";
            // 
            // numOfPlayers
            // 
            this.numOfPlayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numOfPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfPlayers.FormattingEnabled = true;
            this.numOfPlayers.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "10"});
            this.numOfPlayers.Location = new System.Drawing.Point(161, 12);
            this.numOfPlayers.Name = "numOfPlayers";
            this.numOfPlayers.Size = new System.Drawing.Size(87, 28);
            this.numOfPlayers.TabIndex = 2;
            // 
            // mapSelected
            // 
            this.mapSelected.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mapSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapSelected.FormattingEnabled = true;
            this.mapSelected.Items.AddRange(new object[] {
            "Haven",
            "Bind",
            "Split"});
            this.mapSelected.Location = new System.Drawing.Point(161, 46);
            this.mapSelected.Name = "mapSelected";
            this.mapSelected.Size = new System.Drawing.Size(87, 28);
            this.mapSelected.TabIndex = 3;
            // 
            // heroList
            // 
            this.heroList.CheckOnClick = true;
            this.heroList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heroList.FormattingEnabled = true;
            this.heroList.Items.AddRange(new object[] {
            "Brimstone",
            "Jett",
            "Phoenix",
            "Raze",
            "Sage",
            "Sova",
            "Viper",
            "Breach",
            "Cypher",
            "Omen"});
            this.heroList.Location = new System.Drawing.Point(12, 125);
            this.heroList.Name = "heroList";
            this.heroList.Size = new System.Drawing.Size(120, 214);
            this.heroList.TabIndex = 4;
            // 
            // heroListLabel
            // 
            this.heroListLabel.AutoSize = true;
            this.heroListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heroListLabel.Location = new System.Drawing.Point(8, 102);
            this.heroListLabel.Name = "heroListLabel";
            this.heroListLabel.Size = new System.Drawing.Size(119, 20);
            this.heroListLabel.TabIndex = 5;
            this.heroListLabel.Text = "Enable Heroes:";
            // 
            // weaponListLabel
            // 
            this.weaponListLabel.AutoSize = true;
            this.weaponListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weaponListLabel.Location = new System.Drawing.Point(157, 102);
            this.weaponListLabel.Name = "weaponListLabel";
            this.weaponListLabel.Size = new System.Drawing.Size(135, 20);
            this.weaponListLabel.TabIndex = 6;
            this.weaponListLabel.Text = "Enable Weapons:";
            // 
            // weaponsList
            // 
            this.weaponsList.CheckOnClick = true;
            this.weaponsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weaponsList.FormattingEnabled = true;
            this.weaponsList.Items.AddRange(new object[] {
            "Shorty",
            "Frenzy",
            "Ghost",
            "Sheriff",
            "Stinger",
            "Spectre",
            "Bucky",
            "Judge",
            "Bulldog",
            "Guardian",
            "Phantom",
            "Vandal",
            "Marshal",
            "Operator",
            "Ares",
            "Odin"});
            this.weaponsList.Location = new System.Drawing.Point(161, 125);
            this.weaponsList.MultiColumn = true;
            this.weaponsList.Name = "weaponsList";
            this.weaponsList.Size = new System.Drawing.Size(256, 214);
            this.weaponsList.TabIndex = 7;
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(433, 12);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(355, 390);
            this.output.TabIndex = 8;
            this.output.WordWrap = false;
            // 
            // randomizeBtn
            // 
            this.randomizeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomizeBtn.Location = new System.Drawing.Point(12, 355);
            this.randomizeBtn.Name = "randomizeBtn";
            this.randomizeBtn.Size = new System.Drawing.Size(405, 47);
            this.randomizeBtn.TabIndex = 9;
            this.randomizeBtn.Text = "Randomize";
            this.randomizeBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 414);
            this.Controls.Add(this.randomizeBtn);
            this.Controls.Add(this.output);
            this.Controls.Add(this.weaponsList);
            this.Controls.Add(this.weaponListLabel);
            this.Controls.Add(this.heroListLabel);
            this.Controls.Add(this.heroList);
            this.Controls.Add(this.mapSelected);
            this.Controls.Add(this.numOfPlayers);
            this.Controls.Add(this.mapLabel);
            this.Controls.Add(this.playerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Valorant Strat Roulette";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label mapLabel;
        private System.Windows.Forms.ComboBox numOfPlayers;
        private System.Windows.Forms.ComboBox mapSelected;
        private System.Windows.Forms.CheckedListBox heroList;
        private System.Windows.Forms.Label heroListLabel;
        private System.Windows.Forms.Label weaponListLabel;
        private System.Windows.Forms.CheckedListBox weaponsList;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button randomizeBtn;
    }
}

