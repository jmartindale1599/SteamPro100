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

        public void Initialize(){ 

            //Create a new Steam instance or to connect to existing whether in process or local
        
            SteamKit2.SteamClient client = new SteamKit2.SteamClient();

            //A way to access information about individual users and interact with steams overlay

            SteamKit2.SteamFriends friendsInfo;

            //Lets you access and manipulate Steam user data

            SteamKit2.SteamUser.LogOnDetails logOnDetails = new SteamKit2.SteamUser.LogOnDetails();

            //If it works it gets the userID for Steam

            string userId = (logOnDetails.AccountID).ToString();
            
            

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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
        }

        #endregion
    }

}
