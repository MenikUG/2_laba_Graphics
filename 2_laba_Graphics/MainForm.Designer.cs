
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.Example1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Example2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Example3 = new System.Windows.Forms.ToolStripMenuItem();
            this.Example4 = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBar_RollOffSet = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBar_YawOffSet = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBar_PitchOffset = new System.Windows.Forms.TrackBar();
            this.panel_XYZ = new System.Windows.Forms.Panel();
            this.panel_XYZ1 = new System.Windows.Forms.Panel();
            this.trackBar_angle_alpha = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_angle = new System.Windows.Forms.Panel();
            this.Example5 = new System.Windows.Forms.ToolStripMenuItem();
            this.Example6 = new System.Windows.Forms.ToolStripMenuItem();
            this.Example7 = new System.Windows.Forms.ToolStripMenuItem();
            this.Example8 = new System.Windows.Forms.ToolStripMenuItem();
            this.Example9 = new System.Windows.Forms.ToolStripMenuItem();
            this.Example10 = new System.Windows.Forms.ToolStripMenuItem();
            this.Example11 = new System.Windows.Forms.ToolStripMenuItem();
            this.Example12 = new System.Windows.Forms.ToolStripMenuItem();
            this.Example13 = new System.Windows.Forms.ToolStripMenuItem();
            this.Example14 = new System.Windows.Forms.ToolStripMenuItem();
            this.Example15 = new System.Windows.Forms.ToolStripMenuItem();
            this.Example16 = new System.Windows.Forms.ToolStripMenuItem();
            this.Example17 = new System.Windows.Forms.ToolStripMenuItem();
            this.Example18 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Pitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Yaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Roll)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_RollOffSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_YawOffSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_PitchOffset)).BeginInit();
            this.panel_XYZ.SuspendLayout();
            this.panel_XYZ1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_angle_alpha)).BeginInit();
            this.panel_angle.SuspendLayout();
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
            this.panel_drawing.Size = new System.Drawing.Size(788, 630);
            this.panel_drawing.TabIndex = 2;
            this.panel_drawing.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_drawing_Paint);
            // 
            // trackBar_Pitch
            // 
            this.trackBar_Pitch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_Pitch.Location = new System.Drawing.Point(45, 16);
            this.trackBar_Pitch.Maximum = 369;
            this.trackBar_Pitch.Minimum = 1;
            this.trackBar_Pitch.Name = "trackBar_Pitch";
            this.trackBar_Pitch.Size = new System.Drawing.Size(347, 56);
            this.trackBar_Pitch.TabIndex = 3;
            this.trackBar_Pitch.Value = 1;
            this.trackBar_Pitch.Scroll += new System.EventHandler(this.trackBar_Pitch_Scroll);
            // 
            // trackBar_Yaw
            // 
            this.trackBar_Yaw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_Yaw.Location = new System.Drawing.Point(45, 78);
            this.trackBar_Yaw.Maximum = 369;
            this.trackBar_Yaw.Minimum = 1;
            this.trackBar_Yaw.Name = "trackBar_Yaw";
            this.trackBar_Yaw.Size = new System.Drawing.Size(347, 56);
            this.trackBar_Yaw.TabIndex = 5;
            this.trackBar_Yaw.Value = 1;
            this.trackBar_Yaw.Scroll += new System.EventHandler(this.trackBar_Yaw_Scroll);
            // 
            // trackBar_Roll
            // 
            this.trackBar_Roll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_Roll.Location = new System.Drawing.Point(45, 140);
            this.trackBar_Roll.Maximum = 369;
            this.trackBar_Roll.Minimum = 1;
            this.trackBar_Roll.Name = "trackBar_Roll";
            this.trackBar_Roll.Size = new System.Drawing.Size(347, 56);
            this.trackBar_Roll.TabIndex = 7;
            this.trackBar_Roll.Value = 1;
            this.trackBar_Roll.Scroll += new System.EventHandler(this.trackBar_Roll_Scroll);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Z:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 28);
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
            this.toolStrip1.Size = new System.Drawing.Size(1230, 35);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Example1,
            this.Example2,
            this.Example3,
            this.Example4,
            this.Example5,
            this.Example6,
            this.Example7,
            this.Example8,
            this.Example9,
            this.Example10,
            this.Example11,
            this.Example12,
            this.Example13,
            this.Example14,
            this.Example15,
            this.Example16,
            this.Example17,
            this.Example18});
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
            this.Example1.Size = new System.Drawing.Size(1099, 32);
            this.Example1.Text = "Вращение относительно трёх осей";
            this.Example1.Click += new System.EventHandler(this.Example1_Click);
            // 
            // Example2
            // 
            this.Example2.Name = "Example2";
            this.Example2.Size = new System.Drawing.Size(1099, 32);
            this.Example2.Text = "Поворот вокруг координатных осей относительно произвольной точки";
            this.Example2.Click += new System.EventHandler(this.Example2_Click);
            // 
            // Example3
            // 
            this.Example3.Name = "Example3";
            this.Example3.Size = new System.Drawing.Size(1099, 32);
            this.Example3.Text = "Поворот вокруг оси, проходящей через начало координат";
            this.Example3.Click += new System.EventHandler(this.Example3_Click);
            // 
            // Example4
            // 
            this.Example4.Name = "Example4";
            this.Example4.Size = new System.Drawing.Size(1099, 32);
            this.Example4.Text = "Поворот вокруг произвольной оси, проходящей через начало координат на угол α";
            this.Example4.Click += new System.EventHandler(this.Example4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 34);
            this.label5.TabIndex = 17;
            this.label5.Text = "Z1:";
            // 
            // trackBar_RollOffSet
            // 
            this.trackBar_RollOffSet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_RollOffSet.Location = new System.Drawing.Point(45, 136);
            this.trackBar_RollOffSet.Maximum = 369;
            this.trackBar_RollOffSet.Minimum = 1;
            this.trackBar_RollOffSet.Name = "trackBar_RollOffSet";
            this.trackBar_RollOffSet.Size = new System.Drawing.Size(347, 56);
            this.trackBar_RollOffSet.TabIndex = 16;
            this.trackBar_RollOffSet.Value = 1;
            this.trackBar_RollOffSet.Scroll += new System.EventHandler(this.trackBar_RollOffSet_Scroll);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 34);
            this.label6.TabIndex = 15;
            this.label6.Text = "Y1:";
            // 
            // trackBar_YawOffSet
            // 
            this.trackBar_YawOffSet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_YawOffSet.Location = new System.Drawing.Point(45, 74);
            this.trackBar_YawOffSet.Maximum = 369;
            this.trackBar_YawOffSet.Minimum = 1;
            this.trackBar_YawOffSet.Name = "trackBar_YawOffSet";
            this.trackBar_YawOffSet.Size = new System.Drawing.Size(347, 56);
            this.trackBar_YawOffSet.TabIndex = 14;
            this.trackBar_YawOffSet.Value = 1;
            this.trackBar_YawOffSet.Scroll += new System.EventHandler(this.trackBar_YawOffSet_Scroll);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 35);
            this.label7.TabIndex = 13;
            this.label7.Text = "X1:";
            // 
            // trackBar_PitchOffset
            // 
            this.trackBar_PitchOffset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_PitchOffset.Location = new System.Drawing.Point(45, 12);
            this.trackBar_PitchOffset.Maximum = 369;
            this.trackBar_PitchOffset.Minimum = 1;
            this.trackBar_PitchOffset.Name = "trackBar_PitchOffset";
            this.trackBar_PitchOffset.Size = new System.Drawing.Size(347, 56);
            this.trackBar_PitchOffset.TabIndex = 12;
            this.trackBar_PitchOffset.Value = 1;
            this.trackBar_PitchOffset.Scroll += new System.EventHandler(this.trackBar_PitchOffset_Scroll);
            // 
            // panel_XYZ
            // 
            this.panel_XYZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_XYZ.Controls.Add(this.label1);
            this.panel_XYZ.Controls.Add(this.trackBar_Pitch);
            this.panel_XYZ.Controls.Add(this.trackBar_Roll);
            this.panel_XYZ.Controls.Add(this.label3);
            this.panel_XYZ.Controls.Add(this.trackBar_Yaw);
            this.panel_XYZ.Controls.Add(this.label2);
            this.panel_XYZ.Location = new System.Drawing.Point(808, 41);
            this.panel_XYZ.Name = "panel_XYZ";
            this.panel_XYZ.Size = new System.Drawing.Size(411, 205);
            this.panel_XYZ.TabIndex = 18;
            // 
            // panel_XYZ1
            // 
            this.panel_XYZ1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_XYZ1.Controls.Add(this.label7);
            this.panel_XYZ1.Controls.Add(this.trackBar_PitchOffset);
            this.panel_XYZ1.Controls.Add(this.label5);
            this.panel_XYZ1.Controls.Add(this.trackBar_YawOffSet);
            this.panel_XYZ1.Controls.Add(this.trackBar_RollOffSet);
            this.panel_XYZ1.Controls.Add(this.label6);
            this.panel_XYZ1.Location = new System.Drawing.Point(808, 252);
            this.panel_XYZ1.Name = "panel_XYZ1";
            this.panel_XYZ1.Size = new System.Drawing.Size(411, 205);
            this.panel_XYZ1.TabIndex = 19;
            this.panel_XYZ1.Visible = false;
            // 
            // trackBar_angle_alpha
            // 
            this.trackBar_angle_alpha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_angle_alpha.Location = new System.Drawing.Point(46, 8);
            this.trackBar_angle_alpha.Maximum = 369;
            this.trackBar_angle_alpha.Minimum = 1;
            this.trackBar_angle_alpha.Name = "trackBar_angle_alpha";
            this.trackBar_angle_alpha.Size = new System.Drawing.Size(347, 56);
            this.trackBar_angle_alpha.TabIndex = 20;
            this.trackBar_angle_alpha.Value = 1;
            this.trackBar_angle_alpha.Scroll += new System.EventHandler(this.trackBar_angle_alpha_Scroll);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 35);
            this.label4.TabIndex = 21;
            this.label4.Text = "α:";
            // 
            // panel_angle
            // 
            this.panel_angle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_angle.Controls.Add(this.label4);
            this.panel_angle.Controls.Add(this.trackBar_angle_alpha);
            this.panel_angle.Location = new System.Drawing.Point(807, 463);
            this.panel_angle.Name = "panel_angle";
            this.panel_angle.Size = new System.Drawing.Size(412, 67);
            this.panel_angle.TabIndex = 22;
            this.panel_angle.Visible = false;
            // 
            // Example5
            // 
            this.Example5.Name = "Example5";
            this.Example5.Size = new System.Drawing.Size(1099, 32);
            this.Example5.Text = "Поворот точки M (x,y,z) вокруг произвольной оси относительно произвольной точки M" +
    "0(x0,y0,z0) на угол α";
            this.Example5.Click += new System.EventHandler(this.Example5_Click);
            // 
            // Example6
            // 
            this.Example6.Name = "Example6";
            this.Example6.Size = new System.Drawing.Size(1099, 32);
            this.Example6.Text = "Вращение вокруг вектора, проходящего через начало коордит на угол α";
            this.Example6.Click += new System.EventHandler(this.Example6_Click);
            // 
            // Example7
            // 
            this.Example7.Name = "Example7";
            this.Example7.Size = new System.Drawing.Size(1099, 32);
            this.Example7.Text = "Вращение вокруг произвольной прямой на угол α";
            this.Example7.Click += new System.EventHandler(this.Example7_Click);
            // 
            // Example8
            // 
            this.Example8.Name = "Example8";
            this.Example8.Size = new System.Drawing.Size(1099, 32);
            this.Example8.Text = "Произвольное вращение";
            this.Example8.Click += new System.EventHandler(this.Example8_Click);
            // 
            // Example9
            // 
            this.Example9.Name = "Example9";
            this.Example9.Size = new System.Drawing.Size(1099, 32);
            this.Example9.Text = "Визуализация вершин куба";
            this.Example9.Click += new System.EventHandler(this.Example9_Click);
            // 
            // Example10
            // 
            this.Example10.Name = "Example10";
            this.Example10.Size = new System.Drawing.Size(1099, 32);
            this.Example10.Text = "Визуализация граней куба";
            this.Example10.Click += new System.EventHandler(this.Example10_Click);
            // 
            // Example11
            // 
            this.Example11.Name = "Example11";
            this.Example11.Size = new System.Drawing.Size(1099, 32);
            this.Example11.Text = "Изображение сторон куба. Удаление вкрытых поверхностей";
            this.Example11.Click += new System.EventHandler(this.Example11_Click);
            // 
            // Example12
            // 
            this.Example12.Name = "Example12";
            this.Example12.Size = new System.Drawing.Size(1099, 32);
            this.Example12.Text = "Параллелипед, как совокупность точек";
            this.Example12.Click += new System.EventHandler(this.Example12_Click);
            // 
            // Example13
            // 
            this.Example13.Name = "Example13";
            this.Example13.Size = new System.Drawing.Size(1099, 32);
            this.Example13.Text = "Пирамида как совокупность точке";
            this.Example13.Click += new System.EventHandler(this.Example13_Click);
            // 
            // Example14
            // 
            this.Example14.Name = "Example14";
            this.Example14.Size = new System.Drawing.Size(1099, 32);
            this.Example14.Text = "Цилиндр как совокупность точек";
            this.Example14.Click += new System.EventHandler(this.Example14_Click);
            // 
            // Example15
            // 
            this.Example15.Name = "Example15";
            this.Example15.Size = new System.Drawing.Size(1099, 32);
            this.Example15.Text = "Сфера как совокупность точек";
            this.Example15.Click += new System.EventHandler(this.Example15_Click);
            // 
            // Example16
            // 
            this.Example16.Name = "Example16";
            this.Example16.Size = new System.Drawing.Size(1099, 32);
            this.Example16.Text = "Конус как совокупность точек";
            this.Example16.Click += new System.EventHandler(this.Example16_Click);
            // 
            // Example17
            // 
            this.Example17.Name = "Example17";
            this.Example17.Size = new System.Drawing.Size(1099, 32);
            this.Example17.Text = "Комбинация двух конусов";
            this.Example17.Click += new System.EventHandler(this.Example17_Click);
            // 
            // Example18
            // 
            this.Example18.Name = "Example18";
            this.Example18.Size = new System.Drawing.Size(1099, 32);
            this.Example18.Text = "Объединение трех усеченных конусов";
            this.Example18.Click += new System.EventHandler(this.Example18_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 683);
            this.Controls.Add(this.panel_angle);
            this.Controls.Add(this.panel_XYZ1);
            this.Controls.Add(this.panel_XYZ);
            this.Controls.Add(this.toolStrip1);
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
            this.panel_XYZ.ResumeLayout(false);
            this.panel_XYZ.PerformLayout();
            this.panel_XYZ1.ResumeLayout(false);
            this.panel_XYZ1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_angle_alpha)).EndInit();
            this.panel_angle.ResumeLayout(false);
            this.panel_angle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_drawing;
        private System.Windows.Forms.TrackBar trackBar_Pitch;
        private System.Windows.Forms.TrackBar trackBar_Yaw;
        private System.Windows.Forms.TrackBar trackBar_Roll;
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
        private System.Windows.Forms.ToolStripMenuItem Example3;
        private System.Windows.Forms.Panel panel_XYZ;
        private System.Windows.Forms.Panel panel_XYZ1;
		private System.Windows.Forms.ToolStripMenuItem Example4;
		private System.Windows.Forms.TrackBar trackBar_angle_alpha;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel_angle;
		private System.Windows.Forms.ToolStripMenuItem Example5;
		private System.Windows.Forms.ToolStripMenuItem Example6;
		private System.Windows.Forms.ToolStripMenuItem Example7;
		private System.Windows.Forms.ToolStripMenuItem Example8;
		private System.Windows.Forms.ToolStripMenuItem Example9;
		private System.Windows.Forms.ToolStripMenuItem Example10;
		private System.Windows.Forms.ToolStripMenuItem Example11;
		private System.Windows.Forms.ToolStripMenuItem Example12;
		private System.Windows.Forms.ToolStripMenuItem Example13;
		private System.Windows.Forms.ToolStripMenuItem Example14;
		private System.Windows.Forms.ToolStripMenuItem Example15;
		private System.Windows.Forms.ToolStripMenuItem Example16;
		private System.Windows.Forms.ToolStripMenuItem Example17;
		private System.Windows.Forms.ToolStripMenuItem Example18;
	}
}

