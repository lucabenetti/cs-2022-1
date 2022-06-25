Console.WriteLine("Digite os anos de sua idade");
var anos = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite os meses de sua idade");
var meses = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite os dias de sua idade");
var dias = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{anos} anos, {meses} meses e {dias} dias = {(anos * 365) + (meses * 30) + dias} dias");