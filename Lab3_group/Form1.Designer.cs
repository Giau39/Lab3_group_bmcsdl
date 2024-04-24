
namespace Lab3_group
{
	partial class Form1
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTK = new System.Windows.Forms.TextBox();
			this.txtMK = new System.Windows.Forms.TextBox();
			this.btnDangNhap = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.eye = new System.Windows.Forms.Button();
			this.eyeslash = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(219, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(193, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "ĐĂNG NHẬP TÀI KHOẢN";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(119, 122);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "TÀI KHOẢN";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(119, 209);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(91, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "MẬT KHẨU";
			// 
			// txtTK
			// 
			this.txtTK.Location = new System.Drawing.Point(254, 122);
			this.txtTK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtTK.Name = "txtTK";
			this.txtTK.Size = new System.Drawing.Size(266, 26);
			this.txtTK.TabIndex = 3;
			// 
			// txtMK
			// 
			this.txtMK.Location = new System.Drawing.Point(254, 209);
			this.txtMK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtMK.Name = "txtMK";
			this.txtMK.Size = new System.Drawing.Size(266, 26);
			this.txtMK.TabIndex = 4;
			this.txtMK.UseSystemPasswordChar = true;
			// 
			// btnDangNhap
			// 
			this.btnDangNhap.Location = new System.Drawing.Point(105, 285);
			this.btnDangNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnDangNhap.Name = "btnDangNhap";
			this.btnDangNhap.Size = new System.Drawing.Size(152, 66);
			this.btnDangNhap.TabIndex = 5;
			this.btnDangNhap.Text = "ĐĂNG NHẬP";
			this.btnDangNhap.UseVisualStyleBackColor = true;
			this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(375, 285);
			this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(152, 66);
			this.btnThoat.TabIndex = 6;
			this.btnThoat.Text = "THOÁT";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// eye
			// 
			this.eye.BackColor = System.Drawing.SystemColors.Control;
			this.eye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.eye.ForeColor = System.Drawing.Color.White;
			this.eye.Location = new System.Drawing.Point(488, 211);
			this.eye.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.eye.Name = "eye";
			this.eye.Size = new System.Drawing.Size(29, 25);
			this.eye.TabIndex = 25;
			this.eye.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.eye.UseVisualStyleBackColor = false;
			this.eye.Click += new System.EventHandler(this.eye_Click);
			// 
			// eyeslash
			// 
			this.eyeslash.BackColor = System.Drawing.SystemColors.Control;
			this.eyeslash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.eyeslash.ForeColor = System.Drawing.Color.White;
			this.eyeslash.Location = new System.Drawing.Point(489, 211);
			this.eyeslash.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.eyeslash.Name = "eyeslash";
			this.eyeslash.Size = new System.Drawing.Size(29, 25);
			this.eyeslash.TabIndex = 26;
			this.eyeslash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.eyeslash.UseVisualStyleBackColor = false;
			this.eyeslash.Click += new System.EventHandler(this.eyeslash_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(618, 406);
			this.Controls.Add(this.eye);
			this.Controls.Add(this.eyeslash);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnDangNhap);
			this.Controls.Add(this.txtMK);
			this.Controls.Add(this.txtTK);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Đăng Nhập SQL";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTK;
		private System.Windows.Forms.TextBox txtMK;
		private System.Windows.Forms.Button btnDangNhap;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button eye;
		private System.Windows.Forms.Button eyeslash;
	}
}

