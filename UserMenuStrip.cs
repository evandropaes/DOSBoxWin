using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DosBlaster
{
    public partial class UserMenuStrip : MenuStrip
    {
        public UserMenuStrip()
        {
            InitializeComponent();
            BuildControl();
        }

        private void BuildControl()
        {
            ToolStripMenuItem topMenu = (ToolStripMenuItem)Items.Add("File");
            topMenu.DropDownItems.Add("Import Game &Zip", null, Mediator.ImportGameZip);
            topMenu.DropDownItems.Add("Import Game &Folder", null, Mediator.ImportGameFolder);
            topMenu.DropDownItems.Add("Import DOS32A Zip", null, Mediator.ImportDOS32AZip);
            topMenu.DropDownItems.Add("-", null, null);
            topMenu.DropDownItems.Add("Configure", null, Mediator.ShowConfigurationsDialog);
            topMenu.DropDownItems.Add("-", null, null);
            topMenu.DropDownItems.Add("E&xit", null, Mediator.Exit);

            topMenu = (ToolStripMenuItem)Items.Add("Game");
            topMenu.DropDownItems.Add("Run Game", null, Mediator.RunGame);
            topMenu.DropDownItems.Add("Delete", null, Mediator.DeleteGame);
            topMenu.DropDownItems.Add("Properties", null, Mediator.ShowGameProperties);

            topMenu = (ToolStripMenuItem)Items.Add("Help");
            topMenu.DropDownItems.Add("Help", null, Mediator.ShowHelp);
            topMenu.DropDownItems.Add("-", null, null);
            topMenu.DropDownItems.Add("Visit DosBlaster Website", null, Mediator.ShowDosBlasterWebsite);
            topMenu.DropDownItems.Add("Visit DosBox Website", null, Mediator.ShowDosBoxWebsite);
            topMenu.DropDownItems.Add("-", null, null);
            topMenu.DropDownItems.Add("About DosBlaster", null, Mediator.ShowAboutDosBlaster);
        }
    }
}
