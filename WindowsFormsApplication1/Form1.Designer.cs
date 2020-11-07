namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Collections.Generic.List<Data> list = new System.Collections.Generic.List<Data>();
        private System.Collections.Generic.List<Actiuni> list_actiuni = new System.Collections.Generic.List<Actiuni>();
        private System.Collections.Generic.List<Salt> list_salt = new System.Collections.Generic.List<Salt>();

        private string result = "";
        private bool r = false;
        private bool d = false;
        private int nr = 1;
        private int ct = 0;
        private string text = "";
        private static string path = Defines.initial_path;

        private int count = 0;
        private string stiva = "0 ";
        private string input = "&";

        private System.Windows.Forms.OpenFileDialog file = new System.Windows.Forms.OpenFileDialog();
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
            this.lStiva = new System.Windows.Forms.Label();
            this.lCuv_Intrare = new System.Windows.Forms.Label();
            this.lActiune = new System.Windows.Forms.Label();
            this.tStack = new System.Windows.Forms.TextBox();
            this.tString_Input = new System.Windows.Forms.TextBox();
            this.tActiune = new System.Windows.Forms.TextBox();
            this.lProductii = new System.Windows.Forms.Label();
            this.tProd = new System.Windows.Forms.TextBox();
            this.tInput = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.lIntrare = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnGramatica = new System.Windows.Forms.Button();
            this.tBrowse = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lStiva
            // 
            this.lStiva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lStiva.AutoSize = true;
            this.lStiva.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStiva.Location = new System.Drawing.Point(247, 23);
            this.lStiva.Name = "lStiva";
            this.lStiva.Size = new System.Drawing.Size(62, 27);
            this.lStiva.TabIndex = 14;
            this.lStiva.Text = "Stivă";
            // 
            // lCuv_Intrare
            // 
            this.lCuv_Intrare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lCuv_Intrare.AutoSize = true;
            this.lCuv_Intrare.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCuv_Intrare.Location = new System.Drawing.Point(400, -1);
            this.lCuv_Intrare.Name = "lCuv_Intrare";
            this.lCuv_Intrare.Size = new System.Drawing.Size(114, 54);
            this.lCuv_Intrare.TabIndex = 15;
            this.lCuv_Intrare.Text = "Cuvânt de\r\n   intrare\r\n";
            // 
            // lActiune
            // 
            this.lActiune.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lActiune.AutoSize = true;
            this.lActiune.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lActiune.Location = new System.Drawing.Point(591, -1);
            this.lActiune.Name = "lActiune";
            this.lActiune.Size = new System.Drawing.Size(101, 54);
            this.lActiune.TabIndex = 16;
            this.lActiune.Text = " Acțiune \r\nrezultată";
            // 
            // tStack
            // 
            this.tStack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tStack.BackColor = System.Drawing.Color.LightCyan;
            this.tStack.Location = new System.Drawing.Point(193, 53);
            this.tStack.Multiline = true;
            this.tStack.Name = "tStack";
            this.tStack.ReadOnly = true;
            this.tStack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tStack.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tStack.Size = new System.Drawing.Size(174, 308);
            this.tStack.TabIndex = 18;
            // 
            // tString_Input
            // 
            this.tString_Input.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tString_Input.BackColor = System.Drawing.Color.LightCyan;
            this.tString_Input.Location = new System.Drawing.Point(373, 53);
            this.tString_Input.Multiline = true;
            this.tString_Input.Name = "tString_Input";
            this.tString_Input.ReadOnly = true;
            this.tString_Input.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tString_Input.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tString_Input.Size = new System.Drawing.Size(174, 308);
            this.tString_Input.TabIndex = 19;
            // 
            // tActiune
            // 
            this.tActiune.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tActiune.BackColor = System.Drawing.Color.LightCyan;
            this.tActiune.Location = new System.Drawing.Point(553, 54);
            this.tActiune.Multiline = true;
            this.tActiune.Name = "tActiune";
            this.tActiune.ReadOnly = true;
            this.tActiune.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tActiune.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tActiune.Size = new System.Drawing.Size(174, 308);
            this.tActiune.TabIndex = 20;
            // 
            // lProductii
            // 
            this.lProductii.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lProductii.AutoSize = true;
            this.lProductii.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProductii.Location = new System.Drawing.Point(52, 23);
            this.lProductii.Name = "lProductii";
            this.lProductii.Size = new System.Drawing.Size(100, 27);
            this.lProductii.TabIndex = 23;
            this.lProductii.Text = "Producții";
            // 
            // tProd
            // 
            this.tProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tProd.BackColor = System.Drawing.Color.LightCyan;
            this.tProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tProd.Location = new System.Drawing.Point(13, 53);
            this.tProd.Multiline = true;
            this.tProd.Name = "tProd";
            this.tProd.ReadOnly = true;
            this.tProd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tProd.Size = new System.Drawing.Size(174, 308);
            this.tProd.TabIndex = 24;
            // 
            // tInput
            // 
            this.tInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tInput.Location = new System.Drawing.Point(741, 54);
            this.tInput.Name = "tInput";
            this.tInput.Size = new System.Drawing.Size(123, 22);
            this.tInput.TabIndex = 13;
            // 
            // btnTest
            // 
            this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTest.BackColor = System.Drawing.Color.Lavender;
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(741, 84);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(123, 31);
            this.btnTest.TabIndex = 17;
            this.btnTest.Text = "Testează";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lIntrare
            // 
            this.lIntrare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lIntrare.AutoSize = true;
            this.lIntrare.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIntrare.Location = new System.Drawing.Point(758, 23);
            this.lIntrare.Name = "lIntrare";
            this.lIntrare.Size = new System.Drawing.Size(80, 27);
            this.lIntrare.TabIndex = 21;
            this.lIntrare.Text = "Intrare";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Lavender;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(741, 316);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 31);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Ieșire";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.Lavender;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(741, 121);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(123, 31);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Șterge";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnGramatica
            // 
            this.btnGramatica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGramatica.BackColor = System.Drawing.Color.Lavender;
            this.btnGramatica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGramatica.Location = new System.Drawing.Point(741, 158);
            this.btnGramatica.Name = "btnGramatica";
            this.btnGramatica.Size = new System.Drawing.Size(123, 31);
            this.btnGramatica.TabIndex = 26;
            this.btnGramatica.Text = "Gramatică";
            this.btnGramatica.UseVisualStyleBackColor = false;
            this.btnGramatica.Click += new System.EventHandler(this.btnGramatica_Click);
            // 
            // tBrowse
            // 
            this.tBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tBrowse.Location = new System.Drawing.Point(741, 195);
            this.tBrowse.Name = "tBrowse";
            this.tBrowse.Size = new System.Drawing.Size(123, 22);
            this.tBrowse.TabIndex = 27;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.Lavender;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(741, 222);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(123, 31);
            this.btnEdit.TabIndex = 28;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(871, 374);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.tBrowse);
            this.Controls.Add(this.btnGramatica);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tProd);
            this.Controls.Add(this.lProductii);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lIntrare);
            this.Controls.Add(this.tActiune);
            this.Controls.Add(this.tString_Input);
            this.Controls.Add(this.tStack);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.lActiune);
            this.Controls.Add(this.lCuv_Intrare);
            this.Controls.Add(this.lStiva);
            this.Controls.Add(this.tInput);
            this.MinimumSize = new System.Drawing.Size(889, 421);
            this.Name = "Form1";
            this.Text = "Automat Push Down";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lStiva;
        private System.Windows.Forms.Label lCuv_Intrare;
        private System.Windows.Forms.Label lActiune;
        private System.Windows.Forms.TextBox tStack;
        private System.Windows.Forms.TextBox tString_Input;
        private System.Windows.Forms.TextBox tActiune;
        private System.Windows.Forms.Label lProductii;
        private System.Windows.Forms.TextBox tProd;
        private System.Windows.Forms.TextBox tInput;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label lIntrare;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnGramatica;
        private System.Windows.Forms.TextBox tBrowse;
        private System.Windows.Forms.Button btnEdit;
    }
}

