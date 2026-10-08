using LifeEventGame.Helpers;
using LifeEventGame.StandardObjects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LifeEventGame.UI
{
    public class GameForm : Form
    {
        private readonly Button[] _optionButtons = new Button[3];
        private readonly LiveEventGeneration _engine;
        private readonly Label _descriptionLabel;
        private readonly Button _refreshButton;
        private readonly PlayerAttributes _playerAttributes = new PlayerAttributes();

        public GameForm()
        {
            Text = "Life Event Game";
            Size = new Size(400, 250);
            StartPosition = FormStartPosition.CenterScreen;
            _engine = new LiveEventGeneration();

            // Create buttons
            for (int i = 0; i < 3; i++)
            {
                var btn = new Button
                {
                    Size = new Size(320, 30),
                    Location = new Point(30, 20 + i * 40),
                    Tag = i
                };
                btn.Click += OptionButton_Click;
                _optionButtons[i] = btn;
                Controls.Add(btn);
            }

            _descriptionLabel = new Label
            {
                Text = "Select an option",
                Location = new Point(30, 140),
                Size = new Size(320, 40)
            };
            Controls.Add(_descriptionLabel);
            Load += GameForm_Load;
        }

        private void GameForm_Load(object? sender, EventArgs e)
        {
            RefreshOptions();
        }

        private List<LifeEvent> _currentOptions = new();

        private void RefreshOptions()
        {
            _currentOptions = _engine.GetRandomEvents(3, _playerAttributes);
            for (int i = 0; i < 3; i++)
            {
                if (i < _currentOptions.Count)
                {
                    _optionButtons[i].Text = _currentOptions[i].Title;
                    _optionButtons[i].Enabled = true;
                }
                else
                {
                    _optionButtons[i].Text = "(none)";
                    _optionButtons[i].Enabled = false;
                }
            }
            _descriptionLabel.Text = "Select an option";
        }

        private void OptionButton_Click(object? sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is int idx && idx < _currentOptions.Count)
            {
                var ev = _currentOptions[idx];
                MessageBox.Show(ev.Description, ev.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                _descriptionLabel.Text = $"Last choice: {ev.Title}";

                // After choosing, update player attributes and get new options
                ev.UpdatePlayerAttributes(_playerAttributes);
                RefreshOptions();
            }
        }
    }
}
