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
		  string name;
		  int id;
		  string fileName = "/test.text";//the file path
		  StreamWriter fileWriter ;
		  FileStream output;
		  try {
		    output = new FileStream (fileName, FileMode.OpenOrCreate, FileAccess.Write);
		    fileWriter = new StreamWriter(output);
		    id = Convert.ToInt32(Console.ReadLine());
		    name = Console.ReadLine();
		    while(id != -1){
		      fileWriter.WriteLine(id + " "+ name);
		      id = Convert.ToInt32(Console.ReadLine());
		      name = Console.ReadLine();
		    }
		    fileWriter.Close();
		  }//try
		  catch (Exception e){
		    Console.WriteLine(e.Message);
		  }
		}//end Main
	}//End FileTestForm class
}//End FileTest namespace