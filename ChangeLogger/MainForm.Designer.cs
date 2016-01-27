namespace ChangeLogger
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		private System.Windows.Forms.Panel PanelDetails;
		private System.Windows.Forms.ToolStrip ToolstripDetails;
		private System.Windows.Forms.ToolStripButton ToolstripButtonDetailsSave;
		private System.Windows.Forms.ToolStripButton ToolstripButtonDetailsClear;
		private System.Windows.Forms.ToolStripSeparator ToolstripSeperatorDetails;
		private System.Windows.Forms.ToolStripButton ToolstripButtonDetailsAutofill;

		private System.Windows.Forms.Label LabelDetailsYear;
		private System.Windows.Forms.TextBox TextboxDetailsYear;
		private System.Windows.Forms.Label LabelDetailsMonth;
		private System.Windows.Forms.TextBox TextboxDetailsMonth;
		private System.Windows.Forms.Label LabelDetailsDay;
		private System.Windows.Forms.TextBox TextboxDetailsDay;
		private System.Windows.Forms.Label LabelDetailsTime;
		private System.Windows.Forms.TextBox TextboxDetailsTime;
		private System.Windows.Forms.Label LabelDetailsAuthor;
		private System.Windows.Forms.TextBox TextboxDetailsAuthor;
		private System.Windows.Forms.Label LabelDetailsReference;
		private System.Windows.Forms.TextBox TextboxDetailsReference;
		private System.Windows.Forms.Label LabelDetailsReplied;
		private System.Windows.Forms.TextBox TextboxDetailsReplied;
		private System.Windows.Forms.Label LabelDetailsBugLink;
		private System.Windows.Forms.TextBox TextboxDetailsBugLink;
		private System.Windows.Forms.Label LabelDetailsCategory;
		private System.Windows.Forms.TextBox TextboxDetailsCategory;
		private System.Windows.Forms.Label LabelDetailsChange;
		private System.Windows.Forms.TextBox TextboxDetailsChange;
		private System.Windows.Forms.Label LabelDetailsDescription;
		private System.Windows.Forms.TextBox TextboxDetailsDescription;
		private System.Windows.Forms.Label LabelDetailsComment;
		private System.Windows.Forms.TextBox TextboxDetailsComment;
		
		private System.Windows.Forms.Panel PanelList;
		private System.Windows.Forms.ToolStrip ToolstripList;
		private System.Windows.Forms.ToolStripButton ToolstripButtonListRoot;
		private System.Windows.Forms.ToolStripButton ToolstripButtonListSolution;
		private System.Windows.Forms.ToolStripButton ToolstripButtonListProgram;
		private System.Windows.Forms.ToolStripButton ToolstripButtonListVersion;
		private System.Windows.Forms.ToolStripSeparator ToolstripSeperatorList;
		private System.Windows.Forms.ToolStripButton ToolstripButtonListEntryAdd;
		private System.Windows.Forms.ToolStripButton ToolstripButtonListExport;

		private System.Windows.Forms.ListView ListviewListEntries;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.ToolstripDetails = new System.Windows.Forms.ToolStrip();
    		this.ToolstripButtonDetailsSave = new System.Windows.Forms.ToolStripButton();
    		this.ToolstripButtonDetailsClear = new System.Windows.Forms.ToolStripButton();
    		this.ToolstripSeperatorDetails = new System.Windows.Forms.ToolStripSeparator();
    		this.ToolstripButtonDetailsAutofill = new System.Windows.Forms.ToolStripButton();

    		this.LabelDetailsYear = new System.Windows.Forms.Label();
    		this.TextboxDetailsYear = new System.Windows.Forms.TextBox();
    		this.LabelDetailsMonth = new System.Windows.Forms.Label();
    		this.TextboxDetailsMonth = new System.Windows.Forms.TextBox();
    		this.LabelDetailsDay = new System.Windows.Forms.Label();
    		this.TextboxDetailsDay = new System.Windows.Forms.TextBox();
    		this.LabelDetailsTime = new System.Windows.Forms.Label();
    		this.TextboxDetailsTime = new System.Windows.Forms.TextBox();
    		this.LabelDetailsAuthor = new System.Windows.Forms.Label();
    		this.TextboxDetailsAuthor = new System.Windows.Forms.TextBox();
    		this.LabelDetailsReference = new System.Windows.Forms.Label();
    		this.TextboxDetailsReference = new System.Windows.Forms.TextBox();
    		this.LabelDetailsReplied = new System.Windows.Forms.Label();
    		this.TextboxDetailsReplied = new System.Windows.Forms.TextBox();
    		this.LabelDetailsBugLink = new System.Windows.Forms.Label();
    		this.TextboxDetailsBugLink = new System.Windows.Forms.TextBox();
    		this.LabelDetailsCategory = new System.Windows.Forms.Label();
    		this.TextboxDetailsCategory = new System.Windows.Forms.TextBox();
    		this.LabelDetailsChange = new System.Windows.Forms.Label();
    		this.TextboxDetailsChange = new System.Windows.Forms.TextBox();
    		this.LabelDetailsDescription = new System.Windows.Forms.Label();
    		this.TextboxDetailsDescription = new System.Windows.Forms.TextBox();
    		this.LabelDetailsComment = new System.Windows.Forms.Label();
    		this.TextboxDetailsComment = new System.Windows.Forms.TextBox();
			
    		this.PanelList = new System.Windows.Forms.Panel();
    		this.ToolstripList = new System.Windows.Forms.ToolStrip();
    		this.ToolstripButtonListRoot = new System.Windows.Forms.ToolStripButton();
    		this.ToolstripButtonListSolution = new System.Windows.Forms.ToolStripButton();
    		this.ToolstripButtonListProgram = new System.Windows.Forms.ToolStripButton();
    		this.ToolstripButtonListVersion = new System.Windows.Forms.ToolStripButton();
    		this.ToolstripSeperatorList = new System.Windows.Forms.ToolStripSeparator();
    		this.ToolstripButtonListEntryAdd = new System.Windows.Forms.ToolStripButton();
    		this.ToolstripButtonListExport = new System.Windows.Forms.ToolStripButton();

    		this.ListviewListEntries = new System.Windows.Forms.ListView();
			this.SuspendLayout();
			// 
			// MainForm
			// 
			this.AutoSize = false;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
			this.Location = (new System.Drawing.Point(320, 274));
			this.Name = "FormMain";
			this.ShowInTaskbar = true;
			this.Size = new System.Drawing.Size(640, 480);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ChangeLogger - Alpha version - Changelog tool for GSoft";
			this.Resize += new System.EventHandler(this.This_Resize);
			//
			// PanelDetails
			//
			this.PanelDetails = new System.Windows.Forms.Panel();
			this.PanelDetails.AutoSize = false;
			this.PanelDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.PanelDetails.Location = new System.Drawing.Point(0, 0);
			this.PanelDetails.Name = "PanelDetails";
			this.PanelDetails.Size = new System.Drawing.Size((this.ClientSize.Width / 3) * 2, this.ClientSize.Height);
			this.Controls.Add(this.PanelDetails);
			//
			// ToolstripDetails
			//
			this.ToolstripDetails.AutoSize = false;
			this.ToolstripDetails.Location = new System.Drawing.Point(0, 0);
			this.ToolstripDetails.Name = "ToolstripDetails";
			this.ToolstripDetails.Size = new System.Drawing.Size(PanelDetails.ClientSize.Width, 24);
			this.PanelDetails.Controls.Add(this.ToolstripDetails);
            // ToolstripButtonDetailsSave
            this.ToolstripButtonDetailsSave.AutoSize = true;
            this.ToolstripButtonDetailsSave.Name = "ToolstripButtonDetailsSave";
            this.ToolstripButtonDetailsSave.Text = "Save";
            this.ToolstripButtonDetailsSave.Click += new System.EventHandler(this.ToolstripButtonDetailsSave_Click);
            this.ToolstripDetails.Items.Add(this.ToolstripButtonDetailsSave);
            // ToolstripButtonDetailsClear
            this.ToolstripButtonDetailsClear.AutoSize = true;
            this.ToolstripButtonDetailsClear.Name = "ToolstripButtonDetailsClear";
            this.ToolstripButtonDetailsClear.Text = "Clear";
            this.ToolstripButtonDetailsClear.Click += new System.EventHandler(ToolstripButtonDetailsClear_Click);
            this.ToolstripDetails.Items.Add(this.ToolstripButtonDetailsClear);
            // ToolstripSeperatorDetails
            this.ToolstripSeperatorDetails.Name = "ToolstripSeperatorDetails";
            this.ToolstripDetails.Items.Add(this.ToolstripSeperatorDetails);
            // ToolstripButtonDetailsAutofill
            this.ToolstripButtonDetailsAutofill.AutoSize = true;
            this.ToolstripButtonDetailsAutofill.Name = "ToolstripButtonDetailsAutofill";
            this.ToolstripButtonDetailsAutofill.Text = "Auto-Fill";
            this.ToolstripButtonDetailsAutofill.Click += new System.EventHandler(ToolstripButtonDetailsAutofill_Click);
            this.ToolstripDetails.Items.Add(this.ToolstripButtonDetailsAutofill);
            // LabelDetailsYear
            this.LabelDetailsYear.AutoSize = true;
            this.LabelDetailsYear.Location = new System.Drawing.Point(3, ToolstripDetails.Height + 3);
            this.LabelDetailsYear.Name = "LabelDetailsYear";
            this.LabelDetailsYear.Text = "Year";
            this.PanelDetails.Controls.Add(this.LabelDetailsYear);
            // TextboxDetailsYear
            this.TextboxDetailsYear.Location = new System.Drawing.Point(LabelDetailsYear.Location.X, LabelDetailsYear.Location.Y + LabelDetailsYear.Height + 1);
            this.TextboxDetailsYear.Name = "TextboxDetailsYear";
            this.TextboxDetailsYear.Size = new System.Drawing.Size((PanelDetails.ClientSize.Width - 15) / 4, 24);
            this.PanelDetails.Controls.Add(this.TextboxDetailsYear);
            // LabelDetailsMonth
            this.LabelDetailsMonth.AutoSize = true;
            this.LabelDetailsMonth.Location = new System.Drawing.Point(TextboxDetailsYear.Location.X + TextboxDetailsYear.Width + 3, LabelDetailsYear.Location.Y);
            this.LabelDetailsMonth.Name = "LabelDetailsMonth";
            this.LabelDetailsMonth.Text = "Month";
            this.PanelDetails.Controls.Add(this.LabelDetailsMonth);
            // TextboxDetailsMonth
            this.TextboxDetailsMonth.Location = new System.Drawing.Point(LabelDetailsMonth.Location.X, LabelDetailsMonth.Location.Y + LabelDetailsMonth.Height + 1);
            this.TextboxDetailsMonth.Name = "TextboxDetailsMonth";
            this.TextboxDetailsMonth.Size = new System.Drawing.Size((PanelDetails.ClientSize.Width - 15) / 4, 24);
            this.PanelDetails.Controls.Add(this.TextboxDetailsMonth);
            // LabelDetailsDay
            this.LabelDetailsDay.AutoSize = true;
            this.LabelDetailsDay.Location = new System.Drawing.Point(TextboxDetailsMonth.Location.X + TextboxDetailsMonth.Width + 3, LabelDetailsYear.Location.Y);
            this.LabelDetailsDay.Name = "LabelDetailsDay";
            this.LabelDetailsDay.Text = "Day";
            this.PanelDetails.Controls.Add(this.LabelDetailsDay);
            // TextboxDetailsDay
            this.TextboxDetailsDay.Location = new System.Drawing.Point(LabelDetailsDay.Location.X, LabelDetailsDay.Location.Y + LabelDetailsDay.Height + 1);
            this.TextboxDetailsDay.Name = "TextboxDetailsDay";
            this.TextboxDetailsDay.Size = new System.Drawing.Size((PanelDetails.ClientSize.Width - 15) / 4, 24);
            this.PanelDetails.Controls.Add(this.TextboxDetailsDay);  
            // LabelDetailsTime
            this.LabelDetailsTime.AutoSize = true;
            this.LabelDetailsTime.Location = new System.Drawing.Point(TextboxDetailsDay.Location.X + TextboxDetailsDay.Width + 3, LabelDetailsYear.Location.Y);
            this.LabelDetailsTime.Name = "LabelDetailsTime";
            this.LabelDetailsTime.Text = "Time";
            this.PanelDetails.Controls.Add(this.LabelDetailsTime);
            // TextboxDetailsTime
            this.TextboxDetailsTime.Location = new System.Drawing.Point(LabelDetailsTime.Location.X, LabelDetailsTime.Location.Y + LabelDetailsTime.Height + 1);
            this.TextboxDetailsTime.Name = "TextboxDetailsTime";
            this.TextboxDetailsTime.Size = new System.Drawing.Size((PanelDetails.ClientSize.Width - 15) / 4, 24);
            this.TextboxDetailsTime.LostFocus += new System.EventHandler(TextboxDetailsTime_LostFocus);
            this.PanelDetails.Controls.Add(this.TextboxDetailsTime);
            // LabelDetailsAuthor
            LabelDetailsAuthor.AutoSize = true;
            LabelDetailsAuthor.Location = new System.Drawing.Point(3, TextboxDetailsYear.Location.Y + TextboxDetailsYear.Height + 3);
            LabelDetailsAuthor.Name = "LabelDetailsAuthor";
            LabelDetailsAuthor.Text = "Author";
            this.PanelDetails.Controls.Add(this.LabelDetailsAuthor);
            // TextboxDetailsAuthor
            TextboxDetailsAuthor.Location = new System.Drawing.Point(LabelDetailsAuthor.Location.X, LabelDetailsAuthor.Location.Y + LabelDetailsAuthor.Height + 1);
            TextboxDetailsAuthor.Name = "TextboxDetailsAuthor";
            TextboxDetailsAuthor.Size = new System.Drawing.Size((PanelDetails.ClientSize.Width - 15) / 4, 24);
            this.PanelDetails.Controls.Add(this.TextboxDetailsAuthor);
            // LabelDetailsReference
            LabelDetailsReference.AutoSize = true;
            LabelDetailsReference.Location = new System.Drawing.Point(TextboxDetailsAuthor.Location.X + TextboxDetailsAuthor.Width + 3, LabelDetailsAuthor.Location.Y);
            LabelDetailsReference.Name = "LabelDetailsReference";
            LabelDetailsReference.Text = "Reference ID";
            this.PanelDetails.Controls.Add(this.LabelDetailsReference);
            // TextboxDetailsReference
            TextboxDetailsReference.Location = new System.Drawing.Point(LabelDetailsReference.Location.X, LabelDetailsReference.Location.Y + LabelDetailsReference.Height + 1);
            TextboxDetailsReference.Name = "TextboxDetailsReference";
            TextboxDetailsReference.Size = new System.Drawing.Size((PanelDetails.ClientSize.Width - 15) / 4, 24);
            this.PanelDetails.Controls.Add(this.TextboxDetailsReference);
            // LabelDetailsReplied
            LabelDetailsReplied.AutoSize = true;
            LabelDetailsReplied.Location = new System.Drawing.Point(TextboxDetailsReference.Location.X + TextboxDetailsReference.Width + 3, LabelDetailsAuthor.Location.Y);
            LabelDetailsReplied.Name = "LabelDetailsReplied";
            LabelDetailsReplied.Text = "Reference Reply";
            this.PanelDetails.Controls.Add(this.LabelDetailsReplied);
           
            // TextboxDetailsReplied
            TextboxDetailsReplied.Location = new System.Drawing.Point(LabelDetailsReplied.Location.X, LabelDetailsReplied.Location.Y + LabelDetailsReplied.Height + 1);
            TextboxDetailsReplied.Name = "TextboxDetailsReplied";
            TextboxDetailsReplied.Size = new System.Drawing.Size((PanelDetails.ClientSize.Width - 15) / 4, 24);
            this.PanelDetails.Controls.Add(this.TextboxDetailsReplied);
            // LabelDetailsBugLink
            LabelDetailsBugLink.AutoSize = true;
            LabelDetailsBugLink.Location = new System.Drawing.Point(TextboxDetailsReplied.Location.X + TextboxDetailsReplied.Width + 3, LabelDetailsAuthor.Location.Y);
            LabelDetailsBugLink.Name = "LabelDetailsBugLink";
            LabelDetailsBugLink.Text = "Bug ID";
            this.PanelDetails.Controls.Add(this.LabelDetailsBugLink);
            // TextboxDetailsBugLink
            TextboxDetailsBugLink.Location = new System.Drawing.Point(LabelDetailsBugLink.Location.X, LabelDetailsBugLink.Location.Y + LabelDetailsBugLink.Height + 1);
            TextboxDetailsBugLink.Name = "TextboxDetailsBugLink";
            TextboxDetailsBugLink.Size = new System.Drawing.Size((PanelDetails.ClientSize.Width - 15) / 4, 24);
            this.PanelDetails.Controls.Add(this.TextboxDetailsBugLink);
            
            // LabelDetailsCategory
            LabelDetailsCategory.AutoSize = true;
            LabelDetailsCategory.Location = new System.Drawing.Point(3, TextboxDetailsAuthor.Location.Y + TextboxDetailsAuthor.Height + 3);
            LabelDetailsCategory.Name = "LabelDetailsCategory";
            LabelDetailsCategory.Text = "Category";
            this.PanelDetails.Controls.Add(this.LabelDetailsCategory);
            // TextboxDetailsCategory
            TextboxDetailsCategory.Location = new System.Drawing.Point(LabelDetailsCategory.Location.X, LabelDetailsCategory.Location.Y + LabelDetailsCategory.Height + 1);
            TextboxDetailsCategory.Name = "TextboxDetailsCategory";
            TextboxDetailsCategory.Size = new System.Drawing.Size((PanelDetails.ClientSize.Width - 9) / 4, 24);
            this.PanelDetails.Controls.Add(this.TextboxDetailsCategory);            
            // LabelDetailsChange
            LabelDetailsChange.AutoSize = true;
            LabelDetailsChange.Location = new System.Drawing.Point(TextboxDetailsCategory.Location.X + TextboxDetailsCategory.Width + 3, LabelDetailsCategory.Location.Y);
            LabelDetailsChange.Name = "LabelDetailsChange";
            LabelDetailsChange.Text = "Description";
            this.PanelDetails.Controls.Add(this.LabelDetailsChange);            
            // TextboxDetailsChange
            TextboxDetailsChange.Location = new System.Drawing.Point(LabelDetailsChange.Location.X, LabelDetailsChange.Location.Y + LabelDetailsChange.Height + 1);
            TextboxDetailsChange.Name = "TextboxDetailsChange";
            TextboxDetailsChange.Size = new System.Drawing.Size(((PanelDetails.ClientSize.Width - 9) / 4) * 3, 24);
            this.PanelDetails.Controls.Add(this.TextboxDetailsChange);            
            // LabelDetailsDescription
            LabelDetailsDescription.AutoSize = true;
            LabelDetailsDescription.Location = new System.Drawing.Point(3, TextboxDetailsCategory.Location.Y + TextboxDetailsCategory.Height + 3);
            LabelDetailsDescription.Name = "LabelDetailsDescription";
            LabelDetailsDescription.Text = "Changes made";
            this.PanelDetails.Controls.Add(this.LabelDetailsDescription);
            // TextboxDetailsDescription
            TextboxDetailsDescription.Location = new System.Drawing.Point(LabelDetailsDescription.Location.X, LabelDetailsDescription.Location.Y + LabelDetailsDescription.Height + 1);
            TextboxDetailsDescription.Multiline = true;
            TextboxDetailsDescription.Name = "TextboxDetailsDescription";
            TextboxDetailsDescription.Size = new System.Drawing.Size((PanelDetails.ClientSize.Width - 7) / 2, (PanelDetails.ClientSize.Height - (LabelDetailsDescription.Location.Y + LabelDetailsDescription.Height + 4)));
            this.PanelDetails.Controls.Add(this.TextboxDetailsDescription);
            // LabelDetailsComment
            LabelDetailsComment.AutoSize = true;
            LabelDetailsComment.Location = new System.Drawing.Point(TextboxDetailsDescription.Location.X + TextboxDetailsDescription.Width + 3, LabelDetailsDescription.Location.Y);
            LabelDetailsComment.Name = "LabelDetailsComment";
            LabelDetailsComment.Text = "Other Comment";           
            this.PanelDetails.Controls.Add(this.LabelDetailsComment);
            // TextboxDetailsComment
            TextboxDetailsComment.Location = new System.Drawing.Point(LabelDetailsComment.Location.X, LabelDetailsComment.Location.Y + LabelDetailsComment.Height + 1);
            TextboxDetailsComment.Multiline = true;
            TextboxDetailsComment.Name = "TextboxDetailsComment";
            TextboxDetailsComment.Size = new System.Drawing.Size((PanelDetails.ClientSize.Width - 7) / 2, (PanelDetails.ClientSize.Height - (LabelDetailsDescription.Location.Y + LabelDetailsDescription.Height + 4)));
            this.PanelDetails.Controls.Add(this.TextboxDetailsComment);

            //
            // PanelList
            //
            PanelList.AutoSize = false;
            PanelList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            PanelList.Location = new System.Drawing.Point(PanelDetails.Width, 0);
            PanelList.Name = "PanelList";
            PanelList.Size = new System.Drawing.Size(this.ClientSize.Width / 3, this.ClientSize.Height);
            this.Controls.Add(this.PanelList);
            // ToolstripList
            ToolstripList.AutoSize = false;
            ToolstripList.Location = new System.Drawing.Point(0, 0);
            ToolstripList.Name = "ToolstripList";
            ToolstripList.Size = new System.Drawing.Size(PanelDetails.ClientSize.Width, 24);
            this.PanelList.Controls.Add(this.ToolstripList);
            // ToolstripButtonListRoot
            ToolstripButtonListRoot.AutoSize = true;
            ToolstripButtonListRoot.Name = "ToolstripButtonListRoot";
            ToolstripButtonListRoot.Text = "Root";
            this.ToolstripButtonListRoot.Click += new System.EventHandler(ToolstripButtonListRoot_Click);
            this.ToolstripList.Items.Add(this.ToolstripButtonListRoot);
            // ToolstripButtonListSolution
            ToolstripButtonListSolution.AutoSize = true;
            ToolstripButtonListSolution.Name = "ToolstripButtonListSolution";
            ToolstripButtonListSolution.Text = "Solution";
            this.ToolstripButtonListSolution.Click += new System.EventHandler(ToolstripButtonListSolution_Click);
            this.ToolstripList.Items.Add(this.ToolstripButtonListSolution);
            // ToolstripButtonListProgram
            ToolstripButtonListProgram.AutoSize = true;
            ToolstripButtonListProgram.Name = "ToolstripButtonListProgram";
            ToolstripButtonListProgram.Text = "Program";
            this.ToolstripButtonListProgram.Click += new System.EventHandler(ToolstripButtonListProgram_Click);
            this.ToolstripList.Items.Add(this.ToolstripButtonListProgram);
            // ToolstripButtonListVersion
            ToolstripButtonListVersion.AutoSize = true;
            ToolstripButtonListVersion.Name = "ToolstripButtonListVersion";
            ToolstripButtonListVersion.Text = "Version";
            this.ToolstripButtonListVersion.Click += new System.EventHandler(ToolstripButtonListVersion_Click);
            this.ToolstripList.Items.Add(this.ToolstripButtonListVersion);
            // ToolstripSeperatorList
            ToolstripSeperatorList.Name = "ToolstripSeperatorList";
            this.ToolstripList.Items.Add(this.ToolstripSeperatorList);
            // ToolstripButtonListEntryAdd
            ToolstripButtonListEntryAdd.AutoSize = true;
            ToolstripButtonListEntryAdd.Name = "ToolstripButtonListEntryAdd";
            ToolstripButtonListEntryAdd.Text = "Add Entry";
            this.ToolstripButtonListEntryAdd.Click += new System.EventHandler(ToolstripButtonListEntryAdd_Click);
            this.ToolstripList.Items.Add(this.ToolstripButtonListEntryAdd);
            // ToolstripButtonListExport
            ToolstripButtonListExport.AutoSize = true;
            ToolstripButtonListExport.Name = "ToolstripButtonListExport";
            ToolstripButtonListExport.Text = "Export Selected";
            this.ToolstripButtonListExport.Click += new System.EventHandler(ToolstripButtonListExport_Click);
            this.ToolstripList.Items.Add(this.ToolstripButtonListExport);
                   
            // ListviewListEntries
            ListviewListEntries.View = System.Windows.Forms.View.Details;
            ListviewListEntries.FullRowSelect = true;
            ListviewListEntries.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            ListviewListEntries.Location = new System.Drawing.Point(3, ToolstripList.Height + 3);
            ListviewListEntries.MultiSelect = true;
            ListviewListEntries.Name = "ListviewListEntries";
            ListviewListEntries.Size = new System.Drawing.Size(PanelList.ClientSize.Width - 6, PanelList.ClientSize.Height - 30);
            this.ListviewListEntries.ItemActivate += new System.EventHandler(ListviewListEntries_ItemActivate);
            this.PanelList.Controls.Add(this.ListviewListEntries);
			//
			// Done loading GUI
			//
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	
	   
	}
}
