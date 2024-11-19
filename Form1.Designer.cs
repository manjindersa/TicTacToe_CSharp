namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            player1SymbolTextBox = new TextBox();
            label1 = new Label();
            player1NameTextBox = new TextBox();
            player2NameTextBox = new TextBox();
            player2SymbolTextBox = new TextBox();
            groupBox3 = new GroupBox();
            winnerLabel = new Label();
            statsListBox = new ListView();
            label6 = new Label();
            StartButton = new Button();
            ContinueButton = new Button();
            ResetButton = new Button();
            label5 = new Label();
            groupBox2 = new GroupBox();
            nextTurnLabel = new Label();
            gamePanel = new Panel();
            button00 = new Button();
            button01 = new Button();
            button02 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button20 = new Button();
            button21 = new Button();
            button22 = new Button();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            gamePanel.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(player1SymbolTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(player1NameTextBox);
            groupBox1.Controls.Add(player2NameTextBox);
            groupBox1.Controls.Add(player2SymbolTextBox);
            groupBox1.Location = new Point(12, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(791, 139);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Game Setup";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(489, 95);
            label4.Name = "label4";
            label4.Size = new Size(118, 20);
            label4.TabIndex = 8;
            label4.Text = "Player 1 Symbol:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(489, 47);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 7;
            label3.Text = "Player 1 Symbol:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 95);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 6;
            label2.Text = "Player 2 Name:";
            // 
            // player1SymbolTextBox
            // 
            player1SymbolTextBox.Location = new Point(618, 44);
            player1SymbolTextBox.Name = "player1SymbolTextBox";
            player1SymbolTextBox.Size = new Size(79, 27);
            player1SymbolTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 51);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 5;
            label1.Text = "Playe 1 Name:";
            // 
            // player1NameTextBox
            // 
            player1NameTextBox.Location = new Point(160, 48);
            player1NameTextBox.Name = "player1NameTextBox";
            player1NameTextBox.Size = new Size(219, 27);
            player1NameTextBox.TabIndex = 1;
            // 
            // player2NameTextBox
            // 
            player2NameTextBox.Location = new Point(160, 92);
            player2NameTextBox.Name = "player2NameTextBox";
            player2NameTextBox.Size = new Size(219, 27);
            player2NameTextBox.TabIndex = 2;
            // 
            // player2SymbolTextBox
            // 
            player2SymbolTextBox.Location = new Point(618, 92);
            player2SymbolTextBox.Name = "player2SymbolTextBox";
            player2SymbolTextBox.Size = new Size(79, 27);
            player2SymbolTextBox.TabIndex = 4;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(winnerLabel);
            groupBox3.Controls.Add(statsListBox);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(534, 192);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(269, 434);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Game Stats";
            // 
            // winnerLabel
            // 
            winnerLabel.BorderStyle = BorderStyle.FixedSingle;
            winnerLabel.Font = new Font("Segoe UI", 12F);
            winnerLabel.Location = new Point(108, 391);
            winnerLabel.Name = "winnerLabel";
            winnerLabel.Size = new Size(149, 29);
            winnerLabel.TabIndex = 6;
            // 
            // statsListBox
            // 
            statsListBox.Location = new Point(23, 48);
            statsListBox.Name = "statsListBox";
            statsListBox.Size = new Size(226, 306);
            statsListBox.TabIndex = 7;
            statsListBox.UseCompatibleStateImageBehavior = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(23, 392);
            label6.Name = "label6";
            label6.Size = new Size(79, 28);
            label6.TabIndex = 5;
            label6.Text = "Winner:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // StartButton
            // 
            StartButton.Location = new Point(399, 55);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(94, 29);
            StartButton.TabIndex = 0;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // ContinueButton
            // 
            ContinueButton.Location = new Point(399, 110);
            ContinueButton.Name = "ContinueButton";
            ContinueButton.Size = new Size(94, 29);
            ContinueButton.TabIndex = 1;
            ContinueButton.Text = "Continue";
            ContinueButton.UseVisualStyleBackColor = true;
            ContinueButton.Click += ContinueButton_Click;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(399, 161);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(94, 29);
            ResetButton.TabIndex = 2;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(81, 392);
            label5.Name = "label5";
            label5.Size = new Size(101, 28);
            label5.TabIndex = 3;
            label5.Text = "Next Turn:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(nextTurnLabel);
            groupBox2.Controls.Add(gamePanel);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(ResetButton);
            groupBox2.Controls.Add(StartButton);
            groupBox2.Controls.Add(ContinueButton);
            groupBox2.Location = new Point(12, 192);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(499, 434);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Game Area";
            // 
            // nextTurnLabel
            // 
            nextTurnLabel.BorderStyle = BorderStyle.FixedSingle;
            nextTurnLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nextTurnLabel.Location = new Point(188, 391);
            nextTurnLabel.Name = "nextTurnLabel";
            nextTurnLabel.Size = new Size(149, 30);
            nextTurnLabel.TabIndex = 6;
            nextTurnLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // gamePanel
            // 
            gamePanel.Controls.Add(button00);
            gamePanel.Controls.Add(button01);
            gamePanel.Controls.Add(button02);
            gamePanel.Controls.Add(button10);
            gamePanel.Controls.Add(button11);
            gamePanel.Controls.Add(button12);
            gamePanel.Controls.Add(button20);
            gamePanel.Controls.Add(button21);
            gamePanel.Controls.Add(button22);
            gamePanel.Location = new Point(6, 46);
            gamePanel.Name = "gamePanel";
            gamePanel.Size = new Size(373, 325);
            gamePanel.TabIndex = 5;
            // 
            // button00
            // 
            button00.Font = new Font("Segoe UI", 25F);
            button00.Location = new Point(30, 9);
            button00.Name = "button00";
            button00.Size = new Size(100, 100);
            button00.TabIndex = 12;
            button00.Tag = "0,0";
            button00.UseVisualStyleBackColor = true;
            // 
            // button01
            // 
            button01.Font = new Font("Segoe UI", 25F);
            button01.Location = new Point(136, 9);
            button01.Name = "button01";
            button01.Size = new Size(100, 100);
            button01.TabIndex = 13;
            button01.Tag = "0,1";
            button01.UseVisualStyleBackColor = true;
            // 
            // button02
            // 
            button02.Font = new Font("Segoe UI", 25F);
            button02.Location = new Point(242, 9);
            button02.Name = "button02";
            button02.Size = new Size(100, 100);
            button02.TabIndex = 14;
            button02.Tag = "0,2";
            button02.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 25F);
            button10.Location = new Point(30, 112);
            button10.Name = "button10";
            button10.Size = new Size(100, 100);
            button10.TabIndex = 15;
            button10.Tag = "1,0";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 25F);
            button11.Location = new Point(136, 112);
            button11.Name = "button11";
            button11.Size = new Size(100, 100);
            button11.TabIndex = 16;
            button11.Tag = "1,1";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 25F);
            button12.Location = new Point(242, 112);
            button12.Name = "button12";
            button12.Size = new Size(100, 100);
            button12.TabIndex = 17;
            button12.Tag = "1,2";
            button12.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            button20.Font = new Font("Segoe UI", 25F);
            button20.Location = new Point(30, 215);
            button20.Name = "button20";
            button20.Size = new Size(100, 100);
            button20.TabIndex = 18;
            button20.Tag = "2,0";
            button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            button21.Font = new Font("Segoe UI", 25F);
            button21.Location = new Point(136, 215);
            button21.Name = "button21";
            button21.Size = new Size(100, 100);
            button21.TabIndex = 19;
            button21.Tag = "2,1";
            button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            button22.Font = new Font("Segoe UI", 25F);
            button22.Location = new Point(242, 215);
            button22.Name = "button22";
            button22.Size = new Size(100, 100);
            button22.TabIndex = 20;
            button22.Tag = "2,2";
            button22.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AcceptButton = ResetButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(815, 645);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tic-Tac-Toe ";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            gamePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox player1SymbolTextBox;
        private Label label1;
        private TextBox player1NameTextBox;
        private TextBox player2NameTextBox;
        private TextBox player2SymbolTextBox;
        private Button ResetButton;
        private Button ContinueButton;
        private Button StartButton;
        private GroupBox groupBox3;
        private Label label5;
        private Label label6;
        private GroupBox groupBox2;
        private ListView statsListBox;
        private Panel gamePanel;
        private Button button00;
        private Button button01;
        private Button button02;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button20;
        private Button button21;
        private Button button22;
        private Label winnerLabel;
        private Label nextTurnLabel;
    }
}
