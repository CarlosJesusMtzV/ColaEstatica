namespace ColaEstatica
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
            btnEnqueue = new Button();
            btnDequeue = new Button();
            btnPeekCola = new Button();
            txtValor = new TextBox();
            lstCola = new ListBox();
            SuspendLayout();
            // 
            // btnEnqueue
            // 
            btnEnqueue.BackColor = SystemColors.InactiveCaption;
            btnEnqueue.Location = new Point(367, 65);
            btnEnqueue.Name = "btnEnqueue";
            btnEnqueue.Size = new Size(117, 54);
            btnEnqueue.TabIndex = 0;
            btnEnqueue.Text = "Enqueue";
            btnEnqueue.UseVisualStyleBackColor = false;
            btnEnqueue.Click += btnEnqueue_Click;
            // 
            // btnDequeue
            // 
            btnDequeue.BackColor = SystemColors.InactiveCaption;
            btnDequeue.Location = new Point(367, 150);
            btnDequeue.Name = "btnDequeue";
            btnDequeue.Size = new Size(117, 54);
            btnDequeue.TabIndex = 1;
            btnDequeue.Text = "Dequeue";
            btnDequeue.UseVisualStyleBackColor = false;
            btnDequeue.Click += btnDequeue_Click;
            // 
            // btnPeekCola
            // 
            btnPeekCola.BackColor = SystemColors.InactiveCaption;
            btnPeekCola.Location = new Point(367, 231);
            btnPeekCola.Name = "btnPeekCola";
            btnPeekCola.Size = new Size(117, 54);
            btnPeekCola.TabIndex = 2;
            btnPeekCola.Text = "PeekCola";
            btnPeekCola.UseVisualStyleBackColor = false;
            btnPeekCola.Click += btnPeekCola_Click;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(23, 65);
            txtValor.Multiline = true;
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(144, 43);
            txtValor.TabIndex = 3;
            // 
            // lstCola
            // 
            lstCola.FormattingEnabled = true;
            lstCola.Location = new Point(30, 165);
            lstCola.Name = "lstCola";
            lstCola.Size = new Size(221, 124);
            lstCola.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(lstCola);
            Controls.Add(txtValor);
            Controls.Add(btnPeekCola);
            Controls.Add(btnDequeue);
            Controls.Add(btnEnqueue);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnqueue;
        private Button btnDequeue;
        private Button btnPeekCola;
        private TextBox txtValor;
        private ListBox lstCola;
    }
}
