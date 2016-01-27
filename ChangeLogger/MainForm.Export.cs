using System.Collections.Specialized;
using System.Diagnostics;
namespace ChangeLogger
{
    partial class MainForm
    {
        /// <summary>
        /// Export to txt file's.
        /// </summary>
        void ExportConversion(int OutputDegree, string OK, string Cancel)
        {
            StringSolution = ToolstripButtonListSolution.Text;
            StringProgram = ToolstripButtonListProgram.Text;
            StringOutput = null;
                                
            using (System.IO.StreamWriter writer = System.IO.File.CreateText(stringDirectoryCurrent + "\\Database\\" + StringSolution + "\\" + StringProgram + "." + OutputDegree + ".txt")) {
                //start header of file
                writer.WriteLine(StringSolution.ToUpper() + " - " + StringProgram);
                writer.WriteLine();
        
                //get array of versions in program
                try {
                    ArrayProgram = System.IO.Directory.GetDirectories(stringDirectoryCurrent + "\\Database\\" + StringSolution + "\\" + StringProgram, "*", System.IO.SearchOption.TopDirectoryOnly);
                } catch (System.Exception e) {
                }
                           
                //Counting leading trails to remove
                intCharacterLength = 0;
                foreach (int number in stringDirectoryCurrent + "\\Database\\" + StringSolution + "\\" + StringProgram + "\\") {
                    intCharacterLength = intCharacterLength + 1;
                }
        
                //each version>get files
                string stringLine;
                foreach (string line in ArrayProgram) {
                    stringLine = line.Remove(0, intCharacterLength);
                    try {
                        ArrayVersion = System.IO.Directory.GetFiles(stringDirectoryCurrent + "\\Database\\" + StringSolution + "\\" + StringProgram + "\\" + stringLine, "*", System.IO.SearchOption.TopDirectoryOnly);
                    } catch (System.Exception e) {
                    }
        
                    //Version Number
                    writer.WriteLine("[" + line + "]");
                    foreach (string file in ArrayVersion) {
                        if (OutputDegree == 6) { //Full
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
                        } else { // Normal
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
                        }
                    }
                    writer.WriteLine();
                }
                string StringShell = stringDirectoryCurrent + "\\Database\\" + StringSolution + "\\" + StringProgram + "." + OutputDegree + ".txt";
                System.Diagnostics.Process.Start("notepad.exe", StringShell);
            }
        }
    }
}