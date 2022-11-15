namespace Pro100test{

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

        public void createUserBase(string pathway){

            char[] pathChar = pathway.ToCharArray();

            //takes user input path provided and makes sure it is good to use for file pathing to their steam games folder.

            string appendChars = "";

            foreach (char c in pathChar){

                if (c == '\''){

                    appendChars.Append<char>('\'');

                }
                
                if (c != ' '){

                    appendChars.Append<char>(c);

                }

            }

            foreach (string file in Directory.EnumerateFiles(appendChars)){

                int i = 0;

                char[] tempGameName = new char[100];

                string gameName = Path.GetFileName(appendChars);

                foreach (char c in gameName){

                    if(c != '\''){

                        tempGameName.Append<char>(c);
                    
                    }

                    i++;
                                       
                }

                listGames[i] = tempGameName.ToString();

            }


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
            this.textbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // isWorkinglbl
            // 
            this.isWorkinglbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.isWorkinglbl.AutoSize = true;
            this.isWorkinglbl.Location = new System.Drawing.Point(623, 9);
            this.isWorkinglbl.Name = "isWorkinglbl";
            this.isWorkinglbl.Size = new System.Drawing.Size(165, 25);
            this.isWorkinglbl.TabIndex = 0;
            this.isWorkinglbl.Text = "Project Has Loaded";
            // 
            // textbtn
            // 
            this.textbtn.Location = new System.Drawing.Point(336, 196);
            this.textbtn.Name = "textbtn";
            this.textbtn.Size = new System.Drawing.Size(112, 34);
            this.textbtn.TabIndex = 1;
            this.textbtn.Text = "TEST";
            this.textbtn.UseVisualStyleBackColor = true;
            this.textbtn.Click += new System.EventHandler(this.textbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textbtn);
            this.Controls.Add(this.isWorkinglbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label isWorkinglbl;

        private Button textbtn;
    }

}
