using CS_EFCore_DbFirst.Models;
using CS_EFCore_DbFirst.DataAccess;
// .NET Core 3.0
using System.Text.Json;

IDataAccess<Department,int> deptDbAccess = new DepartmentDataAccess();

var departments = await deptDbAccess.GetAsync();

Console.WriteLine($"List of Depts" +
    $"{JsonSerializer.Serialize(departments)}");
//foreach (var item in departments)
//{
//    Console.WriteLine($"{item.DeptNo}  {item.DeptName} {item.Location} {item.Capacity}");
//}

// C# 9.0 10.0
//Department newDept = new() {DeptNo=801, DeptName="DEpt_801", Location="Area 51", Capacity=7878 };

//var createdDept = await deptDbAccess.CreateAsync(newDept);
Console.WriteLine();

//Console.WriteLine($"Newly Added Dept" +
//    $"{JsonSerializer.Serialize(createdDept)}");


Department deptToUpdate = new() {DeptNo=801, DeptName="DEpt_801", Location="Area 512", Capacity=7878 };
var updatededDept = await deptDbAccess.UpdateAsync(deptToUpdate.DeptNo, deptToUpdate);
Console.WriteLine($"Updated Dept" +
    $"{JsonSerializer.Serialize(updatededDept)}");

var res = await deptDbAccess.DeleteAsync(801);
Console.WriteLine($"Deleted Dept" +
    $"{JsonSerializer.Serialize(res)}");

Console.ReadLine();


