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

        public string SteamInitialize(){ 

            //Create a new Steam instance or to connect to existing whether in process or local

            SteamKit2.SteamClient client = new SteamKit2.SteamClient();

            SteamKit2.SteamID steamID = new SteamKit2.SteamID();

            //long personalID = 76561198849685240; //idon'tkare
            long personalID = 76561198119487169; //gotagetfood

            steamID.Set((uint)personalID,SteamKit2.EUniverse.Public,SteamKit2.EAccountType.Individual);

            client.Connect();

            //A way to access information about individual users and interact with steams overlay

            SteamKit2.SteamFriends friendsInfo;

            //Lets you access and manipulate Steam user data

            SteamKit2.SteamUser.LogOnDetails logOnDetails = new SteamKit2.SteamUser.LogOnDetails();

            //If it works it gets the userID for Steam

            string userId;

            //userId = client.SteamID.ToString();

            return steamID.ToString(); // = (logOnDetails.AccountID).ToString();

        }



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
