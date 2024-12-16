﻿using GameLibrary.Game;
using System;
using System.Windows.Forms;

namespace Duck_Hunt
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void startSingleplayerGameBtn_Click(object sender, EventArgs e)
        {
            Gamemodes.Singleplayer = true;
            Gamemodes.Multiplayer = false;
            Hide();
            var game = new GameForm();
            game.ShowDialog();
            Show();
        }
      

    

        private void startMultiplayerGameBtn_Click(object sender, EventArgs e)
        {
            Gamemodes.Singleplayer = false;
            Gamemodes.Multiplayer = true;
            Hide();
            var game = new GameForm();
            game.ShowDialog();
            Show();
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo))
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;
                case DialogResult.No:
                    return;
            }
        }
    }
}

