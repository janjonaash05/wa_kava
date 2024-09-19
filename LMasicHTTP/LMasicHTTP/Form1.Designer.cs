namespace http_winform
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
            print = new Button();
            monthComboBox = new ComboBox();
            monthDataFlowLayout = new FlowLayoutPanel();
            peopleFlowLayout = new FlowLayoutPanel();
            send = new Button();
            drinksFlowLayout = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // print
            // 
            print.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            print.Location = new Point(744, 553);
            print.Name = "print";
            print.Size = new Size(159, 79);
            print.TabIndex = 0;
            print.Text = "Vypsat";
            print.UseVisualStyleBackColor = true;
            print.Click += print_Click;
            // 
            // monthComboBox
            // 
            monthComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            monthComboBox.Items.AddRange(new object[] { "leden", "únor", "březen", "duben", "květen", "červen", "červenec", "srpen", "září", "říjen", "listopad", "prosinec" });
            monthComboBox.Location = new Point(744, 524);
            monthComboBox.Name = "monthComboBox";
            monthComboBox.Size = new Size(159, 23);
            monthComboBox.TabIndex = 1;
            // 
            // monthDataFlowLayout
            // 
            monthDataFlowLayout.AutoScroll = true;
            monthDataFlowLayout.BackColor = Color.Silver;
            monthDataFlowLayout.FlowDirection = FlowDirection.TopDown;
            monthDataFlowLayout.Location = new Point(642, 11);
            monthDataFlowLayout.Name = "monthDataFlowLayout";
            monthDataFlowLayout.Size = new Size(352, 507);
            monthDataFlowLayout.TabIndex = 7;
            monthDataFlowLayout.WrapContents = false;
            // 
            // peopleFlowLayout
            // 
            peopleFlowLayout.AutoScroll = true;
            peopleFlowLayout.BackColor = Color.Silver;
            peopleFlowLayout.FlowDirection = FlowDirection.TopDown;
            peopleFlowLayout.Location = new Point(15, 11);
            peopleFlowLayout.Name = "peopleFlowLayout";
            peopleFlowLayout.Size = new Size(523, 234);
            peopleFlowLayout.TabIndex = 8;
            peopleFlowLayout.WrapContents = false;
            // 
            // send
            // 
            send.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            send.Location = new Point(189, 553);
            send.Name = "send";
            send.Size = new Size(159, 79);
            send.TabIndex = 10;
            send.Text = "Odeslat";
            send.UseVisualStyleBackColor = true;
            send.Click += send_Click;
            // 
            // drinksFlowLayout
            // 
            drinksFlowLayout.AutoScroll = true;
            drinksFlowLayout.BackColor = Color.Silver;
            drinksFlowLayout.FlowDirection = FlowDirection.TopDown;
            drinksFlowLayout.Location = new Point(15, 251);
            drinksFlowLayout.Name = "drinksFlowLayout";
            drinksFlowLayout.Size = new Size(523, 296);
            drinksFlowLayout.TabIndex = 9;
            drinksFlowLayout.WrapContents = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 658);
            Controls.Add(drinksFlowLayout);
            Controls.Add(send);
            Controls.Add(monthDataFlowLayout);
            Controls.Add(monthComboBox);
            Controls.Add(print);
            Controls.Add(peopleFlowLayout);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button print;
        private ComboBox monthComboBox;
        private TrackBar trackBar2;
        private FlowLayoutPanel monthDataFlowLayout;
        private FlowLayoutPanel peopleFlowLayout;
        private Button send;
        private FlowLayoutPanel drinksFlowLayout;
        private Panel panel1;
        private Label label2;
        private Label label1;
    }
}
