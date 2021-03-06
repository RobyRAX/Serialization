using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
  [Serializable]
  class Serial
  {
  public int ID;
  public String Name;
   static void Main(string[] args)
   {
    Serial obj = new Serial();
    obj.ID = 1;
    obj.Name = ".Net";

    IFormatter formatter = new BinaryFormatter();
    Stream stream = new FileStream(@"D:\My Docs\Matkul Faheem Semester 5\Serialzation\Test.txt",FileMode.Create,FileAccess.Write);

    formatter.Serialize(stream, obj);
    stream.Close();

    stream = new FileStream(@"D:\My Docs\Matkul Faheem Semester 5\Serialzation\Test.txt",FileMode.Open,FileAccess.Read);
    Serial objnew = (Serial)formatter.Deserialize(stream);

    Console.WriteLine(objnew.ID);
    Console.WriteLine(objnew.Name);

    Console.ReadKey();
  }
 }
}