using System.Windows.Forms;

namespace MenuStripMenuBar
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
            this.MenuBar = new MenuStrip();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "menuBar";
            this.MenuBar.Size = new System.Drawing.Size(800, 28);
            this.MenuBar.Text = "Main Menu";
            this.MenuBar.AccessibleRole = AccessibleRole.MenuBar;
            this.MenuFile = new ToolStripMenuItem("&File");
            this.MenuFileNew = new ToolStripMenuItem();
            this.MenuFileNew.Text = "&New...";
            this.MenuFileNew.ShortcutKeys = Keys.Control | Keys.N;
            this.MenuFileOpen = new ToolStripMenuItem();
            this.MenuFileOpen.Text = "&Open...";
            this.MenuFileOpen.ShortcutKeys = Keys.Control | Keys.O;
            this.MenuFileSave = new ToolStripMenuItem();
            this.MenuFileSave.Text = "&Save";
            this.MenuFileSave.ShortcutKeys = Keys.Control | Keys.S;
            this.MenuFileSaveAs = new ToolStripMenuItem();
            this.MenuFileSaveAs.Text = "Save &As...";
            this.MenuFileSaveAs.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            this.MenuFileExit = new ToolStripMenuItem();
            this.MenuFileExit.Text = "E&xit";
            this.MenuFileExit.ShortcutKeys = Keys.Control | Keys.Q;
            this.MenuFileItems = new ToolStripMenuItem[] { this.MenuFileNew, this.MenuFileOpen, this.MenuFileSave, this.MenuFileSaveAs, this.MenuFileExit };
            this.MenuFile.DropDownItems.AddRange(this.MenuFileItems);
            this.MenuEdit = new ToolStripMenuItem("&Edit");
            this.MenuEditUndo = new ToolStripMenuItem();
            this.MenuEditUndo.Text = "&Undo";
            this.MenuEditUndo.ShortcutKeys = Keys.Control | Keys.Z;
            this.MenuEditCut = new ToolStripMenuItem();
            this.MenuEditCut.Text = "Cu&t";
            this.MenuEditCut.ShortcutKeys = Keys.Control | Keys.X;
            this.MenuEditCopy = new ToolStripMenuItem();
            this.MenuEditCopy.Text = "&Copy";
            this.MenuEditCopy.ShortcutKeys = Keys.Control | Keys.C;
            this.MenuEditPaste = new ToolStripMenuItem();
            this.MenuEditPaste.Text = "&Paste";
            this.MenuEditPaste.ShortcutKeys = Keys.Control | Keys.V;
            this.MenuEditItems = new ToolStripMenuItem[] { this.MenuEditUndo, this.MenuEditCut, this.MenuEditCopy, this.MenuEditPaste };
            this.MenuEdit.DropDownItems.AddRange(this.MenuEditItems);
            this.MenuView = new ToolStripMenuItem("&View");
            this.MenuViewFullScreen = new ToolStripMenuItem();
            this.MenuViewFullScreen.Text = "&Full Screen";
            this.MenuViewFullScreen.ShortcutKeys = Keys.F11;
            this.MenuViewFullScreen.Checked = false;
            this.MenuViewFullScreen.CheckOnClick = true;
            this.MenuViewShowStatusBar = new ToolStripMenuItem();
            this.MenuViewShowStatusBar.Text = "Show &Status bar";
            this.MenuViewShowStatusBar.Checked = true;
            this.MenuViewShowStatusBar.CheckOnClick = true;
            this.MenuViewItems = new ToolStripMenuItem[] { this.MenuViewFullScreen, this.MenuViewShowStatusBar };
            this.MenuView.DropDownItems.AddRange(this.MenuViewItems);
            this.MenuHelp = new ToolStripMenuItem("&Help");
            this.MenuHelpUserManual = new ToolStripMenuItem();
            this.MenuHelpUserManual.Text = "User &Manual";
            this.MenuHelpUserManual.ShortcutKeys = Keys.F1;
            this.MenuHelpAbout = new ToolStripMenuItem("&About...");
            this.MenuHelpItems = new ToolStripMenuItem[] { this.MenuHelpUserManual, this.MenuHelpAbout };
            this.MenuHelp.DropDownItems.AddRange(this.MenuHelpItems);
            this.MenuTopLevelItems = new ToolStripMenuItem[] { this.MenuFile, this.MenuEdit, this.MenuView, this.MenuHelp };
            this.MenuBar.Items.AddRange(this.MenuTopLevelItems);
            // Edit box and Button
            this.UserTextLabel = new Label();
            this.UserTextLabel.Text = "Input &Text: ";
            this.UserTextLabel.AutoSize = true;
            this.UserTextLabel.Anchor = AnchorStyles.Left;
            this.UserTextLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.UserText = new TextBox();
            this.UserText.Focus();
            this.Yell = new Button();
            this.Yell.Text = "&Yell!";
            this.Yell.Click += (_, _) => this.UserText.Text = this.UserText.Text.ToUpper();
            // MainPanel
            this.MainPanel = new FlowLayoutPanel();
            this.MainPanel.SuspendLayout();
            this.MainPanel.FlowDirection = FlowDirection.TopDown;
            this.MainPanel.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(this.UserTextLabel);
            this.MainPanel.Controls.Add(this.UserText);
            this.MainPanel.Controls.Add(this.Yell);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.AccessibleRole = AccessibleRole.Application;
            this.Controls.Add(this.MenuBar);
            this.Controls.Add(this.MainPanel);
            this.MainMenuStrip = this.MenuBar;
            this.Name = "Form1";
            this.Text = "Newer Menu Bar Example";
            this.MainPanel.ResumeLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private MenuStrip MenuBar;
        private ToolStripMenuItem MenuFile;
        private ToolStripMenuItem MenuFileNew;
        private ToolStripMenuItem MenuFileOpen;
        private ToolStripMenuItem MenuFileSave;
        private ToolStripMenuItem MenuFileSaveAs;
        private ToolStripMenuItem MenuFileExit;
        private ToolStripMenuItem[] MenuFileItems;
        private ToolStripMenuItem MenuEdit;
        private ToolStripMenuItem MenuEditUndo;
        private ToolStripMenuItem MenuEditCut;
        private ToolStripMenuItem MenuEditCopy;
        private ToolStripMenuItem MenuEditPaste;
        private ToolStripMenuItem[] MenuEditItems;
        private ToolStripMenuItem MenuView;
        private ToolStripMenuItem MenuViewFullScreen;
        private ToolStripMenuItem MenuViewShowStatusBar;
        private ToolStripMenuItem[] MenuViewItems;
        private ToolStripMenuItem MenuHelp;
        private ToolStripMenuItem MenuHelpUserManual;
        private ToolStripMenuItem MenuHelpAbout;
        private ToolStripMenuItem[] MenuHelpItems;
        private ToolStripMenuItem[] MenuTopLevelItems;
        private FlowLayoutPanel MainPanel;
        private Label UserTextLabel;
        private TextBox UserText;
        private Button Yell;





    }
}
