Console.WriteLine("Digite o valor do salário mínimo");
var salarioMinimo = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o valor de seu salário");
var salarioUsuario = Convert.ToDecimal(Console.ReadLine());

var quantidadeSalariosMinimos = salarioUsuario / salarioMinimo;
Console.WriteLine($"{quantidadeSalariosMinimos} salário(s) mínimo(s)");