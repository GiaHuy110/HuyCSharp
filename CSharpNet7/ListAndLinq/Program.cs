using System.Collections.Generic;
using System.Transactions;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

List<Student> student = new()
{
    new Student() {Id = 1, Name = "Trần Gia Huy", Gender = true, Dob = new DateTime(2003, 1, 1) },
    new Student() {Id = 2, Name = "Trần Công Thiện", Gender = true, Dob = new DateTime(2003, 5, 6) },
    new Student() {Id = 3, Name = "Phan Trung Nghị", Gender = true, Dob = new DateTime(2003, 6, 12) },
    new Student() {Id = 4, Name = "Ngô Minh Mẫn", Gender = true, Dob = new DateTime(2003, 11, 1) },
    new Student() {Id = 5, Name = "Nguyễn Đúc Mạnh", Gender = true, Dob = new DateTime(2003, 10, 1) }
};
// duyệt qua list bằng vòng lặp foreach
foreach (var stu in student)
{
    Console.WriteLine(stu);
}
// vòng lặp foreach sẽ chuyển thành 
IEnumerator<Student> enu = student.GetEnumerator();
while (enu.MoveNext())
{
    Console.WriteLine(enu.Current.ToString);
}
// duyệt qua list 
student.ForEach(Console.WriteLine);
// Linq = Language intergrated query
// Linq to sql => thay thế cú pháp sql trong c#
// Linq to opject => console
// sql => select from where group by having oder by
// c# => FROM WHERE GROUP BY HAVING ODER BY... SELECT
// style 1 => query syntax => dựa theo cú pháp của sql, dễ học, dễ dùng
// style 2 => method syntax => dựa theo lamda => khó học, khó dùng nhưng cực nhanh
// hiển thị toàn bộ thông tin sinh viên trong list, với điều kiện id sinh viên phải lớn hơn 2.

foreach (var stu in student)
{
    if (stu.Id < 4)
    {
        Console.WriteLine(stu);
    }
}

// ====== style 1 của Linq
foreach (var st in from stu in student where stu.Id > 4 select student)
{
    Console.WriteLine(st);
}

// ====== style 2 của Linq : method syntax
var t = student.Where(stu => stu.Id > 2);
foreach (var stu in student)
{
    Console.WriteLine(stu);
}
// ===== style 2 của Linq : method syntax rút gọn 
foreach (var stu in student.Where(stu => stu.Id > 2))
{
    Console.WriteLine(stu);
}
// kết hợp với foreach của list 
student.Where(stu => stu.Id > 2).ToList().ForEach(Console.WriteLine);

var s = from stu in student select stu;
IEnumerable<Student> i = from stu in student select stu;

// với linq to object 
// khi sử dụng query syntax hay method syntax thì trả về không phải là list,
// hay array => IEnumeraable (con của ienumarator duyệt qua collection: list, array, dictionaary, hashmap..)
// dùng để duyệt qua linq to object.

//student.ForEach(Console.WriteLine);
//t.ToList().ForEach(Console.WriteLine);

foreach (var stu in student)
{
    if (stu.Id > 2)
    {
        Console.WriteLine(stu);
    }
}
// ============= phương thức có sẵn từ list (áp dụng lamda)
student.ForEach(stu =>
{
    if (stu.Id > 2)
    {
        Console.WriteLine(stu);
    }
});
// ============ linq 
student.Where(stu => stu.Id > 2).ToList().ForEach(Console.WriteLine);
//
var r = from stu in student where stu.Id > 2 select stu;
t.ToList().ForEach(Console.WriteLine);
// linq
// linq => method syntax

var y = from stu in student
         where stu.Id > 2
         select new
         {
             Infor = $"{stu.Id} : {stu.Name}",
             stu.Gender,
             Birthday = stu.Dob
         };
y.ToList().ForEach(i => Console.WriteLine(i.Birthday));
// method syntax 
student.Where(stu => stu.Id > 2)
    .Select(stu => new
            {
    Infor = $"{stu.Id} : {stu.Name}",
})
.ToList()
.ForEach(Console.WriteLine);
// sắp xếp trật tự:
student.Where(stu => stu.Id > 2)
    .OrderBy(stu => stu.Id)
    .ThenBy(stu => stu.Name)
    .ToList()
    .ForEach(Console.WriteLine);
// đúng là như này 
student.Where(stu => stu.Id > 2)
    .OrderByDescending(stu => stu.Id)
    .ThenByDescending(stu => stu.Name)
    .ToList()
    .ForEach(Console.WriteLine);

student.Select(stu => stu)
    .Where(stu => stu.Id >2)
    .ToList()
    .ForEach(Console.WriteLine);
student.Where(stu => stu.Id > 2)
    .Select(stu => stu)
    .ToList()
    .ForEach(Console.WriteLine);
