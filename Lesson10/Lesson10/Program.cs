using System.IO;
using Lesson10;
// See https://aka.ms/new-console-template for more information

const string FILENAME = "..\\..\\..\\files\\file.txt";

Console.WriteLine("Hello, World!");

List<string> names = new() {  "sara","esti","michal","nomy"};
if (File.Exists(FILENAME)) // האם הקובץ קים
{
    Console.WriteLine("file exist");
    File.Copy(FILENAME,Filenames.NewName  ) ;
}
else
{
    // פתיחה של קובץ אם הקובץ לא קים יוצר.
    //צריך לקבוע אם רוצים להוסיף טרו או לדרוס פלס
    StreamWriter writer = new(FILENAME, true);
    //foreach (var item in names)
    //{
    //    writer.WriteLine(item);
    //}
    names.ForEach(n => writer.WriteLine(n));
    writer.Close();


}
StreamReader reader = new(FILENAME);
do
{
    string? line = reader.ReadLine();
    Console.WriteLine(line);
} while (!reader.EndOfStream);

Directory.CreateDirectory(@"..\..\..\files\folder");
var arr=Directory.GetFiles("..\\..\\..\\files");
arr.ToList().ForEach(f => Console.WriteLine(f));
DirectoryInfo dir = new DirectoryInfo("..\\..\\..\\files");
 dir.GetFiles().ToList()
    .ForEach(f => Console.WriteLine($"{f.Name} , {f.Length }"));
//FileInfo f = new FileInfo(FILENAME);

 
Console.WriteLine("success");
