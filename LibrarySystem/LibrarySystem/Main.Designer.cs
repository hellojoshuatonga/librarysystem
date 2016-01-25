namespace LibrarySystem
{
    partial class Main
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
            this.borrowBooksTile = new MetroFramework.Controls.MetroTile();
            this.returnBooksTile = new MetroFramework.Controls.MetroTile();
            this.manageTile = new MetroFramework.Controls.MetroTile();
            this.detailTabs = new MetroFramework.Controls.MetroTabControl();
            this.availableBooksTab = new MetroFramework.Controls.MetroTabPage();
            this.borrowedBooks = new MetroFramework.Controls.MetroTabPage();
            this.detailTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // borrowBooksTile
            // 
            this.borrowBooksTile.ActiveControl = null;
            this.borrowBooksTile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.borrowBooksTile.Location = new System.Drawing.Point(102, 81);
            this.borrowBooksTile.Name = "borrowBooksTile";
            this.borrowBooksTile.Size = new System.Drawing.Size(127, 67);
            this.borrowBooksTile.TabIndex = 2;
            this.borrowBooksTile.Text = "Borrow Books";
            this.borrowBooksTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.borrowBooksTile.UseSelectable = true;
            // 
            // returnBooksTile
            // 
            this.returnBooksTile.ActiveControl = null;
            this.returnBooksTile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.returnBooksTile.Location = new System.Drawing.Point(266, 81);
            this.returnBooksTile.Name = "returnBooksTile";
            this.returnBooksTile.Size = new System.Drawing.Size(127, 67);
            this.returnBooksTile.TabIndex = 3;
            this.returnBooksTile.Text = "Return Books";
            this.returnBooksTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.returnBooksTile.UseSelectable = true;
            // 
            // manageTile
            // 
            this.manageTile.ActiveControl = null;
            this.manageTile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.manageTile.Location = new System.Drawing.Point(430, 81);
            this.manageTile.Name = "manageTile";
            this.manageTile.Size = new System.Drawing.Size(127, 67);
            this.manageTile.TabIndex = 4;
            this.manageTile.Text = "Manage";
            this.manageTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.manageTile.UseSelectable = true;
            // 
            // detailTabs
            // 
            this.detailTabs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailTabs.Controls.Add(this.availableBooksTab);
            this.detailTabs.Controls.Add(this.borrowedBooks);
            this.detailTabs.Location = new System.Drawing.Point(102, 178);
            this.detailTabs.Name = "detailTabs";
            this.detailTabs.SelectedIndex = 0;
            this.detailTabs.Size = new System.Drawing.Size(455, 282);
            this.detailTabs.TabIndex = 5;
            this.detailTabs.UseSelectable = true;
            // 
            // availableBooksTab
            // 
            this.availableBooksTab.HorizontalScrollbarBarColor = true;
            this.availableBooksTab.HorizontalScrollbarHighlightOnWheel = false;
            this.availableBooksTab.HorizontalScrollbarSize = 10;
            this.availableBooksTab.Location = new System.Drawing.Point(4, 38);
            this.availableBooksTab.Name = "availableBooksTab";
            this.availableBooksTab.Size = new System.Drawing.Size(447, 240);
            this.availableBooksTab.TabIndex = 0;
            this.availableBooksTab.Text = "Available Books";
            this.availableBooksTab.VerticalScrollbarBarColor = true;
            this.availableBooksTab.VerticalScrollbarHighlightOnWheel = false;
            this.availableBooksTab.VerticalScrollbarSize = 10;
            // 
            // borrowedBooks
            // 
            this.borrowedBooks.HorizontalScrollbarBarColor = true;
            this.borrowedBooks.HorizontalScrollbarHighlightOnWheel = false;
            this.borrowedBooks.HorizontalScrollbarSize = 10;
            this.borrowedBooks.Location = new System.Drawing.Point(4, 38);
            this.borrowedBooks.Name = "borrowedBooks";
            this.borrowedBooks.Size = new System.Drawing.Size(447, 206);
            this.borrowedBooks.TabIndex = 1;
            this.borrowedBooks.Text = "Borrowed Books";
            this.borrowedBooks.VerticalScrollbarBarColor = true;
            this.borrowedBooks.VerticalScrollbarHighlightOnWheel = false;
            this.borrowedBooks.VerticalScrollbarSize = 10;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 503);
            this.Controls.Add(this.detailTabs);
            this.Controls.Add(this.manageTile);
            this.Controls.Add(this.returnBooksTile);
            this.Controls.Add(this.borrowBooksTile);
            this.Name = "Main";
            this.Text = "Library";
            this.detailTabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile borrowBooksTile;
        private MetroFramework.Controls.MetroTile returnBooksTile;
        private MetroFramework.Controls.MetroTile manageTile;
        private MetroFramework.Controls.MetroTabControl detailTabs;
        private MetroFramework.Controls.MetroTabPage availableBooksTab;
        private MetroFramework.Controls.MetroTabPage borrowedBooks;
    }
}