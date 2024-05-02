namespace appReadXML_From_URL
{
    partial class Form1
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
            btnStart = new Button();
            txtXMLData = new TextBox();
            txtURL = new TextBox();
            lstvOrder = new ListView();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(52, 30);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(109, 42);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // txtXMLData
            // 
            txtXMLData.Location = new Point(12, 104);
            txtXMLData.Multiline = true;
            txtXMLData.Name = "txtXMLData";
            txtXMLData.ScrollBars = ScrollBars.Vertical;
            txtXMLData.Size = new Size(386, 334);
            txtXMLData.TabIndex = 1;
            // 
            // txtURL
            // 
            txtURL.Location = new Point(213, 49);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(100, 23);
            txtURL.TabIndex = 2;
            // 
            // lstvOrder
            // 
            lstvOrder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstvOrder.Location = new Point(418, 104);
            lstvOrder.Name = "lstvOrder";
            lstvOrder.Size = new Size(370, 334);
            lstvOrder.TabIndex = 3;
            lstvOrder.UseCompatibleStateImageBehavior = false;
            lstvOrder.View = View.Details;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstvOrder);
            Controls.Add(txtURL);
            Controls.Add(txtXMLData);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private TextBox txtXMLData;
        private TextBox txtURL;
        private ListView lstvOrder;
    }
}
