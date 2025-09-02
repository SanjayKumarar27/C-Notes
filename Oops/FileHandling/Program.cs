namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Get number of dirves
            DriveInfo[] drives = DriveInfo.GetDrives(); 
            Console.WriteLine($"Number  {drives.Length}");

            DirectoryInfo dir = new DirectoryInfo(@"C:\Demo");
            DirectoryInfo[] directories = dir.GetDirectories();
            Console.WriteLine("Number of directories in C:\\");
            Console.WriteLine(directories.Length);

            Console.WriteLine("Directories Are :");
            foreach (DirectoryInfo d in directories) {
                      Console.WriteLine(d.Name);
            }


            //get number of files in 

            FileInfo[] files = dir.GetFiles();
            Console.WriteLine("Number of files in C:\\");
            Console.WriteLine(files.Length);
            Console.WriteLine("Files Are :");
            foreach (FileInfo f in files)
            {
                Console.WriteLine(f.Name);
            }
            */


            /*
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {

            fs = new FileStream(@"C:\Demo\myfil1e.txt", FileMode.CreateNew);//excetion works only when filemode is
                                                                            //open if its CreateNew then it create new file
                sw = new StreamWriter(fs);
            //sw.WriteLine("Hello KPMG");
            //StreamReader sr = new StreamReader(fs);
            StreamReader sr=new StreamReader(fs);
           string line= sr.ReadLine();
            while(line!=null)
            {
                Console.WriteLine(line);
                line= sr.ReadLine();
            }
            
            Console.WriteLine(sr.ReadToEnd());
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }finally
            {
                if(sw!=null)
                sw.Close();
                if(fs!=null)
                fs.Close();
            }
          
            Console.WriteLine("File Created");
            */
            //using static method without creating object
            //File.WriteAllText("C:\\Demo\\myfile2.txt", "Demo t Easy method");\
            //Append the text to file alredy ther
            //File.AppendAllText("C:\\Demo\\myfile2.txt", "\n Demo to append the text");
            //string content = File.ReadAllText("C:\\Demo\\myfile2.txt");
            //Console.WriteLine(content);


            //Write the file using binary Write and read using binary reader

            BinaryWriter bw = null;
            BinaryReader br = null; 
            FileStream fs = null;
            try
            {
                fs = new FileStream("C:\\Demo\\myfile3.txt", FileMode.Create);
                bw = new BinaryWriter(fs);
                bw.Write("Hello KPMG");
                bw.Write(123);
                bw.Write(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (bw != null)
                    bw.Close();
                if (fs != null)
                    fs.Close();
            }
            try
            {
                fs = new FileStream("C:\\Demo\\myfile3.txt", FileMode.OpenOrCreate);
                br = new BinaryReader(fs);
                Console.WriteLine(br.ReadString());
                Console.WriteLine(br.ReadInt32());
                Console.WriteLine(br.ReadBoolean());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (br != null)
                    br.Close();
                if (fs != null)
                    fs.Close();
            }

        }
    }
}
