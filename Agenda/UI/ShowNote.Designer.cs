
namespace UI
{
    partial class ShowNote
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_content = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_noteTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_title.Location = new System.Drawing.Point(20, 15);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(66, 29);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Title";
            // 
            // lbl_content
            // 
            this.lbl_content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_content.Location = new System.Drawing.Point(20, 60);
            this.lbl_content.Name = "lbl_content";
            this.lbl_content.Size = new System.Drawing.Size(499, 116);
            this.lbl_content.TabIndex = 1;
            this.lbl_content.Text = "Content";
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(404, 187);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(115, 37);
            this.btn_edit.TabIndex = 3;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(22, 187);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(19, 17);
            this.lbl_id.TabIndex = 4;
            this.lbl_id.Text = "id";
            // 
            // lbl_noteTime
            // 
            this.lbl_noteTime.AutoSize = true;
            this.lbl_noteTime.Location = new System.Drawing.Point(342, 26);
            this.lbl_noteTime.Name = "lbl_noteTime";
            this.lbl_noteTime.Size = new System.Drawing.Size(46, 17);
            this.lbl_noteTime.TabIndex = 5;
            this.lbl_noteTime.Text = "label1";
            // 
            // ShowNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_noteTime);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.lbl_content);
            this.Controls.Add(this.lbl_title);
            this.Name = "ShowNote";
            this.Size = new System.Drawing.Size(535, 258);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_title;
        public System.Windows.Forms.Label lbl_content;
        public System.Windows.Forms.Button btn_edit;
        public System.Windows.Forms.Label lbl_id;
        public System.Windows.Forms.Label lbl_noteTime;
    }
}
