// See https://aka.ms/new-console-template for more information
using _08_03;

Console.WriteLine("Hello, World!");

Produto p1 = new Produto(1, "Mouse sem fio", 59.90M);
Console.WriteLine(p1.getDescricao() + " " + p1.getValor());

//Cliente pessoa1 = new Cliente(1, "Thais", "(16)99623-3113");
//Console.WriteLine(pessoa1.GetNome() + " " + pessoa1.GetTelefone());

Endereco e1 = new Endereco("Avelino Boselli", "162", "15906-300", "Jardim Sobral", "Taquaritinga", "SP");

Cliente c1 = new Cliente(1, "Thais", "(16)99623-3113", e1);
Cliente c2 = new Cliente(2, "Raul", "(16)99679-3978", e1);
Cliente c3 = new Cliente(3, "Gustavo", "(16)99758-1346", e1);
Cliente c4 = new Cliente(4, "Samuel", "(16)9815-8293", e1);

Console.WriteLine(c1.getEndereco().getRua());
//c4.getEndereco().setRua("Dr.Jose de freitas Madeira");
//Console.WriteLine(c4.getNome() + " " + c4.getEndereco().getRua());
Console.WriteLine(c2.getNome() + " " + c2.getEndereco().getEnderecoCompleto());
Console.WriteLine(c3.getNome()+ " " + c3.getEndereco().getEnderecoCurto());