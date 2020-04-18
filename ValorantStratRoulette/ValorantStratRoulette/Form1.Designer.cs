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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playerLabel = new System.Windows.Forms.Label();
            this.mapLabel = new System.Windows.Forms.Label();
            this.numOfPlayers = new System.Windows.Forms.ComboBox();
            this.mapSelected = new System.Windows.Forms.ComboBox();
            this.heroList = new System.Windows.Forms.CheckedListBox();
            this.heroListLabel = new System.Windows.Forms.Label();
            this.ablShLabel = new System.Windows.Forms.Label();
            this.abilityShieldsList = new System.Windows.Forms.CheckedListBox();
            this.output = new System.Windows.Forms.TextBox();
            this.randomizeBtn = new System.Windows.Forms.Button();
            this.creditsBtn = new System.Windows.Forms.Button();
            this.sidearmLabel = new System.Windows.Forms.Label();
            this.sidearmsList = new System.Windows.Forms.CheckedListBox();
            this.smgsLabel = new System.Windows.Forms.Label();
            this.smgsList = new System.Windows.Forms.CheckedListBox();
            this.shotgunList = new System.Windows.Forms.CheckedListBox();
            this.sgLabel = new System.Windows.Forms.Label();
            this.riflesList = new System.Windows.Forms.CheckedListBox();
            this.riflesLabel = new System.Windows.Forms.Label();
            this.sniperLabel = new System.Windows.Forms.Label();
            this.sniperList = new System.Windows.Forms.CheckedListBox();
            this.heavyList = new System.Windows.Forms.CheckedListBox();
            this.heavyLabel = new System.Windows.Forms.Label();
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
            "5"});
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
            this.heroList.MultiColumn = true;
            this.heroList.Name = "heroList";
            this.heroList.Size = new System.Drawing.Size(249, 130);
            this.heroList.TabIndex = 4;
            // 
            // heroListLabel
            // 
            this.heroListLabel.AutoSize = true;
            this.heroListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heroListLabel.Location = new System.Drawing.Point(8, 102);
            this.heroListLabel.Name = "heroListLabel";
            this.heroListLabel.Size = new System.Drawing.Size(65, 20);
            this.heroListLabel.TabIndex = 5;
            this.heroListLabel.Text = "Heroes:";
            // 
            // ablShLabel
            // 
            this.ablShLabel.AutoSize = true;
            this.ablShLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ablShLabel.Location = new System.Drawing.Point(283, 102);
            this.ablShLabel.Name = "ablShLabel";
            this.ablShLabel.Size = new System.Drawing.Size(127, 20);
            this.ablShLabel.TabIndex = 6;
            this.ablShLabel.Text = "Abilities/ Shields:";
            // 
            // abilityShieldsList
            // 
            this.abilityShieldsList.CheckOnClick = true;
            this.abilityShieldsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abilityShieldsList.FormattingEnabled = true;
            this.abilityShieldsList.Items.AddRange(new object[] {
            "Light Shields",
            "Heavy Shields",
            "Ability 1",
            "Ability 2",
            "Ability 3"});
            this.abilityShieldsList.Location = new System.Drawing.Point(287, 125);
            this.abilityShieldsList.MultiColumn = true;
            this.abilityShieldsList.Name = "abilityShieldsList";
            this.abilityShieldsList.Size = new System.Drawing.Size(131, 130);
            this.abilityShieldsList.TabIndex = 7;
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(470, 12);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.output.Size = new System.Drawing.Size(378, 474);
            this.output.TabIndex = 8;
            this.output.WordWrap = false;
            // 
            // randomizeBtn
            // 
            this.randomizeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomizeBtn.Location = new System.Drawing.Point(9, 439);
            this.randomizeBtn.Name = "randomizeBtn";
            this.randomizeBtn.Size = new System.Drawing.Size(311, 47);
            this.randomizeBtn.TabIndex = 9;
            this.randomizeBtn.Text = "Randomize";
            this.randomizeBtn.UseVisualStyleBackColor = true;
            this.randomizeBtn.Click += new System.EventHandler(this.randomizeBtn_Click);
            // 
            // creditsBtn
            // 
            this.creditsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsBtn.Location = new System.Drawing.Point(326, 439);
            this.creditsBtn.Name = "creditsBtn";
            this.creditsBtn.Size = new System.Drawing.Size(135, 47);
            this.creditsBtn.TabIndex = 10;
            this.creditsBtn.Text = "Credits";
            this.creditsBtn.UseVisualStyleBackColor = true;
            this.creditsBtn.Click += new System.EventHandler(this.creditsBtn_Click);
            // 
            // sidearmLabel
            // 
            this.sidearmLabel.AutoSize = true;
            this.sidearmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sidearmLabel.Location = new System.Drawing.Point(12, 275);
            this.sidearmLabel.Name = "sidearmLabel";
            this.sidearmLabel.Size = new System.Drawing.Size(80, 20);
            this.sidearmLabel.TabIndex = 11;
            this.sidearmLabel.Text = "Sidearms:";
            // 
            // sidearmsList
            // 
            this.sidearmsList.CheckOnClick = true;
            this.sidearmsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sidearmsList.FormattingEnabled = true;
            this.sidearmsList.Items.AddRange(new object[] {
            "Classic",
            "Shorty",
            "Frenzy",
            "Ghost",
            "Sheriff"});
            this.sidearmsList.Location = new System.Drawing.Point(12, 298);
            this.sidearmsList.Name = "sidearmsList";
            this.sidearmsList.Size = new System.Drawing.Size(100, 109);
            this.sidearmsList.TabIndex = 12;
            // 
            // smgsLabel
            // 
            this.smgsLabel.AutoSize = true;
            this.smgsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smgsLabel.Location = new System.Drawing.Point(123, 275);
            this.smgsLabel.Name = "smgsLabel";
            this.smgsLabel.Size = new System.Drawing.Size(54, 20);
            this.smgsLabel.TabIndex = 13;
            this.smgsLabel.Text = "Smgs:";
            // 
            // smgsList
            // 
            this.smgsList.CheckOnClick = true;
            this.smgsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smgsList.FormattingEnabled = true;
            this.smgsList.Items.AddRange(new object[] {
            "Stinger",
            "Spectre"});
            this.smgsList.Location = new System.Drawing.Point(127, 298);
            this.smgsList.Name = "smgsList";
            this.smgsList.Size = new System.Drawing.Size(88, 46);
            this.smgsList.TabIndex = 14;
            // 
            // shotgunList
            // 
            this.shotgunList.CheckOnClick = true;
            this.shotgunList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shotgunList.FormattingEnabled = true;
            this.shotgunList.Items.AddRange(new object[] {
            "Bucky",
            "Judge"});
            this.shotgunList.Location = new System.Drawing.Point(127, 370);
            this.shotgunList.Name = "shotgunList";
            this.shotgunList.Size = new System.Drawing.Size(88, 46);
            this.shotgunList.TabIndex = 15;
            // 
            // sgLabel
            // 
            this.sgLabel.AutoSize = true;
            this.sgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sgLabel.Location = new System.Drawing.Point(123, 347);
            this.sgLabel.Name = "sgLabel";
            this.sgLabel.Size = new System.Drawing.Size(82, 20);
            this.sgLabel.TabIndex = 16;
            this.sgLabel.Text = "Shotguns:";
            // 
            // riflesList
            // 
            this.riflesList.CheckOnClick = true;
            this.riflesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.riflesList.FormattingEnabled = true;
            this.riflesList.Items.AddRange(new object[] {
            "Bulldog",
            "Guardian",
            "Phantom",
            "Vandal"});
            this.riflesList.Location = new System.Drawing.Point(242, 298);
            this.riflesList.Name = "riflesList";
            this.riflesList.Size = new System.Drawing.Size(100, 88);
            this.riflesList.TabIndex = 17;
            // 
            // riflesLabel
            // 
            this.riflesLabel.AutoSize = true;
            this.riflesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.riflesLabel.Location = new System.Drawing.Point(238, 275);
            this.riflesLabel.Name = "riflesLabel";
            this.riflesLabel.Size = new System.Drawing.Size(53, 20);
            this.riflesLabel.TabIndex = 18;
            this.riflesLabel.Text = "Rifles:";
            // 
            // sniperLabel
            // 
            this.sniperLabel.AutoSize = true;
            this.sniperLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sniperLabel.Location = new System.Drawing.Point(353, 275);
            this.sniperLabel.Name = "sniperLabel";
            this.sniperLabel.Size = new System.Drawing.Size(67, 20);
            this.sniperLabel.TabIndex = 19;
            this.sniperLabel.Text = "Snipers:";
            // 
            // sniperList
            // 
            this.sniperList.CheckOnClick = true;
            this.sniperList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sniperList.FormattingEnabled = true;
            this.sniperList.Items.AddRange(new object[] {
            "Marshal",
            "Operator"});
            this.sniperList.Location = new System.Drawing.Point(357, 298);
            this.sniperList.Name = "sniperList";
            this.sniperList.Size = new System.Drawing.Size(100, 46);
            this.sniperList.TabIndex = 20;
            // 
            // heavyList
            // 
            this.heavyList.CheckOnClick = true;
            this.heavyList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heavyList.FormattingEnabled = true;
            this.heavyList.Items.AddRange(new object[] {
            "Ares",
            "Odin"});
            this.heavyList.Location = new System.Drawing.Point(357, 370);
            this.heavyList.Name = "heavyList";
            this.heavyList.Size = new System.Drawing.Size(100, 46);
            this.heavyList.TabIndex = 21;
            // 
            // heavyLabel
            // 
            this.heavyLabel.AutoSize = true;
            this.heavyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heavyLabel.Location = new System.Drawing.Point(353, 347);
            this.heavyLabel.Name = "heavyLabel";
            this.heavyLabel.Size = new System.Drawing.Size(57, 20);
            this.heavyLabel.TabIndex = 22;
            this.heavyLabel.Text = "Heavy:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 505);
            this.Controls.Add(this.heavyLabel);
            this.Controls.Add(this.heavyList);
            this.Controls.Add(this.sniperList);
            this.Controls.Add(this.sniperLabel);
            this.Controls.Add(this.riflesLabel);
            this.Controls.Add(this.riflesList);
            this.Controls.Add(this.sgLabel);
            this.Controls.Add(this.shotgunList);
            this.Controls.Add(this.smgsList);
            this.Controls.Add(this.smgsLabel);
            this.Controls.Add(this.sidearmsList);
            this.Controls.Add(this.sidearmLabel);
            this.Controls.Add(this.creditsBtn);
            this.Controls.Add(this.randomizeBtn);
            this.Controls.Add(this.output);
            this.Controls.Add(this.abilityShieldsList);
            this.Controls.Add(this.ablShLabel);
            this.Controls.Add(this.heroListLabel);
            this.Controls.Add(this.heroList);
            this.Controls.Add(this.mapSelected);
            this.Controls.Add(this.numOfPlayers);
            this.Controls.Add(this.mapLabel);
            this.Controls.Add(this.playerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label ablShLabel;
        private System.Windows.Forms.CheckedListBox abilityShieldsList;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button randomizeBtn;
        private System.Windows.Forms.Button creditsBtn;
        private System.Windows.Forms.Label sidearmLabel;
        private System.Windows.Forms.CheckedListBox sidearmsList;
        private System.Windows.Forms.Label smgsLabel;
        private System.Windows.Forms.CheckedListBox smgsList;
        private System.Windows.Forms.CheckedListBox shotgunList;
        private System.Windows.Forms.Label sgLabel;
        private System.Windows.Forms.CheckedListBox riflesList;
        private System.Windows.Forms.Label riflesLabel;
        private System.Windows.Forms.Label sniperLabel;
        private System.Windows.Forms.CheckedListBox sniperList;
        private System.Windows.Forms.CheckedListBox heavyList;
        private System.Windows.Forms.Label heavyLabel;
    }
}

