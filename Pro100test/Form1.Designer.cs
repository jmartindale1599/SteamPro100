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

            long personalID = 76561198849685240;

            steamID.Set((uint)personalID,SteamKit2.EUniverse.Public,SteamKit2.EAccountType.ContentServer);

            client.Connect();

            //A way to access information about individual users and interact with steams overlay

            SteamKit2.SteamFriends friendsInfo;

            //Lets you access and manipulate Steam user data

            SteamKit2.SteamUser.LogOnDetails logOnDetails = new SteamKit2.SteamUser.LogOnDetails();

            //If it works it gets the userID for Steam

            string userId;

            userId = client.SteamID.ToString();

            return userId; //= (logOnDetails.AccountID).ToString();
            
            

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
