namespace FormSample
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
      this.button1 = new System.Windows.Forms.Button();
      this.txtResult = new System.Windows.Forms.RichTextBox();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.text1 = new System.Windows.Forms.RichTextBox();
      this.text2 = new System.Windows.Forms.RichTextBox();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(25, 33);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(94, 29);
      this.button1.TabIndex = 0;
      this.button1.Text = "Veri Çek";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // txtResult
      // 
      this.txtResult.Location = new System.Drawing.Point(12, 115);
      this.txtResult.Name = "txtResult";
      this.txtResult.Size = new System.Drawing.Size(155, 323);
      this.txtResult.TabIndex = 1;
      this.txtResult.Text = "";
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(428, 33);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(94, 29);
      this.button2.TabIndex = 2;
      this.button2.Text = "button2";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(593, 33);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(94, 29);
      this.button3.TabIndex = 3;
      this.button3.Text = "button3";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // text1
      // 
      this.text1.Location = new System.Drawing.Point(367, 93);
      this.text1.Name = "text1";
      this.text1.Size = new System.Drawing.Size(155, 323);
      this.text1.TabIndex = 4;
      this.text1.Text = "";
      // 
      // text2
      // 
      this.text2.Location = new System.Drawing.Point(593, 93);
      this.text2.Name = "text2";
      this.text2.Size = new System.Drawing.Size(155, 323);
      this.text2.TabIndex = 5;
      this.text2.Text = "";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.text2);
      this.Controls.Add(this.text1);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.txtResult);
      this.Controls.Add(this.button1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);

    }

    #endregion

    private Button button1;
    private RichTextBox txtResult;
    private Button button2;
    private Button button3;
    private RichTextBox text1;
    private RichTextBox text2;
  }
}