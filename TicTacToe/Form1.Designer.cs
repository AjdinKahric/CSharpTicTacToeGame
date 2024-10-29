namespace WinFormsApp1 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            restartGameToolStripMenuItem = new ToolStripMenuItem();
            gameToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            OneMore = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 45F);
            button1.Location = new Point(105, 160);
            button1.Name = "button1";
            button1.Size = new Size(90, 90);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += Btn1;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 45F);
            button2.Location = new Point(192, 160);
            button2.Name = "button2";
            button2.Size = new Size(90, 90);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += Btn2;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 45F);
            button3.Location = new Point(276, 160);
            button3.Name = "button3";
            button3.Size = new Size(90, 90);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += Btn3;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 45F);
            button4.Location = new Point(105, 247);
            button4.Name = "button4";
            button4.Size = new Size(90, 90);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += Btn4;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 45F);
            button5.Location = new Point(192, 247);
            button5.Name = "button5";
            button5.Size = new Size(90, 90);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += Btn5;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 45F);
            button6.Location = new Point(276, 247);
            button6.Name = "button6";
            button6.Size = new Size(90, 90);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += Btn6;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 45F);
            button7.Location = new Point(105, 333);
            button7.Name = "button7";
            button7.Size = new Size(90, 90);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            button7.Click += Btn7;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 45F);
            button8.Location = new Point(192, 333);
            button8.Name = "button8";
            button8.Size = new Size(90, 90);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += Btn8;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 45F);
            button9.Location = new Point(276, 333);
            button9.Name = "button9";
            button9.Size = new Size(90, 90);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = true;
            button9.Click += Btn9;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(484, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { restartGameToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // restartGameToolStripMenuItem
            // 
            restartGameToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gameToolStripMenuItem });
            restartGameToolStripMenuItem.Name = "restartGameToolStripMenuItem";
            restartGameToolStripMenuItem.Size = new Size(98, 22);
            restartGameToolStripMenuItem.Text = "New";
            restartGameToolStripMenuItem.Click += FileThenNew;
            // 
            // gameToolStripMenuItem
            // 
            gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            gameToolStripMenuItem.Size = new Size(111, 22);
            gameToolStripMenuItem.Text = "Game..";
            gameToolStripMenuItem.Click += NewThenGame;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 79);
            label1.Name = "label1";
            label1.Size = new Size(93, 32);
            label1.TabIndex = 11;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(331, 79);
            label2.Name = "label2";
            label2.Size = new Size(93, 32);
            label2.TabIndex = 12;
            label2.Text = "label2";
            // 
            // OneMore
            // 
            OneMore.Font = new Font("Bell MT", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OneMore.Location = new Point(145, 457);
            OneMore.Name = "OneMore";
            OneMore.Size = new Size(171, 60);
            OneMore.TabIndex = 13;
            OneMore.Text = "One More";
            OneMore.UseVisualStyleBackColor = true;
            OneMore.Click += OneMoreGame;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(484, 561);
            Controls.Add(OneMore);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "XO";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem restartGameToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem gameToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Button OneMore;
    }
}
