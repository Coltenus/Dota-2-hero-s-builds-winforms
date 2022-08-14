namespace DotaHelper1
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(377, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hero\'s build";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(418, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "No data";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(322, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "No data";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(648, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "No data";
            this.label4.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Abaddon",
            "Alchemist",
            "Ancient Apparition",
            "Anti-Mage",
            "Arc Warden",
            "Axe",
            "Bane",
            "Batrider",
            "Beastmaster",
            "Bloodseeker",
            "Bounty Hunter",
            "Brewmaster",
            "Bristleback",
            "Broodmother",
            "Centaur Warrunner",
            "Chaos Knight",
            "Chen",
            "Clinkz",
            "Clockwerk",
            "Crystal Maiden",
            "Dark Seer",
            "Dark Willow",
            "Dawnbreaker",
            "Dazzle",
            "Death Prophet",
            "Disruptor",
            "Doom",
            "Dragon Knight",
            "Drow Ranger",
            "Earth Spirit",
            "Earthshaker",
            "Elder Titan",
            "Ember Spirit",
            "Enchantress",
            "Enigma",
            "Faceless Void",
            "Grimstroke",
            "Gyrocopter",
            "Hoodwink",
            "Huskar",
            "Invoker",
            "Io",
            "Jakiro",
            "Juggernaut",
            "Keeper of the Light",
            "Kunkka",
            "Legion Commander",
            "Leshrac",
            "Lich",
            "Lifestealer",
            "Lina",
            "Lion",
            "Lone Druid",
            "Luna",
            "Lycan",
            "Magnus",
            "Marci",
            "Mars",
            "Medusa",
            "Meepo",
            "Mirana",
            "Monkey King",
            "Morphling",
            "Naga Siren",
            "Natures Prophet",
            "Necrophos",
            "Night Stalker",
            "Nyx Assassin",
            "Ogre Magi",
            "Omniknight",
            "Oracle",
            "Outworld Destroyer",
            "Pangolier",
            "Phantom Assassin",
            "Phantom Lancer",
            "Phoenix",
            "Primal Beast",
            "Puck",
            "Pudge",
            "Pugna",
            "Queen of Pain",
            "Razor",
            "Riki",
            "Rubick",
            "Sand King",
            "Shadow Demon",
            "Shadow Fiend",
            "Shadow Shaman",
            "Silencer",
            "Skywrath Mage",
            "Slardar",
            "Slark",
            "Snapfire",
            "Sniper",
            "Spectre",
            "Spirit Breaker",
            "Storm Spirit",
            "Sven",
            "Techies",
            "Templar Assassin",
            "Terrorblade",
            "Tidehunter",
            "Timbersaw",
            "Tinker",
            "Tiny",
            "Treant Protector",
            "Troll Warlord",
            "Tusk",
            "Underlord",
            "Undying",
            "Ursa",
            "Vengeful Spirit",
            "Venomancer",
            "Viper",
            "Visage",
            "Void Spirit",
            "Warlock",
            "Weaver",
            "Windranger",
            "Winter Wyvern",
            "Witch Doctor",
            "Wraith King",
            "Zeus"});
            this.comboBox1.Location = new System.Drawing.Point(337, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(266, 32);
            this.comboBox1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 43);
            this.button2.TabIndex = 7;
            this.button2.Text = "L/D";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(933, 678);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hero\'s Builds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
    }
}

