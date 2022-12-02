
namespace _3DPreciseLocate
{
    partial class frmPreciseLocate
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxInit = new System.Windows.Forms.GroupBox();
            this.btnDownsample = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnCapturePointCloud = new System.Windows.Forms.Button();
            this.btnOpenCADPointCloud = new System.Windows.Forms.Button();
            this.panelControl = new System.Windows.Forms.Panel();
            this.groupBoxRegisControl = new System.Windows.Forms.GroupBox();
            this.btnStopRegis = new System.Windows.Forms.Button();
            this.logRegisStatus = new System.Windows.Forms.TextBox();
            this.btnStartRegis = new System.Windows.Forms.Button();
            this.groupBoxRegisPara = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numNormal = new System.Windows.Forms.NumericUpDown();
            this.labelNormal = new System.Windows.Forms.Label();
            this.numTransformationEpsilon = new System.Windows.Forms.NumericUpDown();
            this.labelTransformationEpsilon = new System.Windows.Forms.Label();
            this.numMaxCorrespondenceDistance = new System.Windows.Forms.NumericUpDown();
            this.labelMaxCorrespondenceDistance = new System.Windows.Forms.Label();
            this.numEuclideanEpsilon = new System.Windows.Forms.NumericUpDown();
            this.labelEuclideanEpsilon = new System.Windows.Forms.Label();
            this.numMaximumIterations = new System.Windows.Forms.NumericUpDown();
            this.labelMaximumIterations = new System.Windows.Forms.Label();
            this.cbbRegisMethod = new System.Windows.Forms.ComboBox();
            this.panelLog = new System.Windows.Forms.Panel();
            this.panelShow = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.相机ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重连相机ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.相机参数设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Log = new System.Windows.Forms.TextBox();
            this.pictureBoxPointCloud = new System.Windows.Forms.PictureBox();
            this.groupBoxInit.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.groupBoxRegisControl.SuspendLayout();
            this.groupBoxRegisPara.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTransformationEpsilon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxCorrespondenceDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEuclideanEpsilon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaximumIterations)).BeginInit();
            this.panelLog.SuspendLayout();
            this.panelShow.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPointCloud)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInit
            // 
            this.groupBoxInit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBoxInit.Controls.Add(this.btnDownsample);
            this.groupBoxInit.Controls.Add(this.btnFilter);
            this.groupBoxInit.Controls.Add(this.btnCapturePointCloud);
            this.groupBoxInit.Controls.Add(this.btnOpenCADPointCloud);
            this.groupBoxInit.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxInit.Location = new System.Drawing.Point(0, 10);
            this.groupBoxInit.Name = "groupBoxInit";
            this.groupBoxInit.Size = new System.Drawing.Size(224, 117);
            this.groupBoxInit.TabIndex = 0;
            this.groupBoxInit.TabStop = false;
            this.groupBoxInit.Text = "准备工作";
            // 
            // btnDownsample
            // 
            this.btnDownsample.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDownsample.Location = new System.Drawing.Point(79, 68);
            this.btnDownsample.Name = "btnDownsample";
            this.btnDownsample.Size = new System.Drawing.Size(67, 42);
            this.btnDownsample.TabIndex = 5;
            this.btnDownsample.Text = "点云降采样";
            this.btnDownsample.UseVisualStyleBackColor = false;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFilter.Location = new System.Drawing.Point(6, 68);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(67, 42);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "点云滤波";
            this.btnFilter.UseVisualStyleBackColor = false;
            // 
            // btnCapturePointCloud
            // 
            this.btnCapturePointCloud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCapturePointCloud.Location = new System.Drawing.Point(79, 20);
            this.btnCapturePointCloud.Name = "btnCapturePointCloud";
            this.btnCapturePointCloud.Size = new System.Drawing.Size(67, 42);
            this.btnCapturePointCloud.TabIndex = 3;
            this.btnCapturePointCloud.Text = "获取工件当前点云";
            this.btnCapturePointCloud.UseVisualStyleBackColor = false;
            // 
            // btnOpenCADPointCloud
            // 
            this.btnOpenCADPointCloud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOpenCADPointCloud.Location = new System.Drawing.Point(6, 20);
            this.btnOpenCADPointCloud.Name = "btnOpenCADPointCloud";
            this.btnOpenCADPointCloud.Size = new System.Drawing.Size(67, 42);
            this.btnOpenCADPointCloud.TabIndex = 2;
            this.btnOpenCADPointCloud.Text = "读取工件CAD点云";
            this.btnOpenCADPointCloud.UseVisualStyleBackColor = false;
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.groupBoxRegisControl);
            this.panelControl.Controls.Add(this.groupBoxRegisPara);
            this.panelControl.Controls.Add(this.groupBoxInit);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl.Location = new System.Drawing.Point(0, 25);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(224, 758);
            this.panelControl.TabIndex = 2;
            // 
            // groupBoxRegisControl
            // 
            this.groupBoxRegisControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBoxRegisControl.Controls.Add(this.btnStopRegis);
            this.groupBoxRegisControl.Controls.Add(this.logRegisStatus);
            this.groupBoxRegisControl.Controls.Add(this.btnStartRegis);
            this.groupBoxRegisControl.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxRegisControl.Location = new System.Drawing.Point(0, 344);
            this.groupBoxRegisControl.Name = "groupBoxRegisControl";
            this.groupBoxRegisControl.Size = new System.Drawing.Size(224, 97);
            this.groupBoxRegisControl.TabIndex = 7;
            this.groupBoxRegisControl.TabStop = false;
            this.groupBoxRegisControl.Text = "点云配准";
            // 
            // btnStopRegis
            // 
            this.btnStopRegis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStopRegis.Location = new System.Drawing.Point(79, 20);
            this.btnStopRegis.Name = "btnStopRegis";
            this.btnStopRegis.Size = new System.Drawing.Size(67, 42);
            this.btnStopRegis.TabIndex = 4;
            this.btnStopRegis.Text = "终止配准";
            this.btnStopRegis.UseVisualStyleBackColor = false;
            // 
            // logRegisStatus
            // 
            this.logRegisStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logRegisStatus.ForeColor = System.Drawing.Color.Maroon;
            this.logRegisStatus.Location = new System.Drawing.Point(6, 68);
            this.logRegisStatus.Name = "logRegisStatus";
            this.logRegisStatus.Size = new System.Drawing.Size(207, 21);
            this.logRegisStatus.TabIndex = 3;
            // 
            // btnStartRegis
            // 
            this.btnStartRegis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStartRegis.Location = new System.Drawing.Point(6, 20);
            this.btnStartRegis.Name = "btnStartRegis";
            this.btnStartRegis.Size = new System.Drawing.Size(67, 42);
            this.btnStartRegis.TabIndex = 2;
            this.btnStartRegis.Text = "开始配准";
            this.btnStartRegis.UseVisualStyleBackColor = false;
            // 
            // groupBoxRegisPara
            // 
            this.groupBoxRegisPara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBoxRegisPara.Controls.Add(this.label6);
            this.groupBoxRegisPara.Controls.Add(this.numNormal);
            this.groupBoxRegisPara.Controls.Add(this.labelNormal);
            this.groupBoxRegisPara.Controls.Add(this.numTransformationEpsilon);
            this.groupBoxRegisPara.Controls.Add(this.labelTransformationEpsilon);
            this.groupBoxRegisPara.Controls.Add(this.numMaxCorrespondenceDistance);
            this.groupBoxRegisPara.Controls.Add(this.labelMaxCorrespondenceDistance);
            this.groupBoxRegisPara.Controls.Add(this.numEuclideanEpsilon);
            this.groupBoxRegisPara.Controls.Add(this.labelEuclideanEpsilon);
            this.groupBoxRegisPara.Controls.Add(this.numMaximumIterations);
            this.groupBoxRegisPara.Controls.Add(this.labelMaximumIterations);
            this.groupBoxRegisPara.Controls.Add(this.cbbRegisMethod);
            this.groupBoxRegisPara.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxRegisPara.Location = new System.Drawing.Point(0, 140);
            this.groupBoxRegisPara.Name = "groupBoxRegisPara";
            this.groupBoxRegisPara.Size = new System.Drawing.Size(224, 190);
            this.groupBoxRegisPara.TabIndex = 6;
            this.groupBoxRegisPara.TabStop = false;
            this.groupBoxRegisPara.Text = "配准算法及参数设置";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "配准算法：";
            // 
            // numNormal
            // 
            this.numNormal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numNormal.DecimalPlaces = 10;
            this.numNormal.ForeColor = System.Drawing.SystemColors.Control;
            this.numNormal.Location = new System.Drawing.Point(113, 160);
            this.numNormal.Name = "numNormal";
            this.numNormal.Size = new System.Drawing.Size(100, 21);
            this.numNormal.TabIndex = 13;
            this.numNormal.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numNormal.Visible = false;
            // 
            // labelNormal
            // 
            this.labelNormal.AutoSize = true;
            this.labelNormal.Location = new System.Drawing.Point(6, 164);
            this.labelNormal.Name = "labelNormal";
            this.labelNormal.Size = new System.Drawing.Size(53, 12);
            this.labelNormal.TabIndex = 12;
            this.labelNormal.Text = "法向量：";
            this.labelNormal.Visible = false;
            // 
            // numTransformationEpsilon
            // 
            this.numTransformationEpsilon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numTransformationEpsilon.DecimalPlaces = 10;
            this.numTransformationEpsilon.ForeColor = System.Drawing.SystemColors.Control;
            this.numTransformationEpsilon.Increment = new decimal(new int[] {
            1,
            0,
            0,
            655360});
            this.numTransformationEpsilon.Location = new System.Drawing.Point(113, 133);
            this.numTransformationEpsilon.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTransformationEpsilon.Name = "numTransformationEpsilon";
            this.numTransformationEpsilon.Size = new System.Drawing.Size(100, 21);
            this.numTransformationEpsilon.TabIndex = 11;
            this.numTransformationEpsilon.Value = new decimal(new int[] {
            1,
            0,
            0,
            655360});
            // 
            // labelTransformationEpsilon
            // 
            this.labelTransformationEpsilon.AutoSize = true;
            this.labelTransformationEpsilon.Location = new System.Drawing.Point(6, 137);
            this.labelTransformationEpsilon.Name = "labelTransformationEpsilon";
            this.labelTransformationEpsilon.Size = new System.Drawing.Size(89, 12);
            this.labelTransformationEpsilon.TabIndex = 10;
            this.labelTransformationEpsilon.Text = "矩阵转换容差：";
            // 
            // numMaxCorrespondenceDistance
            // 
            this.numMaxCorrespondenceDistance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numMaxCorrespondenceDistance.DecimalPlaces = 10;
            this.numMaxCorrespondenceDistance.ForeColor = System.Drawing.SystemColors.Control;
            this.numMaxCorrespondenceDistance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numMaxCorrespondenceDistance.Location = new System.Drawing.Point(113, 106);
            this.numMaxCorrespondenceDistance.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMaxCorrespondenceDistance.Name = "numMaxCorrespondenceDistance";
            this.numMaxCorrespondenceDistance.Size = new System.Drawing.Size(100, 21);
            this.numMaxCorrespondenceDistance.TabIndex = 9;
            this.numMaxCorrespondenceDistance.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // labelMaxCorrespondenceDistance
            // 
            this.labelMaxCorrespondenceDistance.AutoSize = true;
            this.labelMaxCorrespondenceDistance.Location = new System.Drawing.Point(6, 110);
            this.labelMaxCorrespondenceDistance.Name = "labelMaxCorrespondenceDistance";
            this.labelMaxCorrespondenceDistance.Size = new System.Drawing.Size(89, 12);
            this.labelMaxCorrespondenceDistance.TabIndex = 8;
            this.labelMaxCorrespondenceDistance.Text = "最大欧氏距离：";
            // 
            // numEuclideanEpsilon
            // 
            this.numEuclideanEpsilon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numEuclideanEpsilon.DecimalPlaces = 10;
            this.numEuclideanEpsilon.ForeColor = System.Drawing.SystemColors.Control;
            this.numEuclideanEpsilon.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numEuclideanEpsilon.Location = new System.Drawing.Point(113, 79);
            this.numEuclideanEpsilon.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numEuclideanEpsilon.Name = "numEuclideanEpsilon";
            this.numEuclideanEpsilon.Size = new System.Drawing.Size(100, 21);
            this.numEuclideanEpsilon.TabIndex = 7;
            this.numEuclideanEpsilon.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // labelEuclideanEpsilon
            // 
            this.labelEuclideanEpsilon.AutoSize = true;
            this.labelEuclideanEpsilon.Location = new System.Drawing.Point(6, 83);
            this.labelEuclideanEpsilon.Name = "labelEuclideanEpsilon";
            this.labelEuclideanEpsilon.Size = new System.Drawing.Size(89, 12);
            this.labelEuclideanEpsilon.TabIndex = 6;
            this.labelEuclideanEpsilon.Text = "欧氏距离容差：";
            // 
            // numMaximumIterations
            // 
            this.numMaximumIterations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numMaximumIterations.ForeColor = System.Drawing.SystemColors.Control;
            this.numMaximumIterations.Location = new System.Drawing.Point(113, 51);
            this.numMaximumIterations.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMaximumIterations.Name = "numMaximumIterations";
            this.numMaximumIterations.Size = new System.Drawing.Size(100, 21);
            this.numMaximumIterations.TabIndex = 5;
            this.numMaximumIterations.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // labelMaximumIterations
            // 
            this.labelMaximumIterations.AutoSize = true;
            this.labelMaximumIterations.Location = new System.Drawing.Point(6, 55);
            this.labelMaximumIterations.Name = "labelMaximumIterations";
            this.labelMaximumIterations.Size = new System.Drawing.Size(89, 12);
            this.labelMaximumIterations.TabIndex = 4;
            this.labelMaximumIterations.Text = "最大迭代次数：";
            // 
            // cbbRegisMethod
            // 
            this.cbbRegisMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbbRegisMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRegisMethod.ForeColor = System.Drawing.SystemColors.Control;
            this.cbbRegisMethod.FormattingEnabled = true;
            this.cbbRegisMethod.Items.AddRange(new object[] {
            "ICP",
            "NICP"});
            this.cbbRegisMethod.Location = new System.Drawing.Point(113, 20);
            this.cbbRegisMethod.Name = "cbbRegisMethod";
            this.cbbRegisMethod.Size = new System.Drawing.Size(100, 20);
            this.cbbRegisMethod.TabIndex = 3;
            this.cbbRegisMethod.SelectedIndexChanged += new System.EventHandler(this.cbbRegisMethod_SelectedIndexChanged);
            // 
            // panelLog
            // 
            this.panelLog.Controls.Add(this.Log);
            this.panelLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLog.Location = new System.Drawing.Point(224, 528);
            this.panelLog.Name = "panelLog";
            this.panelLog.Size = new System.Drawing.Size(1070, 255);
            this.panelLog.TabIndex = 3;
            // 
            // panelShow
            // 
            this.panelShow.Controls.Add(this.pictureBoxPointCloud);
            this.panelShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShow.Location = new System.Drawing.Point(224, 25);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(1070, 503);
            this.panelShow.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.相机ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1294, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 相机ToolStripMenuItem
            // 
            this.相机ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.重连相机ToolStripMenuItem,
            this.相机参数设置ToolStripMenuItem});
            this.相机ToolStripMenuItem.Name = "相机ToolStripMenuItem";
            this.相机ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.相机ToolStripMenuItem.Text = "相机";
            // 
            // 重连相机ToolStripMenuItem
            // 
            this.重连相机ToolStripMenuItem.Name = "重连相机ToolStripMenuItem";
            this.重连相机ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.重连相机ToolStripMenuItem.Text = "重连相机";
            // 
            // 相机参数设置ToolStripMenuItem
            // 
            this.相机参数设置ToolStripMenuItem.Name = "相机参数设置ToolStripMenuItem";
            this.相机参数设置ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.相机参数设置ToolStripMenuItem.Text = "相机参数设置";
            // 
            // Log
            // 
            this.Log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Log.ForeColor = System.Drawing.SystemColors.Control;
            this.Log.Location = new System.Drawing.Point(0, 0);
            this.Log.Multiline = true;
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(1070, 255);
            this.Log.TabIndex = 0;
            // 
            // pictureBoxPointCloud
            // 
            this.pictureBoxPointCloud.BackColor = System.Drawing.Color.Black;
            this.pictureBoxPointCloud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPointCloud.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPointCloud.Name = "pictureBoxPointCloud";
            this.pictureBoxPointCloud.Size = new System.Drawing.Size(1070, 503);
            this.pictureBoxPointCloud.TabIndex = 0;
            this.pictureBoxPointCloud.TabStop = false;
            // 
            // frmPreciseLocate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1294, 783);
            this.Controls.Add(this.panelShow);
            this.Controls.Add(this.panelLog);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "frmPreciseLocate";
            this.Text = "3DPreciseLocateForm";
            this.Load += new System.EventHandler(this.frmPreciseLocate_Load);
            this.groupBoxInit.ResumeLayout(false);
            this.panelControl.ResumeLayout(false);
            this.groupBoxRegisControl.ResumeLayout(false);
            this.groupBoxRegisControl.PerformLayout();
            this.groupBoxRegisPara.ResumeLayout(false);
            this.groupBoxRegisPara.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTransformationEpsilon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxCorrespondenceDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEuclideanEpsilon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaximumIterations)).EndInit();
            this.panelLog.ResumeLayout(false);
            this.panelLog.PerformLayout();
            this.panelShow.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPointCloud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInit;
        private System.Windows.Forms.Button btnOpenCADPointCloud;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel panelLog;
        private System.Windows.Forms.Panel panelShow;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 相机ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重连相机ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 相机参数设置ToolStripMenuItem;
        private System.Windows.Forms.Button btnCapturePointCloud;
        private System.Windows.Forms.Button btnDownsample;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.GroupBox groupBoxRegisPara;
        private System.Windows.Forms.GroupBox groupBoxRegisControl;
        private System.Windows.Forms.Button btnStartRegis;
        private System.Windows.Forms.TextBox logRegisStatus;
        private System.Windows.Forms.ComboBox cbbRegisMethod;
        private System.Windows.Forms.NumericUpDown numMaximumIterations;
        private System.Windows.Forms.Label labelMaximumIterations;
        private System.Windows.Forms.NumericUpDown numNormal;
        private System.Windows.Forms.Label labelNormal;
        private System.Windows.Forms.NumericUpDown numTransformationEpsilon;
        private System.Windows.Forms.Label labelTransformationEpsilon;
        private System.Windows.Forms.NumericUpDown numMaxCorrespondenceDistance;
        private System.Windows.Forms.Label labelMaxCorrespondenceDistance;
        private System.Windows.Forms.NumericUpDown numEuclideanEpsilon;
        private System.Windows.Forms.Label labelEuclideanEpsilon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnStopRegis;
        private System.Windows.Forms.TextBox Log;
        private System.Windows.Forms.PictureBox pictureBoxPointCloud;
    }
}

