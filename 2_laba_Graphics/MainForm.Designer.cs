
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
            this.panel_drawing = new System.Windows.Forms.Panel();
            this.trackBar_Pitch = new System.Windows.Forms.TrackBar();
            this.trackBar_Yaw = new System.Windows.Forms.TrackBar();
            this.trackBar_Roll = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Pitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Yaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Roll)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_drawing
            // 
            this.panel_drawing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_drawing.BackColor = System.Drawing.SystemColors.Info;
            this.panel_drawing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_drawing.Location = new System.Drawing.Point(12, 12);
            this.panel_drawing.Name = "panel_drawing";
            this.panel_drawing.Size = new System.Drawing.Size(775, 659);
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
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(798, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 79);
            this.button1.TabIndex = 10;
            this.button1.Text = "Вращение относительно трёх осей";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 683);
            this.Controls.Add(this.button1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_drawing;
        private System.Windows.Forms.TrackBar trackBar_Pitch;
        private System.Windows.Forms.TrackBar trackBar_Yaw;
        private System.Windows.Forms.TrackBar trackBar_Roll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

