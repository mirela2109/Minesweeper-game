using System.Windows.Forms;

namespace Minesweeper {
    partial class MainForm {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            this.SuspendLayout();

            // Init mainForm
            this.Location = baseInfo.Location;
            this.Icon = Properties.Resources.Mine;
            this.Text = "Minesweeper";
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = baseInfo.Location.IsEmpty ?
                FormStartPosition.CenterScreen :
                FormStartPosition.Manual;
            this.FormClosed += MainForm_FormClosed;
            
            // Init timer
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;   
            this.timer = timer;
            
            // Init topMenu
            MainMenu topMenu = new MainMenu();
            this.Menu = topMenu;
            
            MenuItem topMenuGame = new MenuItem();
            topMenuGame.Text = "&Game";
            topMenu.MenuItems.Add(topMenuGame);

            MenuItem topMenuGameNew = new MenuItem();
            topMenuGameNew.Text = "&New";
            topMenuGameNew.Shortcut = Shortcut.F2;
            topMenuGameNew.Click += TopMenuGameNew_Click;
            topMenuGame.MenuItems.Add(topMenuGameNew);

            MenuItem topMenuGameSeparator1 = new MenuItem();
            topMenuGameSeparator1.Text = "-";
            topMenuGame.MenuItems.Add(topMenuGameSeparator1);

            MenuItem topMenuGameBeginner = new MenuItem();
            topMenuGameBeginner.Text = "&Beginner";
            topMenuGameBeginner.Click += TopMenuGameBeginner_Click;
            topMenuGame.MenuItems.Add(topMenuGameBeginner);
            this.topMenuGameBeginner = topMenuGameBeginner;

            MenuItem topMenuGameIntermediate = new MenuItem();
            topMenuGameIntermediate.Text = "&Intermediate";
            topMenuGameIntermediate.Click += TopMenuGameIntermediate_Click;
            topMenuGame.MenuItems.Add(topMenuGameIntermediate);
            this.topMenuGameIntermediate = topMenuGameIntermediate;

            MenuItem topMenuGameExpert = new MenuItem();
            topMenuGameExpert.Text = "&Expert";
            topMenuGameExpert.Click += TopMenuGameExpert_Click;
            topMenuGame.MenuItems.Add(topMenuGameExpert);
            this.topMenuGameExpert = topMenuGameExpert;
            
       
            
            MenuItem topMenuGameSeparator2 = new MenuItem();
            topMenuGameSeparator2.Text = "-";
            topMenuGame.MenuItems.Add(topMenuGameSeparator2);

      

            MenuItem topMenuGameSeparator3 = new MenuItem();
            topMenuGameSeparator3.Text = "-";
            topMenuGame.MenuItems.Add(topMenuGameSeparator3);

        

            MenuItem topMenuGameSeparator4 = new MenuItem();
            topMenuGameSeparator4.Text = "-";
            topMenuGame.MenuItems.Add(topMenuGameSeparator4);

            MenuItem topMenuGameExit = new MenuItem();
            topMenuGameExit.Text = "E&xit";
            topMenuGameExit.Click += TopMenuGameExit_Click;
            topMenuGame.MenuItems.Add(topMenuGameExit);

            MenuItem topMenuHelp = new MenuItem();
            topMenuHelp.Text = "&Help";
            topMenu.MenuItems.Add(topMenuHelp);

  

            MenuItem topMenuHelpSeparator = new MenuItem();
            topMenuHelpSeparator.Text = "-";
            topMenuHelp.MenuItems.Add(topMenuHelpSeparator);

            MenuItem topMenuHelpAboutMinesweeper = new MenuItem();
            topMenuHelpAboutMinesweeper.Text = "&About Minesweeper...";
            topMenuHelpAboutMinesweeper.Click += TopMenuHelpAboutMinesweeper_Click;
            topMenuHelp.MenuItems.Add(topMenuHelpAboutMinesweeper);

            // Init gameBox
            PictureBox gameBox = new PictureBox();
            gameBox.MouseMove += GameBox_MouseMove;
            gameBox.MouseDown += GameBox_MouseDown;
            gameBox.MouseUp += GameBox_MouseUp;
            this.Controls.Add(gameBox);
            this.gameBox = gameBox;

            this.ResumeLayout(false);
        }

        private Timer timer;

        private MenuItem topMenuGameBeginner;
        private MenuItem topMenuGameIntermediate;
        private MenuItem topMenuGameExpert;
        private PictureBox gameBox;
    }
}

