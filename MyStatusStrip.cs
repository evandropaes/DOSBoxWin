using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DosBlaster
{
    public partial class MyStatusStrip : StatusStrip
    {
        public MyStatusStrip()
        {
            InitializeComponent();
            BuildControl();
        }

        public void BuildControl()
        {
            ToolStripStatusLabel label = (ToolStripStatusLabel)Items.Add("");
            label.Spring = true;
            label.TextAlign = ContentAlignment.MiddleLeft;
            label = (ToolStripStatusLabel)Items.Add("");
            label.Width = 150;
            label.AutoSize = false;
            label = (ToolStripStatusLabel)Items.Add("");
            label.Width = 150;
            label.AutoSize = false;
            label = (ToolStripStatusLabel)Items.Add("");
            label.Width = 50;
            label.AutoSize = false;
        }

        public void SetGame(Game game)
        {
            if (game != null)
            {
                if (!string.IsNullOrEmpty(game.Publisher) && !string.IsNullOrEmpty(game.Year))
                {
                    Items[0].Text = game.Name + " - " + game.Publisher + " " +  "(" + game.Year + ")";
                }
                else if (!string.IsNullOrEmpty(game.Publisher))
                {
                    Items[0].Text = game.Name + "(" + game.Publisher + ")";
                }
                else if (!string.IsNullOrEmpty(game.Year))
                {
                    Items[0].Text = game.Name + "(" + game.Year + ")";
                }
                else
                {
                    Items[0].Text = game.Name;
                }
                
                Items[1].Text = "Play Count: " + game.PlayCount.ToString();
                if (game.PlayCount == 0)
                {
                    Items[2].Text = "Avg. Play Time: N/A";
                }
                else
                {
                    Items[2].Text = "Avg. Play Time: " + GetTimeString(game.PlayTime / game.PlayCount);
                } 
            }
            else
            {
                Items[0].Text = "";
                Items[1].Text = "";
                Items[2].Text = "";
            }
        }

        private string GetTimeString(int secs)
        {
            if (secs < 60)
            {
                return secs.ToString() + " secs";
            }
            else if (secs < 60 * 60)
            {
                return (secs / 60).ToString() + " mins";
            }
            else 
            {
                return Math.Round(secs / 60.0 / 60, 1).ToString() + " hrs";
            }
        }
    }
}
