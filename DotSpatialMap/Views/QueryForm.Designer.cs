namespace DotSpatialMap.Views
{
    partial class QueryForm
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
            this.QueryTypeChooser = new System.Windows.Forms.ComboBox();
            this.queryButtonOK = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QueryTypeChooser
            // 
            this.QueryTypeChooser.FormattingEnabled = true;
            this.QueryTypeChooser.Items.AddRange(new object[] {
            "Intersection",
            "Union",
            "Couverture",
            "Difference"});
            this.QueryTypeChooser.Location = new System.Drawing.Point(61, 43);
            this.QueryTypeChooser.Name = "QueryTypeChooser";
            this.QueryTypeChooser.Size = new System.Drawing.Size(237, 21);
            this.QueryTypeChooser.TabIndex = 0;
            // 
            // queryButtonOK
            // 
            this.queryButtonOK.Location = new System.Drawing.Point(61, 129);
            this.queryButtonOK.Name = "queryButtonOK";
            this.queryButtonOK.Size = new System.Drawing.Size(75, 23);
            this.queryButtonOK.TabIndex = 1;
            this.queryButtonOK.Text = "OK";
            this.queryButtonOK.UseVisualStyleBackColor = true;
            this.queryButtonOK.Click += new System.EventHandler(this.queryButtonOKClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(223, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.queryButtonOK);
            this.Controls.Add(this.QueryTypeChooser);
            this.Name = "QueryForm";
            this.Text = "QueryForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox QueryTypeChooser;
        private System.Windows.Forms.Button queryButtonOK;
        private System.Windows.Forms.Button button2;
    }
}