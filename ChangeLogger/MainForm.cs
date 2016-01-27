using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using InputboxSample;
using Microsoft.VisualBasic;

namespace ChangeLogger
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
			
            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
            Writer("Startup", null);
            Reader("Load", "Root");
        }
        //-------------------HANDLER SUBS----------------------
        void This_Resize(object sender, EventArgs e)
        {
            this.SuspendLayout();
            // PanelDetails
            PanelDetails.Location = new System.Drawing.Point(0, 0);
            PanelDetails.Size = new System.Drawing.Size((this.ClientSize.Width / 3) * 2, this.ClientSize.Height);
            ToolstripDetails.Location = new System.Drawing.Point(0, 0);
            ToolstripDetails.Size = new System.Drawing.Size(PanelDetails.ClientSize.Width, 24);
            LabelDetailsYear.Location = new System.Drawing.Point(3, ToolstripDetails.Height + 3);
            TextboxDetailsYear.Location = new System.Drawing.Point(LabelDetailsYear.Location.X, LabelDetailsYear.Location.Y + LabelDetailsYear.Height + 1);
            TextboxDetailsYear.Size = new System.Drawing.Size((PanelDetails.ClientSize.Width - 15) / 4, 24);
            LabelDetailsMonth.Location = new System.Drawing.Point(TextboxDetailsYear.Location.X + TextboxDetailsYear.Width + 3, LabelDetailsYear.Location.Y);
            TextboxDetailsMonth.Location = new System.Drawing.Point(LabelDetailsMonth.Location.X, LabelDetailsMonth.Location.Y + LabelDetailsMonth.Height + 1);
            TextboxDetailsMonth.Size = new System.Drawing.Size((PanelDetails.ClientSize.Width - 15) / 4, 24);
            LabelDetailsDay.Location = new System.Drawing.Point(TextboxDetailsMonth.Location.X + TextboxDetailsMonth.Width + 3, LabelDetailsYear.Location.Y);
            TextboxDetailsDay.Location = new System.Drawing.Point(LabelDetailsDay.Location.X, LabelDetailsDay.Location.Y + LabelDetailsDay.Height + 1);
            TextboxDetailsDay.Size = new System.Drawing.Size((PanelDetails.ClientSize.Width - 15) / 4, 24);
            LabelDetailsTime.Location = new System.Drawing.Point(TextboxDetailsDay.Location.X + TextboxDetailsDay.Width + 3, LabelDetailsYear.Location.Y);
            TextboxDetailsTime.Location = new System.Drawing.Point(LabelDetailsTime.Location.X, LabelDetailsTime.Location.Y + LabelDetailsTime.Height + 1);
            TextboxDetailsTime.Size = new System.Drawing.Size((PanelDetails.ClientSize.Width - 15) / 4, 24);
            LabelDetailsAuthor.Location = new System.Drawing.Point(3, TextboxDetailsYear.Location.Y + TextboxDetailsYear.Height + 3);
            TextboxDetailsAuthor.Location = new System.Drawing.Point(LabelDetailsAuthor.Location.X, LabelDetailsAuthor.Location.Y + LabelDetailsAuthor.Height + 1);
            TextboxDetailsAuthor.Size = new System.Drawing.Size((PanelDetails.ClientSize.Width - 15) / 4, 24);
            LabelDetailsReference.Location = new System.Drawing.Point(TextboxDetailsAuthor.Location.X + TextboxDetailsAuthor.Width + 3, LabelDetailsAuthor.Location.Y);
            TextboxDetailsReference.Location = new System.Drawing.Point(LabelDetailsReference.Location.X, LabelDetailsReference.Location.Y + LabelDetailsReference.Height + 1);
            TextboxDetailsReference.Size = new System.Drawing.Size((PanelDetails.ClientSize.Width - 15) / 4, 24);
            LabelDetailsReplied.Location = new System.Drawing.Point(TextboxDetailsReference.Location.X + TextboxDetailsReference.Width + 3, LabelDetailsAuthor.Location.Y);
            TextboxDetailsReplied.Location = new System.Drawing.Point(LabelDetailsReplied.Location.X, LabelDetailsReplied.Location.Y + LabelDetailsReplied.Height + 1);
            TextboxDetailsReplied.Size = new System.Drawing.Size((PanelDetails.ClientSize.Width - 15) / 4, 24);
            LabelDetailsBugLink.Location = new System.Drawing.Point(TextboxDetailsReplied.Location.X + TextboxDetailsReplied.Width + 3, LabelDetailsAuthor.Location.Y);
            TextboxDetailsBugLink.Location = new System.Drawing.Point(LabelDetailsBugLink.Location.X, LabelDetailsBugLink.Location.Y + LabelDetailsBugLink.Height + 1);
            TextboxDetailsBugLink.Size = new System.Drawing.Size((PanelDetails.ClientSize.Width - 15) / 4, 24);
            LabelDetailsCategory.Location = new System.Drawing.Point(3, TextboxDetailsAuthor.Location.Y + TextboxDetailsAuthor.Height + 3);
            TextboxDetailsCategory.Location = new System.Drawing.Point(LabelDetailsCategory.Location.X, LabelDetailsCategory.Location.Y + LabelDetailsCategory.Height + 1);
            TextboxDetailsCategory.Size = new System.Drawing.Size((PanelDetails.ClientSize.Width - 9) / 4, 24);
            LabelDetailsChange.Location = new System.Drawing.Point(TextboxDetailsCategory.Location.X + TextboxDetailsCategory.Width + 3, LabelDetailsCategory.Location.Y);
            TextboxDetailsChange.Location = new System.Drawing.Point(LabelDetailsChange.Location.X, LabelDetailsChange.Location.Y + LabelDetailsChange.Height + 1);
            TextboxDetailsChange.Size = new System.Drawing.Size(((PanelDetails.ClientSize.Width - 9) / 4) * 3, 24);
            LabelDetailsDescription.Location = new System.Drawing.Point(3, TextboxDetailsCategory.Location.Y + TextboxDetailsCategory.Height + 3);
            TextboxDetailsDescription.Location = new System.Drawing.Point(LabelDetailsDescription.Location.X, LabelDetailsDescription.Location.Y + LabelDetailsDescription.Height + 1);
            TextboxDetailsDescription.Size = new System.Drawing.Size((PanelDetails.ClientSize.Width - 7) / 2, (PanelDetails.ClientSize.Height - (LabelDetailsDescription.Location.Y + LabelDetailsDescription.Height + 4)));
            LabelDetailsComment.Location = new System.Drawing.Point(TextboxDetailsDescription.Location.X + TextboxDetailsDescription.Width + 3, LabelDetailsDescription.Location.Y);
            TextboxDetailsComment.Location = new System.Drawing.Point(LabelDetailsComment.Location.X, LabelDetailsComment.Location.Y + LabelDetailsComment.Height + 1);
            TextboxDetailsComment.Size = new System.Drawing.Size((PanelDetails.ClientSize.Width - 7) / 2, (PanelDetails.ClientSize.Height - (LabelDetailsDescription.Location.Y + LabelDetailsDescription.Height + 4)));

            // PanelList
            PanelList.Location = new System.Drawing.Point(PanelDetails.Width, 0);
            PanelList.Size = new System.Drawing.Size(this.ClientSize.Width / 3, this.ClientSize.Height);
            ToolstripList.Location = new System.Drawing.Point(0, 0);
            ToolstripList.Size = new System.Drawing.Size(PanelDetails.ClientSize.Width, 24);
            ListviewListEntries.Location = new System.Drawing.Point(3, ToolstripList.Height + 3);
            ListviewListEntries.Size = new System.Drawing.Size(PanelList.ClientSize.Width - 6, PanelList.ClientSize.Height - 30);
            this.ResumeLayout();
        }
        void ToolstripButtonDetailsSave_Click(object sender, EventArgs e)
        {
            Writer("Entry", "Save");
        }
        void ToolstripButtonDetailsClear_Click(object sender, EventArgs e)
        {
            ClearItemFields(null, null);
        }
        void ToolstripButtonDetailsAutofill_Click(object sender, EventArgs e)
        {
            TextboxDetailsDay.Text = System.Convert.ToString(System.DateTime.Now.Day);
            TextboxDetailsMonth.Text = System.Convert.ToString(System.DateTime.Now.Month);
            TextboxDetailsYear.Text = System.Convert.ToString(System.DateTime.Now.Year);
            TextboxDetailsTime.Text = System.Convert.ToString(System.DateTime.Now.Hour) + "." + System.Convert.ToString(System.DateTime.Now.Minute);
        }
        void TextboxDetailsTime_LostFocus(object sender, EventArgs e)
        {
            var tb = sender as System.Windows.Forms.TextBox;
            if (tb.TextLength == 4) {
                string t1;
                string t2;
                t1 = tb.Text.Remove(2);
                t2 = tb.Text.Remove(0, 2);
                tb.Text = t1 + "." + t2;
            } else if (tb.TextLength == 5) {
                string t1;
                string t2;
                t1 = tb.Text.Remove(2);
                t2 = tb.Text.Remove(0, 3);
                tb.Text = t1 + "." + t2;
            } else {
                MessageBox.Show("Not a valid format, full digits required. Separator can be any char (ie. '.' '-' 'a' ' ' or even nothing).", "Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            sender = tb;
        }

        void ToolstripButtonListRoot_Click(object sender, EventArgs e)
        {
            Reader("Load", "Root");
        }

        void ToolstripButtonListSolution_Click(object sender, EventArgs e)
        {
            var tsb = sender as ToolStripButton;
            if (tsb.Text != null) {
                if (tsb.Text == "..") {
                } else {
                    ListviewListEntries.Items.Insert(0, "");
                    ListviewListEntries.Items[0].Selected = true;
                    ListviewListEntries.SelectedItems[0].SubItems[0].Text = ToolstripButtonListSolution.Text;
                    Reader("Load", "Solution");
                }
            }
        }

        void ToolstripButtonListProgram_Click(object sender, EventArgs e)
        {
            var tsb = sender as ToolStripButton;
            if (tsb.Text != null) {
                if (tsb.Text == "..") {
                } else {
                    ListviewListEntries.Items.Insert(0, "");
                    ListviewListEntries.Items[0].Selected = true;
                    ListviewListEntries.SelectedItems[0].SubItems[0].Text = ToolstripButtonListProgram.Text;
                }
            }
            Reader("Load", "Program");
        }

        void ToolstripButtonListVersion_Click(object sender, EventArgs e)
        {
            var tsb = sender as ToolStripButton;
            if (tsb.Text != null) {
                if (tsb.Text == "..") {
                } else {
                    ListviewListEntries.Items.Insert(0, "");
                    ListviewListEntries.Items[0].Selected = true;
                    ListviewListEntries.SelectedItems[0].SubItems[0].Text = ToolstripButtonListVersion.Text;
                }
            }
            Reader("Load", "Version");
        }

        void ToolstripButtonListEntryAdd_Click(object sender, EventArgs e)
        {
            if (stringBrowsingLevel == "Solution") {
                stringDirectoryCurrent = System.IO.Directory.GetCurrentDirectory();
                stringDirectoryCurrent += "\\Database\\";
                InputboxResult = Inputbox.Show("New Solution name:", "Solution Name", "New");
                if (InputboxResult.OK) {
                    stringDirectoryCurrent += InputboxResult.Text;
                    System.IO.Directory.CreateDirectory(stringDirectoryCurrent);
                    ToolstripButtonListRoot_Click(null, null);
                } else {
                    MessageBox.Show("Cancelled", "Create Solution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } else if (stringBrowsingLevel == "Program") {
                stringDirectoryCurrent = System.IO.Directory.GetCurrentDirectory();
                stringDirectoryCurrent += "\\Database\\";
                InputboxResult = Inputbox.Show("New Program name:", "Program Name", "New");
                if (InputboxResult.OK) {
                    stringDirectoryCurrent += ToolstripButtonListSolution.Text;
                    stringDirectoryCurrent += "\\";
                    stringDirectoryCurrent += InputboxResult.Text;
                    ToolstripButtonListSolution_Click(null, null);
                    System.IO.Directory.CreateDirectory(stringDirectoryCurrent);
                } else {
                    MessageBox.Show("Cancelled", "Create Program", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }            
            } else if (stringBrowsingLevel == "Version") {
                stringDirectoryCurrent = System.IO.Directory.GetCurrentDirectory();
                stringDirectoryCurrent += "\\Database\\";
                InputboxResult = Inputbox.Show("New Version:", "Version", "1.0.0.0");
                if (InputboxResult.OK) {
                    stringDirectoryCurrent += ToolstripButtonListSolution.Text;
                    stringDirectoryCurrent += "\\";
                    stringDirectoryCurrent += ToolstripButtonListProgram.Text;
                    stringDirectoryCurrent += "\\";
                    stringDirectoryCurrent += InputboxResult.Text;
                    ToolstripButtonListProgram_Click(null, null);
                    System.IO.Directory.CreateDirectory(stringDirectoryCurrent);
                } else {
                    MessageBox.Show("Cancelled", "Create Version", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } else if (stringBrowsingLevel == "Entry") {
                MessageBox.Show("Please fill/edit the details and use the 'Save Item' button.", "Create Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void ToolstripButtonListExport_Click(object sender, EventArgs e)
        {
            DialogResult messageboxResult = MessageBox.Show("Text-file will be generated containing all changes from the Program./n/rPress YES for a FULL output./n/rPress NO for NORMAL output.", "Output Full or Normal?", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (messageboxResult == DialogResult.Yes) {
                ExportConversion(6, null, null); //Full
            } else if (messageboxResult == DialogResult.No) {
                ExportConversion(5, null, null); //Normal
            }
        }

        void ListviewListEntries_ItemActivate(object sender, EventArgs e)
        {
            Reader("Load", stringBrowsingLevel);
        }

        void ClearItemFields(string OK, string Cancel)
        {
            TextboxDetailsYear.Text = "";
            TextboxDetailsMonth.Text = "";
            TextboxDetailsDay.Text = "";
            TextboxDetailsTime.Text = "";
            TextboxDetailsAuthor.Text = "";
            TextboxDetailsReference.Text = "";
            TextboxDetailsReplied.Text = "";
            TextboxDetailsBugLink.Text = "";
            TextboxDetailsCategory.Text = "";
            TextboxDetailsChange.Text = "";
            TextboxDetailsDescription.Text = "";
            TextboxDetailsComment.Text = "";
        }
    }
}