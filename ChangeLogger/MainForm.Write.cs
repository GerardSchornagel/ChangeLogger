using System.Windows.Forms;

namespace ChangeLogger
{
    partial class MainForm
    {
        /// <summary>
        /// Handling of data to be written.
        /// Startup = Check if initial directory(s) have been created, ifnot do.
        /// Remove = Removes an entry physically.
        /// Entry = Saves an entry to a xml file via System.Xml.XmlWriter.
        /// </summary>

        void Writer(string Command, string Addition)
        {
            if (Command == "Startup") { //Check for initial directory(s).
                string directoryStartup;
                directoryStartup = System.IO.Directory.GetCurrentDirectory();
                directoryStartup += "\\Database\\";
                if (System.IO.Directory.Exists(directoryStartup) == false) {
                    System.IO.Directory.CreateDirectory(directoryStartup);
                }
            } else if (Command == "Remove") { //Removes the physical from the HD.
                // msgbox then delete stringFileCurrent+"day".xml
                try {
                    messageboxResult = MessageBox.Show("Sure you want to delete Entry '" + TextboxDetailsMonth.Text + "-" + TextboxDetailsDay.Text + "_" + TextboxDetailsTime.Text + "_" + TextboxDetailsAuthor.Text + "'?", "Delete entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                } catch (System.Exception e) {
                    MessageBox.Show("You have to load the entry to mark it for remove.");
                }
                if (messageboxResult == DialogResult.Yes) { //Yes.
                    //Delete directory
                    try {
                        System.IO.File.Delete(stringFileCurrent + "\\" + TextboxDetailsMonth.Text + "-" + TextboxDetailsDay.Text + "_" + TextboxDetailsTime.Text + "_" + TextboxDetailsAuthor.Text + ".xml");
                    } catch (System.Exception e) {
                    }
                }
            } else if (Command == "Entry") {
                stringFileCurrent = System.IO.Directory.GetCurrentDirectory();
                stringFileCurrent += "\\Database\\";
                stringFileCurrent += ToolstripButtonListSolution.Text;
                stringFileCurrent += "\\";
                stringFileCurrent += ToolstripButtonListProgram.Text;
                stringFileCurrent += "\\";
                stringFileCurrent += ToolstripButtonListVersion.Text;
                if (Addition == "Save") {
                    // Create new structure from stringFileCurrent
                    System.IO.Directory.CreateDirectory(stringFileCurrent);
                    System.Xml.XmlWriterSettings settings = new System.Xml.XmlWriterSettings();
                    settings.Indent = true;
                    //Start WriterXML With stringFileCurrent + "Day".XML
                    using (System.Xml.XmlWriter writer = System.Xml.XmlWriter.Create(stringFileCurrent + "\\" + TextboxDetailsMonth.Text + "-" + TextboxDetailsDay.Text + "_" + TextboxDetailsTime.Text + "_" + TextboxDetailsAuthor.Text + ".xml", settings)) {
                        // Begin writing.
                        writer.WriteStartDocument();
                        writer.WriteStartElement("Information");
                        //> Information
                        writer.WriteElementString("Year", TextboxDetailsYear.Text);
                        writer.WriteElementString("Month", TextboxDetailsMonth.Text);
                        writer.WriteElementString("Day", TextboxDetailsDay.Text);
                        writer.WriteElementString("Time", TextboxDetailsTime.Text);
                        writer.WriteElementString("Author", TextboxDetailsAuthor.Text);
                        writer.WriteElementString("ReferenceID", TextboxDetailsReference.Text);
                        writer.WriteElementString("Reply", TextboxDetailsReplied.Text);
                        writer.WriteElementString("BugID", TextboxDetailsBugLink.Text);
                        writer.WriteElementString("Category", TextboxDetailsCategory.Text);
                        writer.WriteElementString("Change", TextboxDetailsChange.Text);
                        writer.WriteElementString("Description", TextboxDetailsDescription.Text);
                        writer.WriteElementString("Comment", TextboxDetailsComment.Text);
                        // End document.
                        writer.WriteEndDocument();
                    }
                    ListviewListEntries.Items.Insert(0, ToolstripButtonListVersion.Text);
                    ListviewListEntries.Items[0].Selected = true;
                    Reader("Load", "Version"); 
                }
            }
        }
    }
}