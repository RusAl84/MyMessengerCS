
namespace WindowsFormsApp1
{
  partial class Form1
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
      this.components = new System.ComponentModel.Container();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.SendBtn = new System.Windows.Forms.Button();
      this.MessagesLB = new System.Windows.Forms.ListBox();
      this.UserNameTB = new System.Windows.Forms.TextBox();
      this.MessageTB = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Interval = 1000;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // SendBtn
      // 
      this.SendBtn.Location = new System.Drawing.Point(563, 388);
      this.SendBtn.Name = "SendBtn";
      this.SendBtn.Size = new System.Drawing.Size(122, 73);
      this.SendBtn.TabIndex = 0;
      this.SendBtn.Text = "Отправить";
      this.SendBtn.UseVisualStyleBackColor = true;
      this.SendBtn.Click += new System.EventHandler(this.button1_Click);
      // 
      // MessagesLB
      // 
      this.MessagesLB.ForeColor = System.Drawing.Color.Yellow;
      this.MessagesLB.FormattingEnabled = true;
      this.MessagesLB.ItemHeight = 16;
      this.MessagesLB.Location = new System.Drawing.Point(28, 24);
      this.MessagesLB.Name = "MessagesLB";
      this.MessagesLB.Size = new System.Drawing.Size(657, 340);
      this.MessagesLB.TabIndex = 1;
      this.MessagesLB.SelectedIndexChanged += new System.EventHandler(this.MessagesLB_SelectedIndexChanged);
      // 
      // UserNameTB
      // 
      this.UserNameTB.Location = new System.Drawing.Point(28, 388);
      this.UserNameTB.Name = "UserNameTB";
      this.UserNameTB.Size = new System.Drawing.Size(279, 22);
      this.UserNameTB.TabIndex = 2;
      // 
      // MessageTB
      // 
      this.MessageTB.Location = new System.Drawing.Point(28, 439);
      this.MessageTB.Name = "MessageTB";
      this.MessageTB.Size = new System.Drawing.Size(518, 22);
      this.MessageTB.TabIndex = 3;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(697, 489);
      this.Controls.Add(this.MessageTB);
      this.Controls.Add(this.UserNameTB);
      this.Controls.Add(this.MessagesLB);
      this.Controls.Add(this.SendBtn);
      this.Name = "Form1";
      this.Text = "WF Messenger";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Button SendBtn;
    private System.Windows.Forms.ListBox MessagesLB;
    private System.Windows.Forms.TextBox UserNameTB;
    private System.Windows.Forms.TextBox MessageTB;
  }
}

