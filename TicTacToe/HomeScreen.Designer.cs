namespace TicTacToe
{
    partial class HomeScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.topBlackLabel = new System.Windows.Forms.Label();
            this.bottomBlackLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.singlePlayerButton = new System.Windows.Forms.Button();
            this.multiplayerButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // topBlackLabel
            // 
            this.topBlackLabel.BackColor = System.Drawing.Color.Black;
            this.topBlackLabel.Location = new System.Drawing.Point(0, 0);
            this.topBlackLabel.Name = "topBlackLabel";
            this.topBlackLabel.Size = new System.Drawing.Size(1350, 74);
            this.topBlackLabel.TabIndex = 1;
            // 
            // bottomBlackLabel
            // 
            this.bottomBlackLabel.BackColor = System.Drawing.Color.Black;
            this.bottomBlackLabel.Location = new System.Drawing.Point(0, 824);
            this.bottomBlackLabel.Name = "bottomBlackLabel";
            this.bottomBlackLabel.Size = new System.Drawing.Size(1350, 76);
            this.bottomBlackLabel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 40F);
            this.label2.Location = new System.Drawing.Point(415, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(547, 93);
            this.label2.TabIndex = 4;
            this.label2.Text = "TIC TAC TOE";
            // 
            // singlePlayerButton
            // 
            this.singlePlayerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.singlePlayerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.singlePlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.singlePlayerButton.ForeColor = System.Drawing.Color.Maroon;
            this.singlePlayerButton.Location = new System.Drawing.Point(431, 417);
            this.singlePlayerButton.Name = "singlePlayerButton";
            this.singlePlayerButton.Size = new System.Drawing.Size(143, 66);
            this.singlePlayerButton.TabIndex = 1;
            this.singlePlayerButton.Text = "Single Player";
            this.singlePlayerButton.UseVisualStyleBackColor = true;
            this.singlePlayerButton.Click += new System.EventHandler(this.singlePlayerButton_Click);
            // 
            // multiplayerButton
            // 
            this.multiplayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiplayerButton.ForeColor = System.Drawing.Color.Maroon;
            this.multiplayerButton.Location = new System.Drawing.Point(794, 417);
            this.multiplayerButton.Name = "multiplayerButton";
            this.multiplayerButton.Size = new System.Drawing.Size(143, 66);
            this.multiplayerButton.TabIndex = 3;
            this.multiplayerButton.Text = "Multiplayer";
            this.multiplayerButton.UseVisualStyleBackColor = true;
            this.multiplayerButton.Click += new System.EventHandler(this.multiplayerButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.Color.Maroon;
            this.exitButton.Location = new System.Drawing.Point(617, 507);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(143, 66);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.multiplayerButton);
            this.Controls.Add(this.singlePlayerButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bottomBlackLabel);
            this.Controls.Add(this.topBlackLabel);
            this.Name = "HomeScreen";
            this.Size = new System.Drawing.Size(1350, 900);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topBlackLabel;
        private System.Windows.Forms.Label bottomBlackLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button singlePlayerButton;
        private System.Windows.Forms.Button multiplayerButton;
        private System.Windows.Forms.Button exitButton;
    }
}
