Console.WriteLine("Digite a porcentagem do IPI");
var porcentagemIPI = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o valor unitário da peça 1");
var valorUnitarioPecaUm = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de peças 1");
var quantidadePecaUm = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o valor unitário da peça 2");
var valorUnitarioPecaDois = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de peças 2");
var quantidadePecaDois = Convert.ToInt32(Console.ReadLine());

var total = (valorUnitarioPecaUm * quantidadePecaUm + valorUnitarioPecaDois * quantidadePecaDois) * (porcentagemIPI / 100.0 + 1);
Console.WriteLine(total);