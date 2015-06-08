// page 12
Task<int> t = Task.Run(() =>
{
return 42;
}).ContinueWith((i) =>
{
return i.Result * 2;
});
Console.WriteLine(t.Result); // Displays 84
