// See https://aka.ms/new-console-template for more information
using _08_03;

Console.WriteLine("Hello, World!");

produto p1 = new produto(1, "Mouse sem fio", 59.90M);
Console.WriteLine(p1.getDescricao() + " " + p1.getValor());