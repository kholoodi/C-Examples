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
		 
		  string fileName = "e:/test.text";//the file path
		  StreamReader fileReader ;
		  FileStream input;
		  try {
		    input = new FileStream (fileName, FileMode.Open, FileAccess.Read);
		    fileReader = new StreamReader(input);
		    string info = Console.ReadLine();
		   
		    while(info != null){
		      Console.WriteLine(info);
		      info = Console.ReadLine();
		    }
		    fileReader.Close();
		  }//try
		  catch (Exception e){
		    Console.WriteLine(e.Message);
		  }
		}//end Main
	}//End FileTestForm class
}//End FileTest namespace