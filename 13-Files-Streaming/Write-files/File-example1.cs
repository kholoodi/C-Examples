using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileTest
{
	public class FileTestForm
	{
		public static void Main(string[] args)
		{
		  string fileName ="/welcom.txt"; //the file path
		  if (File.Exists(fileName)){
		    GetInfromation(fileName);
		    StreamReader stream = null; //declare StreamReader
		    try{
		      stream = new StreamReader(fileName);
		      string info = stream.ReadToEnd();
		      Console.WriteLine(info);
		    }
		    catch(IOException){
		      Console.WriteLine("Error Reading from file");
		    }
		  }
		    else if (Directory.Exists(fileName)){
		      GetInformation(fileName);
		      string[] directoryList = Directory.GetDirectory(fileName);
		      Console.WriteLine("Directory Contents:\n");
		      foreach (var directory in directoryList)
		      Console.WriteLine(directory  +"\n");
		    }
		    else
		    Console.WriteLine("Does not exist", "File Error");
		  }//end Main
		  private static void GetInformation(string fileName){
		    Console.WriteLine(fileName + "exsist");
		    Console.WriteLine("Created: "  + GetCreationTime(fileName));
		    Console.WriteLine("Last modified: "  + GetLastWriteTime(fileName));
		    Console.WriteLine("Last accessed: "  + GetLastAccessTime(fileName));
		}
	}//End FileTestForm class
}//End FileTest namespace