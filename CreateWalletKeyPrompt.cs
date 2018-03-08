﻿using System;
using System.Windows.Forms;

namespace TurtleWallet
{
    public partial class CreateWalletKeyPrompt : TurtleWalletForm
    {
        public CreateWalletKeyPrompt(string keyOutput)
        {
            InitializeComponent();
            KeysTextbox.Text = keyOutput;
            this.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
        }

        private void CreateWalletButton_Click(object sender, EventArgs e)
        {
            Utilities.Close(this);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Utilities.CloseProgram(e);
        }
    }
}
