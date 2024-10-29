namespace WinFormsApp1 {
    public partial class Form1 : Form {
        private int counter = 0;
        private string _player1;
        private int _player1WinCount;
        private string _player2;
        private int _player2WinCount;
        public Form1(string player1, string player2) {
            InitializeComponent();
            _player1 = player1;
            _player2 = player2;
            _player1WinCount = 0;
            _player2WinCount = 0;
        }
        private void SwitchPlayer(object sender) {
            Button? button = sender as Button;

            if (button != null) {
                int clickedButtonY = button.Location.Y;
                int clickedButtonX = button.Location.X;
                if (button.Text == "") {
                    if (counter % 2 == 0) 
                        button.Text = "X";
                     else 
                        button.Text = "O";
                    
                    if (CheckRow(clickedButtonY) || CheckCol(clickedButtonX) || CheckDiagonal()) {
                        foreach (Control control in this.Controls) {
                            if (control is Button) {
                                Button? disableButton = control as Button;
                                if (disableButton.Text == "")
                                    disableButton.Enabled = false;
                            }
                        }
                        if (counter % 2 == 0) {
                            //igrac1 pobjedio
                            label1.Text = _player1 + $" {++_player1WinCount}";
                        } else {
                            //igrac2 pobjedio
                            label2.Text = $" {++_player2WinCount} " + _player2;
                        }
                    }
                    counter++;
                }
            }
        }
        private bool CheckRow(int y) {
            Button[] winningBtns = new Button[3];

            int count = 0;
            foreach (Control control in this.Controls) {
                if (control is Button && control.Location.Y == y) {
                    Button? button = control as Button;
                    winningBtns[count] = button;
                    count++;
                }
            }

            string firstBtnMark = winningBtns[0].Text;
            foreach (Button button in winningBtns) {
                if (firstBtnMark != button.Text)
                    return false;
            }

            foreach (Button button in winningBtns) {
                Font boldFont = new Font(button.Font, FontStyle.Bold);
                button.Font = boldFont;
                button.ForeColor = Color.Green;
            }
            return true;
        }
        private bool CheckCol(int x) {
            Button[] winningBtns = new Button[3];

            int count = 0;
            foreach (Control control in this.Controls) {
                if (control is Button && control.Location.X == x) {
                    Button? button = control as Button;
                    winningBtns[count] = button;
                    count++;
                }
            }

            string firstBtnMark = winningBtns[0].Text;
            foreach (Button button in winningBtns) {
                if (firstBtnMark != button.Text)
                    return false;
            }

            foreach (Button button in winningBtns) {
                Font boldFont = new Font(button.Font, FontStyle.Bold);
                button.Font = boldFont;
                button.ForeColor = Color.Green;
            }

            return true;
        }
        private bool CheckDiagonal() {
            Button[] winningBtns = new Button[5];
            bool isWinning = true;

            int count = 0;
            foreach (Control control in this.Controls) { // passing through all controls in the form
                if (control is Button) { // getting only buttons
                   if(control.Text != "One More") { // exclude button named "One More"
                        string buttonName = ((Button)control).Name;
                        Button button = control as Button; // convert control
                        if ((int)char.GetNumericValue(buttonName.Last()) % 2 != 0) { // basically saying get me all buttons on both diagonals
                            winningBtns[count] = button; // storing all buttons on both diagonals - 1, 3, 5, 7 and 9
                            count++;
                        }

                    }
                }
            }

            if (winningBtns[2].Text == "")
                return false;

            string mainDiagonal = winningBtns[0].Text;
            for (int i = 0; i < winningBtns.Length; i += 2) {
                if (mainDiagonal != winningBtns[i].Text) {
                    isWinning = false;
                    break;
                }
            }

            if (isWinning) {
                for (int i = 0; i < winningBtns.Length; i += 2) {
                    Font boldFont = new Font(winningBtns[i].Font, FontStyle.Bold);
                    winningBtns[i].Font = boldFont;
                    winningBtns[i].ForeColor = Color.Green;
                }
                return isWinning;
            }

            isWinning = !isWinning;

            string secondaryDiagonal = winningBtns[1].Text;
            for (int i = 1; i < 4; i++) {
                if (secondaryDiagonal != winningBtns[i].Text) {
                    isWinning = false;
                    break;
                }
            }

            if (isWinning) {
                for (int i = 1; i < 4; i++) {
                    Font boldFont = new Font(winningBtns[i].Font, FontStyle.Bold);
                    winningBtns[i].Font = boldFont;
                    winningBtns[i].ForeColor = Color.Green;
                }
            }

            return isWinning;
        }
        private void NewThenGame(object sender, EventArgs e) {
            this.Hide();
            EntryForm entryForm = new EntryForm();
            entryForm.ShowDialog();
            entryForm.FormClosed += EntryForm_FormClosed;
            this.Dispose();
       
        }     
        private void EntryForm_FormClosed(object sender, FormClosedEventArgs e) {
            this.Close();
        }
        private void Form1_Load(object sender, EventArgs e) {
            label1.Text = _player1 + " 0";
            label2.Text = "0 " + _player2;
        }

        private void Btn1(object sender, EventArgs e) {
            SwitchPlayer(sender);
        }
        private void Btn2(object sender, EventArgs e) {
            SwitchPlayer(sender);
        }
        private void Btn3(object sender, EventArgs e) {
            SwitchPlayer(sender);
        }
        private void Btn4(object sender, EventArgs e) {
            SwitchPlayer(sender);
        }
        private void Btn5(object sender, EventArgs e) {
            SwitchPlayer(sender);
        }
        private void Btn6(object sender, EventArgs e) {
            SwitchPlayer(sender);
        }
        private void Btn7(object sender, EventArgs e) {
            SwitchPlayer(sender);
        }
        private void Btn8(object sender, EventArgs e) {
            SwitchPlayer(sender);
        }
        private void Btn9(object sender, EventArgs e) {
            SwitchPlayer(sender);
        }
        private void fileToolStripMenuItem_Click(object sender, EventArgs e) {

        }
        private void FileThenNew(object sender, EventArgs e) {
              
        }
        private void OneMoreGame(object sender, EventArgs e) {
            counter = 0;
            foreach (Control control in this.Controls) {
                if (control is Button) {
                    Button? button = (Button?)control;
                    if(button.Text != "One More") {
                        Font boldFont = new Font(button.Font, FontStyle.Regular);
                        button.Font = boldFont;
                        button.ForeColor = Color.Black;
                        button.Text = "";
                        button.Enabled = true;
                    }
                }
            }
        }

//         foreach (Control control in this.Controls) {
//                if (control is Button) {
//                    Button? button = control as Button;
//        Font boldFont = new Font(button.Font, FontStyle.Regular);
//        button.Font = boldFont;
//                    button.ForeColor = Color.Black;
//                    button.Text = "";
//                    label1.Text = "label1";
//                    button.Enabled = true;
//                }
//}

    }
}

//private bool CheckDiagonal() {
//    string mainDiagonal = button1.Text;
//    if (mainDiagonal == button5.Text && mainDiagonal == button9.Text && mainDiagonal != "") {
//        return true; 
//    }
//    string secondaryDiagonal = button3.Text;
//    if (secondaryDiagonal == button5.Text && secondaryDiagonal == button7.Text && secondaryDiagonal != "") {
//        return true; 
//    }
//    return false; 
//}
