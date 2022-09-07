
namespace TrushkovPractica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.progressBarButton = new System.Windows.Forms.Button();
            this.animationButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBarButton
            // 
            this.progressBarButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.progressBarButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBarButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBarButton.Location = new System.Drawing.Point(3, 3);
            this.progressBarButton.Name = "progressBarButton";
            this.progressBarButton.Size = new System.Drawing.Size(246, 360);
            this.progressBarButton.TabIndex = 0;
            this.progressBarButton.Text = "Прогресс-бар";
            this.progressBarButton.UseVisualStyleBackColor = false;
            this.progressBarButton.Click += new System.EventHandler(this.progressBarButton_Click);
            // 
            // animationButton
            // 
            this.animationButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.animationButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.animationButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.animationButton.Location = new System.Drawing.Point(255, 3);
            this.animationButton.Name = "animationButton";
            this.animationButton.Size = new System.Drawing.Size(247, 360);
            this.animationButton.TabIndex = 1;
            this.animationButton.Text = "Анимация";
            this.animationButton.UseVisualStyleBackColor = false;
            this.animationButton.Click += new System.EventHandler(this.animationButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.progressBarButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.animationButton, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(505, 366);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 366);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button progressBarButton;
        private System.Windows.Forms.Button animationButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

