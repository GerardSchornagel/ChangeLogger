namespace ChangeLogger
{
    partial class MainForm
    {
        /// <summary>
        /// Handling of data to be loaded.
        /// </summary>


        void Reader(string Command, string Addition)
        {
            if (Command == "Load") {
                if (Addition == "Root") {
                    ToolstripButtonListRoot.Text = "Root";
                    ToolstripButtonListSolution.Text = "...";
                    ToolstripButtonListProgram.Text = "...";
                    ToolstripButtonListVersion.Text = "...";
        
                    ListviewListEntries.Items.Clear();
                    ListviewListEntries.Columns.Clear();
                    ListviewListEntries.Columns.Add("Solution");
                    ListviewListEntries.Columns[0].Width = -2;
        
                    try {
                        arrayReader = System.IO.Directory.GetDirectories(stringDirectoryProgramDatabase, "*", System.IO.SearchOption.TopDirectoryOnly);
                    } catch (System.Exception e) {
                    }
                    
                    intCharacterLength = 0;
                    foreach (int number in stringDirectoryProgramDatabase) {
                        intCharacterLength = intCharacterLength + 1;   
                    }
                    
                    string stringLine;
                    foreach (string line in arrayReader) {
                        stringLine = line.Remove(0, intCharacterLength);
                        ListviewListEntries.Items.Add(stringLine);
                    }
                    ClearItemFields(null,null);
                    // Entered Next Browsing level
                    stringBrowsingLevel = "Solution";
                    
                } else if (Addition == "Solution") {
                    ToolstripButtonListSolution.Text = ListviewListEntries.SelectedItems[0].SubItems[0].Text;
                    ToolstripButtonListProgram.Text = "...";
                    ToolstripButtonListVersion.Text = "...";
                    
                    ListviewListEntries.Items.Clear();
                    ListviewListEntries.Columns.Clear();
                    ListviewListEntries.Columns.Add("Program");
                    ListviewListEntries.Columns[0].Width = -2;
                    
                    try {
                        arrayReader = System.IO.Directory.GetDirectories(stringDirectoryProgramDatabase + ToolstripButtonListSolution.Text + "\\", "*", System.IO.SearchOption.TopDirectoryOnly);
                    } catch (System.Exception e) {
                        
                    }
                                    
                    intCharacterLength = 0;
                    foreach (int number in stringDirectoryProgramDatabase + ToolstripButtonListSolution.Text + "\\") {
                        intCharacterLength = intCharacterLength + 1;
                    }
                    foreach (string line in arrayReader) {
                        stringLine = line.Remove(0, intCharacterLength);
                        ListviewListEntries.Items.Add(stringLine);
                    }
                    ClearItemFields(null,null);
                    // Entered Next Browsing level
                    stringBrowsingLevel = "Program";
                } else if (Addition == "Program") {
                    ToolstripButtonListProgram.Text = ListviewListEntries.SelectedItems[0].SubItems[0].Text;
                    ToolstripButtonListVersion.Text = "...";
                    
                    ListviewListEntries.Items.Clear();
                    ListviewListEntries.Columns.Clear();
                    ListviewListEntries.Columns.Add("Version");
                    ListviewListEntries.Columns[0].Width = -2;
                    
                    try {
                        arrayReader = System.IO.Directory.GetDirectories(stringDirectoryProgramDatabase + ToolstripButtonListSolution.Text + "\\" + ToolstripButtonListProgram.Text + "\\", "*", System.IO.SearchOption.TopDirectoryOnly);
                    } catch(System.Exception e) {
                        
                    }

                    intCharacterLength = 0;
                    foreach (int number in stringDirectoryProgramDatabase + ToolstripButtonListSolution.Text + "\\" + ToolstripButtonListProgram.Text + "\\") {
                        intCharacterLength = intCharacterLength + 1;
                    }
                    foreach (string line in arrayReader) {
                        stringLine = line.Remove(0, intCharacterLength);
                        ListviewListEntries.Items.Add(stringLine);
                    }
                    ClearItemFields(null,null);
                    //Entered Next Browsing level
                    stringBrowsingLevel = "Version";
                    
                } else if (Addition == "Version") {
                    ToolstripButtonListVersion.Text = ListviewListEntries.SelectedItems[0].SubItems[0].Text;
                    
                    ListviewListEntries.Items.Clear();
                    ListviewListEntries.Columns.Clear();
                    ListviewListEntries.Columns.Add("Reference");
                    ListviewListEntries.Columns.Add("Date");
                    ListviewListEntries.Columns.Add("Category");
                    ListviewListEntries.Columns.Add("Reply");
                    ListviewListEntries.Columns.Add("BugID");
                    ListviewListEntries.Columns[0].Width = -2;
                    
                    try {
                        arrayReader = System.IO.Directory.GetFiles(stringDirectoryProgramDatabase + ToolstripButtonListSolution.Text + "\\" + ToolstripButtonListProgram.Text + "\\" + ToolstripButtonListVersion.Text + "\\", "*", System.IO.SearchOption.TopDirectoryOnly);
                    } catch (System.Exception e) {
                    }
                    intCharacterLength = 0;
                    foreach (int number in stringDirectoryProgramDatabase + ToolstripButtonListSolution.Text + "\\" + ToolstripButtonListProgram.Text + "\\" + ToolstripButtonListVersion.Text + "\\") {
                        intCharacterLength = intCharacterLength + 1;
                    }
                    foreach (string line in arrayReader) {
                        stringLine = line.Remove(0, intCharacterLength);
                        stringLine = System.Text.RegularExpressions.Regex.Split(stringLine, ".xml")[0];
                        //Load XML-Files into System.XML.Reader's
                        // Create an XML XmlReader with line.ToString
                        using (System.Xml.XmlReader XmlReader = System.Xml.XmlReader.Create(stringDirectoryProgramDatabase + ToolstripButtonListSolution.Text + "\\" + ToolstripButtonListProgram.Text + "\\" + ToolstripButtonListVersion.Text + "\\" + stringLine + ".xml")) {
                            //Load XML-Files intro program-controls
                            if (XmlReader.IsStartElement("Information")) {
                                System.Windows.Forms.ListViewItem ListviewItemBuild = new System.Windows.Forms.ListViewItem();
                                ListviewItemBuild.SubItems.AddRange(new string[] {"0", "1", "2", "3", "4"});
                    
                                XmlReader.ReadToFollowing("Month");
                                stringReadFile = XmlReader.ReadString();
                                XmlReader.ReadToFollowing("Day");
                                stringReadFile += "-" + XmlReader.ReadString();
                                ListviewItemBuild.SubItems[1].Text = stringReadFile;
                                XmlReader.ReadToFollowing("ReferenceID");
                                ListviewItemBuild.SubItems[0].Text = XmlReader.ReadString();
                                XmlReader.ReadToFollowing("Reply");
                                ListviewItemBuild.SubItems[3].Text = XmlReader.ReadString();
                                XmlReader.ReadToFollowing("BugID");
                                ListviewItemBuild.SubItems[4].Text = XmlReader.ReadString();
                                XmlReader.ReadToFollowing("Category");
                                ListviewItemBuild.SubItems[2].Text = XmlReader.ReadString();
                                ListviewItemBuild.Tag = stringLine;
                    
                                ListviewListEntries.Items.Add(ListviewItemBuild);
                            }
                        }
                    }
                    ClearItemFields(null,null);
                    //Entered Next Browsing level
                    stringBrowsingLevel = "Entry";
                    
                } else if (Addition == "Entry") {
                    using (System.Xml.XmlReader XmlReader = System.Xml.XmlReader.Create(stringDirectoryProgramDatabase + ToolstripButtonListSolution.Text + "\\" + ToolstripButtonListProgram.Text + "\\" + ToolstripButtonListVersion.Text + "\\" + ListviewListEntries.SelectedItems[0].Tag + ".xml")) {
                        //Load XML-Files intro program-controls
                        if (XmlReader.IsStartElement("Information")) {
                            XmlReader.ReadToFollowing("Year");
                            TextboxDetailsYear.Text = XmlReader.ReadString();
                            XmlReader.ReadToFollowing("Month");
                            TextboxDetailsMonth.Text = XmlReader.ReadString();
                            XmlReader.ReadToFollowing("Day");
                            TextboxDetailsDay.Text = XmlReader.ReadString();
                            XmlReader.ReadToFollowing("Time");
                            TextboxDetailsTime.Text = XmlReader.ReadString();
                            XmlReader.ReadToFollowing("Author");
                            TextboxDetailsAuthor.Text = XmlReader.ReadString();
                            XmlReader.ReadToFollowing("ReferenceID");
                            TextboxDetailsReference.Text = XmlReader.ReadString();
                            XmlReader.ReadToFollowing("Reply");
                            TextboxDetailsReplied.Text = XmlReader.ReadString();
                            XmlReader.ReadToFollowing("BugID");
                            TextboxDetailsBugLink.Text = XmlReader.ReadString();
                            XmlReader.ReadToFollowing("Category");
                            TextboxDetailsCategory.Text = XmlReader.ReadString();
                            XmlReader.ReadToFollowing("Change");
                            TextboxDetailsChange.Text = XmlReader.ReadString();
                            XmlReader.ReadToFollowing("Description");
                            TextboxDetailsDescription.Text = XmlReader.ReadString();
                            XmlReader.ReadToFollowing("Comment");
                            TextboxDetailsComment.Text = XmlReader.ReadString();
                        }        
                    }
                }
            }
        }
    }
}        