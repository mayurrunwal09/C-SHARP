using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;
namespace filestream
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //             FileStream fs = new FileStream("C:\\Users\\TGSUser070\\Desktop\\Mayur\\filestream\\ab4.txt", FileMode.OpenOrCreate);
            //    //   fs.WriteByte(65);  ///print A which is a byte no of A


            //    for (int i = 65;i<= 90; i++)
            //       {
            //           fs.WriteByte((byte)i);
            //       }
            //      fs.close();


            //     fs.WriteByte(65);
            //     int i = 0;
            //     while((i = fs.ReadByte())!=-1)
            //        {
            //       Console.WriteLine((char)i);
            //     }
            //      fs.close();



            //stream writer
            //  StreamWriter sw = new StreamWriter(fs);  
            //  sw.WriteLine("hello c#");
            //    sw.Close();


            //stream reader to all line
            //       StreamReader sr = new StreamReader(fs);  
            //       string line = sr.ReadLine();
            //       Console.WriteLine(line);
            //         fs.close();


            //stream reader to all line
            //          StreamReader sr = new StreamReader(fs);   
            //          string line = "";
            //          while((line = sr.ReadLine()) != null)
            //          {
            //              Console.WriteLine(line);
            //          }
            //          fs.close();


            //c# text writer
            //    using (TextWriter writer = File.CreateText("C:\\Users\\TGSUser070\\Desktop\\Mayur\\filestream\\ab5.txt")) 
            //    {
            //        writer.WriteLine("hello ");
            //        writer.WriteLine("c#");
            //    }


            //text reader - read to all data
            //        using (TextReader reader = File.OpenText("C:\\Users\\TGSUser070\\Desktop\\Mayur\\filestream\\ab6.txt"))  
            //
            //        {
            //            Console.WriteLine(reader.ReadToEnd());
            //        }


            //C# BinaryWriter Example


            //    WriteBinaryFile();
            //    ReadBinaryFile();
            //    Console.ReadKey();
            //    string filename = "C:\\Users\\TGSUser070\\Desktop\\Mayur\\filestream\\ab7.txt";
            //    using (BinaryWriter write = new BinaryWriter(File.Open(filename,FileMode.Create)))
            //    {
            //        write.Write(2.5);
            //        write.Write("this is string data");
            //        write.Write(true);
            //    }
            //    Console.WriteLine("data written successfully");



            //          //C# BinaryReader Example
            //         
            //          Console.WriteLine("file created successfully");
            //      }
            //          static void WriteBinaryFile()
            //      {
            //          using (BinaryWriter writer = new BinaryWriter(File.Open("C:\\Users\\TGSUser070\\Desktop\\Mayur\\filestream\\ab8.txt", FileMode.Create)))
            //          {
            //              writer.Write(12.5);
            //              writer.Write("this is string data");
            //              writer.Write(true);
            //          }
            //      }
            //      static void ReadBinaryFile()
            //      {
            //          using (BinaryReader reader = new BinaryReader(File.Open("C:\\Users\\TGSUser070\\Desktop\\Mayur\\filestream\\ab8.txt", FileMode.Open)))
            //          {
            //              Console.WriteLine("Double Value : " + reader.ReadDouble());
            //              Console.WriteLine("String Value : " + reader.ReadString());
            //              Console.WriteLine("Boolean Value : " + reader.ReadBoolean());
            //          }
            //          
            //      }

            string text = "hello welcome to c# \n " +
                "it is nice programing language \n" +
                "it is created by microsoft  ";
            
        }
    }
}
