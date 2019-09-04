namespace LaserEngineHmi.View.Controls
{
    partial class AdobeReaderControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdobeReaderControl));
            this.axAcroPdfDrawing = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPdfDrawing)).BeginInit();
            this.SuspendLayout();
            // 
            // axAcroPdfDrawing
            // 
            this.axAcroPdfDrawing.Enabled = true;
            this.axAcroPdfDrawing.Location = new System.Drawing.Point(0, 3);
            this.axAcroPdfDrawing.Name = "axAcroPdfDrawing";
            this.axAcroPdfDrawing.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPdfDrawing.OcxState")));
            this.axAcroPdfDrawing.Size = new System.Drawing.Size(610, 425);
            this.axAcroPdfDrawing.TabIndex = 1;
            // 
            // AdobeReaderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.axAcroPdfDrawing);
            this.Name = "AdobeReaderControl";
            this.Size = new System.Drawing.Size(431, 334);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPdfDrawing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF axAcroPdfDrawing;
    }
}
