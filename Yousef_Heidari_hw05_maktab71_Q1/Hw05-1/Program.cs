if (!File.Exists("File.txt"))
{
    var myFile=File.Create("File.txt");
    myFile.Close();
}
var path1 = @"Archive\NewFile.txt";
var path2 = @"c:\F.txt";//use this path instead path1 to check write access Exception
try
{
    File.Copy("File.txt", path1);
}
catch (DirectoryNotFoundException)
{
    Console.WriteLine("There is No Folder Named 'Archive'");
}
catch (IOException)
{
    Console.WriteLine("File Already Exist");

}
catch (UnauthorizedAccessException)
{
    Console.WriteLine("No access to write your file in this directory");
}
catch (Exception)
{
    Console.WriteLine("!!!Something Is Wrong!!!");
}