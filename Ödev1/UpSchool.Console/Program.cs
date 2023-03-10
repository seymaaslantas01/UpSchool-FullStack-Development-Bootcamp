using UpSchool.Console.Domain;
using UpSchool.Console.Enums;


#region
/*Student student = new Student();
student.FirstName = "Şeyma";
student.LastName = "Aslantaş";
student.TCID = "49222711869";

student.FullName = "Şeyma Aslantaş";

Console.WriteLine($"{student.FirstName} {student.LastName} {student.TCID}");

Teacher teacher = new Teacher();
teacher.FirstName = "Alper";
teacher.LastName = "Tunga";

Console.WriteLine($"{teacher.FirstName} {teacher.LastName}");

Console.WriteLine(student.FullName);//with get
Console.WriteLine(student.GetFullName());//with method
Console.WriteLine(student.GetFullName());
Console.WriteLine(student.GetFullName());
Console.WriteLine(student.GetFullName());
//Console.WriteLine(student.FinalNotes());
Console.WriteLine($"{student.FirstName} {student.LastName} {student.TCID}");
Console.WriteLine($"{student.FirstName} {student.LastName} {student.TCID}");
Console.WriteLine($"{student.FirstName} {student.LastName} {student.TCID}");

Console.ReadLine();*/
#endregion

#region
//int sayi1 = 15;

//Console.WriteLine(sayi1);

//int sayi2 = sayi1;

//sayi1 = 25;

//Console.WriteLine(sayi1);

//Console.WriteLine(sayi2);

//Student student1 = new Student();

//student1.FirstName = "Alper";
//student1.LastName = "Tunga";

//string name = "Maxwell";

//string surName = name;

//name = "Roberto Carlos";

//Student student2 = new Student(student1.FirstName,student1.LastName);

//student1.FirstName = student2.FirstName;

//student2.FirstName = "Tuba";

//Console.WriteLine(name);

//Console.WriteLine(surName);

//Console.ReadLine();

//var accessControlLog = new AccessControlLog();

//if (accessControlLog.AccessType == AccessType.FACE)
//{


//}

#endregion

const string filePath = "C:\\Users\\User\\Desktop\\accessControlLog.txt"; 
var logsText = File.ReadAllText(filePath);
var splitLines = logsText.Split('\n',StringSplitOptions.RemoveEmptyEntries);
//splitLines.ToList().ForEach(line =>Console.WriteLine(line));

List<AccessControlLog> logs = new List<AccessControlLog>();

foreach(var line in splitLines.Skip(1))
{
    var logFields = line.Replace(" ",string.Empty)
        .Replace("\r", string.Empty)
        .Split("---",StringSplitOptions.RemoveEmptyEntries);

    var accessControlLog = new AccessControlLog()
    {
        UserId = Convert.ToInt32(logFields[0]),
        DeviceSerialNo = logFields[1],
        AccessType = AccessControlLog.ConvertToAccessType(logFields[2]),
        Date = Convert.ToDateTime(logFields[3]),

    };

    logs.Add(accessControlLog);
}


logs.ForEach(log => Console.WriteLine($"{log.UserId} - {log.DeviceSerialNo} - {log.AccessType} - {log.Date}"));

Console.WriteLine("****************************** J U S T   C A R D ***********************");

var cardLogs = logs.Where(log => log.AccessType == AccessType.CARD).ToList();

cardLogs.ForEach(cardLog => Console.WriteLine($"{cardLog.UserId} - {cardLog.DeviceSerialNo} - {cardLog.AccessType} - {cardLog.Date}"));