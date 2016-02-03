using System.Collections.Specialized;
using System.Diagnostics;
using System.Windows.Forms;

namespace ChangeLogger
{
    partial class MainForm
    {
        /// <summary>
        /// Export to txt file's.
        /// </summary>
        void ExportConversion(System.Windows.Forms.DialogResult MessageboxResult, string OK, string Cancel)
        {
            stringSolution = ToolstripButtonListSolution.Text;
            stringProgram = ToolstripButtonListProgram.Text;
            stringOutput = null;
                                
            using (System.IO.StreamWriter writer = System.IO.File.CreateText(stringDirectoryProgramDatabase + stringSolution + "\\" + stringProgram + "." + stringResult + ".txt")) {
                //start header of file
                writer.WriteLine(stringSolution.ToUpper() + " - " + stringProgram);
                writer.WriteLine();
        
                //get array of versions in program
                try {
                    arrayProgram = System.IO.Directory.GetDirectories(stringDirectoryProgramDatabase + stringSolution + "\\" + stringProgram, "*", System.IO.SearchOption.TopDirectoryOnly);
                } catch (System.Exception e) {
                }
                           
                //Counting leading trails to remove
                intCharacterLength = 0;
                foreach (int number in stringDirectoryProgramDatabase + stringSolution + "\\" + stringProgram + "\\") {
                    intCharacterLength = intCharacterLength + 1;
                }
        
                //each version>get files
                foreach (string line in arrayProgram) {
                    stringLine = line.Remove(0, intCharacterLength);
                    try {
                        arrayVersion = System.IO.Directory.GetFiles(stringDirectoryProgramDatabase + stringSolution + "\\" + stringProgram + "\\" + stringLine, "*", System.IO.SearchOption.TopDirectoryOnly);
                    } catch (System.Exception e) {
                    }
        
                    //Version Number
                    writer.WriteLine("[" + line + "]");
                    foreach (string file in arrayVersion) {
                        if (MessageboxResult == DialogResult.Yes) { //Full
                            stringResult = "Full";
                            using (System.Xml.XmlReader reader = System.Xml.XmlReader.Create(file)) {
                                //Load XML-Files intro program-controls
                                if (reader.IsStartElement("Information")) {
                                    //Year-Month-Day-Time : Author - ReferenceID
                                    reader.ReadToFollowing("Year");
                                    writer.Write(reader.ReadString() + "-");
                                    reader.ReadToFollowing("Month");
                                    writer.Write(reader.ReadString() + "-");
                                    reader.ReadToFollowing("Day");
                                    writer.Write(reader.ReadString() + ":");
                                    reader.ReadToFollowing("Time");
                                    writer.Write(reader.ReadString() + " : ");
                                    reader.ReadToFollowing("Author");
                                    writer.Write(reader.ReadString() + " - ");
                                    reader.ReadToFollowing("ReferenceID");
                                    writer.Write(reader.ReadString());
                                    writer.WriteLine();
        
                                    //	Affects: Reply&BugID
                                    reader.ReadToFollowing("Reply");
                                    writer.Write("Affects Reply [");
                                    writer.Write(reader.ReadString() + "] & Bug-ID [");
                                    reader.ReadToFollowing("BugID");
                                    writer.Write(reader.ReadString() + "]");
                                    writer.WriteLine();
                                    //	Category
                                    reader.ReadToFollowing("Category");
                                    writer.WriteLine("Category: " + reader.ReadString());
                                    //   Change
                                    reader.ReadToFollowing("Change");
                                    writer.WriteLine("Change: " + reader.ReadString());
                                    //	Description
                                    reader.ReadToFollowing("Description");
                                    writer.WriteLine("Description: " + reader.ReadString());
                                    //	Comment
                                    reader.ReadToFollowing("Comment");
                                    writer.WriteLine("Comments: " + reader.ReadString());
                                }
                            }
                            writer.WriteLine();
                        } else if (MessageboxResult == DialogResult.No) { // Normal
                            stringResult = "Normal";
                            using (System.Xml.XmlReader reader = System.Xml.XmlReader.Create(file)) {
                                //Load XML-Files intro program-controls
                                if (reader.IsStartElement("Information")) {
                                    reader.ReadToFollowing("Year");
                                    writer.Write(reader.ReadString() + "-");
                                    reader.ReadToFollowing("Month");
                                    writer.Write(reader.ReadString() + "-");
                                    reader.ReadToFollowing("Day");
                                    writer.Write(reader.ReadString() + ": ");
                                    reader.ReadToFollowing("Category");
                                    writer.Write(reader.ReadString());
                                    writer.WriteLine();
        
                                    reader.ReadToFollowing("Change");
                                    writer.WriteLine("- " + reader.ReadString());
                                }
                            }
                        } else {
                            MessageBox.Show("There was no result returned, please try again and use Yes and No.", "No return value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    writer.WriteLine();
                }
                stringShell = stringDirectoryProgramDatabase + stringSolution + "\\" + stringProgram + "." + stringResult + ".txt";
            }
        }
    }
}