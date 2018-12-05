using System;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {

            
            String file = @"/Users/yousif/Downloads/cat.jpg";
            String copy = @"/Users/yousif/Desktop/copy.jpg";

            allBytes(file, copy);
            singleByteCopy(file, copy);
            bufferByteCopy(file,copy);
            
        }


        // reads all the bytes from the source file, and writes them all to the destination file
        public static void allBytes(String source, String dest){
            Byte[] bytes = File.ReadAllBytes(source);
            File.WriteAllBytes(dest, bytes);

        }

        // reads a single byte at a time from the source file and writes it to the destination file
        public static void singleByteCopy(String source, String dest){
            FileStream inputStream = new FileStream(source, FileMode.Open);
            FileStream outputStream = new FileStream(dest, FileMode.Create);

            while(true){
                int data = inputStream.ReadByte();
                if(data == -1){
                    break;
                }
                outputStream.WriteByte((byte)data);
            }

            outputStream.Flush();
            outputStream.Close();

            inputStream.Close();    
        }
        
        // reads bytes from the source file 100 bytes at a time (into a buffer)
        // and writes the buffer to the destination file
        public static void bufferByteCopy(String source, String dest){

            FileStream inputStream = new FileStream(source, FileMode.Open);
            FileStream outputStream = new FileStream(dest, FileMode.Create);

            while(true){
                Byte[] buffer = new Byte[100];
                int numBytesRead = inputStream.Read(buffer,0, 100);
                if(numBytesRead == 0){
                    break;
                }
                outputStream.Write(buffer, 0, numBytesRead);
            }

            outputStream.Flush();
            outputStream.Close();

            inputStream.Close();    
        }
    }
}
