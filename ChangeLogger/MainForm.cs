using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

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
		}
		void This_Resize(object sender, EventArgs e)
		{
			// Pause Layout
			// Call resize components
			// Resume Layout
		}
		void ToolstripButtonDetailsSave_Click(object sender, EventArgs e)
		{
			// Save Input to Database
			// Refresh ListviewOverview
		}
		void ToolstripButtonDetailsClear_Click(object sender, EventArgs e)
		{
		
		}
        void ToolstripButtonDetailsAutofill_Click(object sender, EventArgs e)
        {
        
        }
        void TextboxDetailsTime_LostFocus(object sender, EventArgs e)
        {
        
        }
        void ToolstripButtonListRoot_Click(object sender, EventArgs e)
        {
        
        }
        void ToolstripButtonListSolution_Click(object sender, EventArgs e)
        {
        
        }
        void ToolstripButtonListProgram_Click(object sender, EventArgs e)
        {
        
        }
        void ToolstripButtonListVersion_Click(object sender, EventArgs e)
        {
        
        }
        void ToolstripButtonListEntryAdd_Click(object sender, EventArgs e)
        {
        
        }
        void ToolstripButtonListExport_Click(object sender, EventArgs e)
        {
        
        }
        void ListviewListEntries_ItemActivate(object sender, EventArgs e)
        {
        
        }
	}
}
