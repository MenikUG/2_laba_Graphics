
namespace _2_laba_Graphics
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel_drawing = new System.Windows.Forms.Panel();
            this.trackBar_Pitch = new System.Windows.Forms.TrackBar();
            this.trackBar_Yaw = new System.Windows.Forms.TrackBar();
            this.trackBar_Roll = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.Example1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Example2 = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBar_RollOffSet = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBar_YawOffSet = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBar_PitchOffset = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Pitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Yaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Roll)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_RollOffSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_YawOffSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_PitchOffset)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_drawing
            // 
            this.panel_drawing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_drawing.BackColor = System.Drawing.SystemColors.Info;
            this.panel_drawing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_drawing.Location = new System.Drawing.Point(12, 41);
            this.panel_drawing.Name = "panel_drawing";
            this.panel_drawing.Size = new System.Drawing.Size(775, 630);
            this.panel_drawing.TabIndex = 2;
            this.panel_drawing.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_drawing_Paint);
            // 
            // trackBar_Pitch
            // 
            this.trackBar_Pitch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_Pitch.Location = new System.Drawing.Point(835, 41);
            this.trackBar_Pitch.Maximum = 369;
            this.trackBar_Pitch.Name = "trackBar_Pitch";
            this.trackBar_Pitch.Size = new System.Drawing.Size(347, 56);
            this.trackBar_Pitch.TabIndex = 3;
            this.trackBar_Pitch.Scroll += new System.EventHandler(this.trackBar_Pitch_Scroll);
            // 
            // trackBar_Yaw
            // 
            this.trackBar_Yaw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_Yaw.Location = new System.Drawing.Point(835, 103);
            this.trackBar_Yaw.Maximum = 369;
            this.trackBar_Yaw.Name = "trackBar_Yaw";
            this.trackBar_Yaw.Size = new System.Drawing.Size(347, 56);
            this.trackBar_Yaw.TabIndex = 5;
            this.trackBar_Yaw.Scroll += new System.EventHandler(this.trackBar_Yaw_Scroll);
            // 
            // trackBar_Roll
            // 
            this.trackBar_Roll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_Roll.Location = new System.Drawing.Point(835, 165);
            this.trackBar_Roll.Maximum = 369;
            this.trackBar_Roll.Name = "trackBar_Roll";
            this.trackBar_Roll.Size = new System.Drawing.Size(347, 56);
            this.trackBar_Roll.TabIndex = 7;
            this.trackBar_Roll.Scroll += new System.EventHandler(this.trackBar_Roll_Scroll);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(793, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Повороты";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(793, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Z:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(793, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(793, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "X:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1194, 35);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Example1,
            this.Example2});
            this.toolStripSplitButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(208, 32);
            this.toolStripSplitButton1.Text = "Функциональность";
            // 
            // Example1
            // 
            this.Example1.Name = "Example1";
            this.Example1.Size = new System.Drawing.Size(767, 32);
            this.Example1.Text = "Вращение относительно трёх осей";
            this.Example1.Click += new System.EventHandler(this.Example1_Click);
            // 
            // Example2
            // 
            this.Example2.Name = "Example2";
            this.Example2.Size = new System.Drawing.Size(767, 32);
            this.Example2.Text = "Поворот вокруг координатных осей относительно произвольной точки";
            this.Example2.Click += new System.EventHandler(this.Example2_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(793, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 31);
            this.label5.TabIndex = 17;
            this.label5.Text = "Z1:";
            // 
            // trackBar_RollOffSet
            // 
            this.trackBar_RollOffSet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_RollOffSet.Location = new System.Drawing.Point(835, 351);
            this.trackBar_RollOffSet.Maximum = 369;
            this.trackBar_RollOffSet.Name = "trackBar_RollOffSet";
            this.trackBar_RollOffSet.Size = new System.Drawing.Size(347, 56);
            this.trackBar_RollOffSet.TabIndex = 16;
            this.trackBar_RollOffSet.Scroll += new System.EventHandler(this.trackBar_RollOffSet_Scroll);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(793, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 31);
            this.label6.TabIndex = 15;
            this.label6.Text = "Y1:";
            // 
            // trackBar_YawOffSet
            // 
            this.trackBar_YawOffSet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_YawOffSet.Location = new System.Drawing.Point(835, 289);
            this.trackBar_YawOffSet.Maximum = 369;
            this.trackBar_YawOffSet.Name = "trackBar_YawOffSet";
            this.trackBar_YawOffSet.Size = new System.Drawing.Size(347, 56);
            this.trackBar_YawOffSet.TabIndex = 14;
            this.trackBar_YawOffSet.Scroll += new System.EventHandler(this.trackBar_YawOffSet_Scroll);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(793, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 31);
            this.label7.TabIndex = 13;
            this.label7.Text = "X1:";
            // 
            // trackBar_PitchOffset
            // 
            this.trackBar_PitchOffset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_PitchOffset.Location = new System.Drawing.Point(835, 227);
            this.trackBar_PitchOffset.Maximum = 369;
            this.trackBar_PitchOffset.Name = "trackBar_PitchOffset";
            this.trackBar_PitchOffset.Size = new System.Drawing.Size(347, 56);
            this.trackBar_PitchOffset.TabIndex = 12;
            this.trackBar_PitchOffset.Scroll += new System.EventHandler(this.trackBar_PitchOffset_Scroll);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 683);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBar_RollOffSet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trackBar_YawOffSet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.trackBar_PitchOffset);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar_Roll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar_Yaw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar_Pitch);
            this.Controls.Add(this.panel_drawing);
            this.Name = "MainForm";
            this.Text = "Лабораторная работа №2";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Pitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Yaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Roll)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_RollOffSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_YawOffSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_PitchOffset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_drawing;
        private System.Windows.Forms.TrackBar trackBar_Pitch;
        private System.Windows.Forms.TrackBar trackBar_Yaw;
        private System.Windows.Forms.TrackBar trackBar_Roll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem Example1;
        private System.Windows.Forms.ToolStripMenuItem Example2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBar_RollOffSet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBar_YawOffSet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBar_PitchOffset;
    }
}

