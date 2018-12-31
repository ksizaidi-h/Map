namespace DotSpatialMap.Views
{
    partial class AddLayerDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.LayerClassChooser = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LayerNameTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmLayerBtn = new System.Windows.Forms.Button();
            this.CancelAddLayerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class";
            // 
            // LayerClassChooser
            // 
            this.LayerClassChooser.FormattingEnabled = true;
            this.LayerClassChooser.Items.AddRange(new object[] {
            "Polygon",
            "Line",
            "Point"});
            this.LayerClassChooser.Location = new System.Drawing.Point(155, 49);
            this.LayerClassChooser.Name = "LayerClassChooser";
            this.LayerClassChooser.Size = new System.Drawing.Size(296, 24);
            this.LayerClassChooser.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Layer Name";
            // 
            // LayerNameTextBox
            // 
            this.LayerNameTextBox.Location = new System.Drawing.Point(155, 112);
            this.LayerNameTextBox.Name = "LayerNameTextBox";
            this.LayerNameTextBox.Size = new System.Drawing.Size(296, 22);
            this.LayerNameTextBox.TabIndex = 3;
            // 
            // ConfirmLayerBtn
            // 
            this.ConfirmLayerBtn.Location = new System.Drawing.Point(155, 159);
            this.ConfirmLayerBtn.Name = "ConfirmLayerBtn";
            this.ConfirmLayerBtn.Size = new System.Drawing.Size(107, 23);
            this.ConfirmLayerBtn.TabIndex = 4;
            this.ConfirmLayerBtn.Text = "Confirm";
            this.ConfirmLayerBtn.UseVisualStyleBackColor = true;
            this.ConfirmLayerBtn.Click += new System.EventHandler(this.ConfirmLayerBtn_Click);
            // 
            // CancelAddLayerBtn
            // 
            this.CancelAddLayerBtn.Location = new System.Drawing.Point(350, 158);
            this.CancelAddLayerBtn.Name = "CancelAddLayerBtn";
            this.CancelAddLayerBtn.Size = new System.Drawing.Size(100, 23);
            this.CancelAddLayerBtn.TabIndex = 5;
            this.CancelAddLayerBtn.Text = "Cancel";
            this.CancelAddLayerBtn.UseVisualStyleBackColor = true;
            this.CancelAddLayerBtn.Click += new System.EventHandler(this.CancelAddLayerBtn_Click);
            // 
            // AddLayerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 209);
            this.Controls.Add(this.CancelAddLayerBtn);
            this.Controls.Add(this.ConfirmLayerBtn);
            this.Controls.Add(this.LayerNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LayerClassChooser);
            this.Controls.Add(this.label1);
            this.Name = "AddLayerDialog";
            this.Text = "AddLayerDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox LayerClassChooser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LayerNameTextBox;
        private System.Windows.Forms.Button ConfirmLayerBtn;
        private System.Windows.Forms.Button CancelAddLayerBtn;
    }
}