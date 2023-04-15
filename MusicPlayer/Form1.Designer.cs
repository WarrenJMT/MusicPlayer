namespace MusicPlayer
{
    partial class MusicPlayer
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
            components = new System.ComponentModel.Container();
            SongArt = new PictureBox();
            SongLength = new ProgressBar();
            PreviousButton = new Button();
            PlayPauseButton = new Button();
            NextButton = new Button();
            SongText = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)SongArt).BeginInit();
            SuspendLayout();
            // 
            // SongArt
            // 
            SongArt.Location = new Point(50, 51);
            SongArt.Name = "SongArt";
            SongArt.Size = new Size(225, 226);
            SongArt.TabIndex = 0;
            SongArt.TabStop = false;
            SongArt.Click += SongArt_Click;
            // 
            // SongLength
            // 
            SongLength.BackColor = SystemColors.ActiveCaptionText;
            SongLength.ForeColor = SystemColors.HotTrack;
            SongLength.Location = new Point(50, 283);
            SongLength.Name = "SongLength";
            SongLength.Size = new Size(225, 15);
            SongLength.Style = ProgressBarStyle.Continuous;
            SongLength.TabIndex = 1;
            SongLength.Click += SongLength_Click;
            // 
            // PreviousButton
            // 
            PreviousButton.Location = new Point(50, 304);
            PreviousButton.Name = "PreviousButton";
            PreviousButton.Size = new Size(63, 59);
            PreviousButton.TabIndex = 2;
            PreviousButton.Text = "◀◀";
            PreviousButton.UseVisualStyleBackColor = true;
            PreviousButton.Click += PreviousButton_Click;
            // 
            // PlayPauseButton
            // 
            PlayPauseButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            PlayPauseButton.Location = new Point(130, 304);
            PlayPauseButton.Name = "PlayPauseButton";
            PlayPauseButton.Size = new Size(63, 59);
            PlayPauseButton.TabIndex = 3;
            PlayPauseButton.Text = "▶️/II";
            PlayPauseButton.UseVisualStyleBackColor = true;
            PlayPauseButton.Click += PlayPauseButton_Click;
            // 
            // NextButton
            // 
            NextButton.Location = new Point(212, 304);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(63, 59);
            NextButton.TabIndex = 4;
            NextButton.Text = "▶▶";
            NextButton.UseVisualStyleBackColor = true;
            NextButton.Click += NextButton_Click;
            // 
            // SongText
            // 
            SongText.Location = new Point(50, 22);
            SongText.Name = "SongText";
            SongText.Size = new Size(225, 23);
            SongText.TabIndex = 5;
            SongText.TextChanged += SongText_TextChanged;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // MusicPlayer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 414);
            Controls.Add(SongText);
            Controls.Add(NextButton);
            Controls.Add(PlayPauseButton);
            Controls.Add(PreviousButton);
            Controls.Add(SongLength);
            Controls.Add(SongArt);
            Name = "MusicPlayer";
            Text = "MusicPlayer";
            ((System.ComponentModel.ISupportInitialize)SongArt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private PictureBox SongArt;
        private ProgressBar SongLength;
        private Button PreviousButton;
        private Button PlayPauseButton;
        private Button NextButton;
        private TextBox SongText;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
    }
}