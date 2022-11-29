namespace Pro100test
{

    partial class Form1{

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        string[] listGames = new string[300];

        /// <summary>
        /// if the method below works as intended it should go to the filepath provided by the user and get the name of all the files in the folder linked to
        /// make sure to ask for where they can input the filepath for their steam library
        /// </summary>
        /// <param name="pathway"></param>
         
        public void spitOutGames(){

            for (int i = 0; i < listGames.Length; i++){ 
            
                isWorkinglbl.Text += listGames[i] + " ";
            
            }
                
        }

        public void createUserBase(string pathway){

            //string hardCode = @"C:\Program Files (x86)\Steam\New folder\steamapps\common";

            //string test = @"C:\Users\jmartindale\source\repos\Pro100test\Pro100test";

            string userinput = pathway;

            FolderBrowserDialog pathFinder = new FolderBrowserDialog();

            if (pathFinder.ShowDialog() == System.Windows.Forms.DialogResult.OK){ 
            
                userinput = pathFinder.SelectedPath;
            
                txtPath.Text = userinput;

                DirectoryInfo dInfo = new DirectoryInfo(userinput);

                FileInfo[] files = dInfo.GetFiles();

                List<String> fileNames = new List<String>();

                int e = 0;

                foreach (FileInfo file in files){

                    listGames[e] = file.Name;

                    e++;

                }

            }

            spitOutGames();

        }

        protected override void Dispose(bool disposing){

            if (disposing && (components != null)){

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
            this.isWorkinglbl = new System.Windows.Forms.Label();
            this.btnFindGames = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listGamesbox = new System.Windows.Forms.ListBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // isWorkinglbl
            // 
            this.isWorkinglbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.isWorkinglbl.AutoSize = true;
            this.isWorkinglbl.Location = new System.Drawing.Point(597, 6);
            this.isWorkinglbl.Name = "isWorkinglbl";
            this.isWorkinglbl.Size = new System.Drawing.Size(165, 25);
            this.isWorkinglbl.TabIndex = 0;
            this.isWorkinglbl.Text = "Project Has Loaded";
            // 
            // btnFindGames
            // 
            this.btnFindGames.Location = new System.Drawing.Point(6, 43);
            this.btnFindGames.Name = "btnFindGames";
            this.btnFindGames.Size = new System.Drawing.Size(189, 54);
            this.btnFindGames.TabIndex = 1;
            this.btnFindGames.Text = "Find Games";
            this.btnFindGames.UseVisualStyleBackColor = true;
            this.btnFindGames.Click += new System.EventHandler(this.textbtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listGamesbox);
            this.tabPage1.Controls.Add(this.txtPath);
            this.tabPage1.Controls.Add(this.btnFindGames);
            this.tabPage1.Controls.Add(this.isWorkinglbl);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 388);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listGamesbox
            // 
            this.listGamesbox.FormattingEnabled = true;
            this.listGamesbox.ItemHeight = 25;
            this.listGamesbox.Location = new System.Drawing.Point(212, 57);
            this.listGamesbox.Name = "listGamesbox";
            this.listGamesbox.Size = new System.Drawing.Size(518, 304);
            this.listGamesbox.TabIndex = 3;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(6, 6);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(280, 31);
            this.txtPath.TabIndex = 2;
            this.txtPath.Text = "File Path";
            this.txtPath.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 388);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label isWorkinglbl;
        private Button btnFindGames;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox txtPath;
        private TabPage tabPage2;
        private ListBox listGamesbox;
    }

}
