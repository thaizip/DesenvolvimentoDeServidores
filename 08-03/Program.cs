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
Cliente c4 = new Cliente(4, "Sergio", "(16)9815-8293", e1);

Console.WriteLine(c1.getEndereco().getRua());
//c4.getEndereco().setRua("Dr.Jose de freitas Madeira");
//Console.WriteLine(c4.getNome() + " " + c4.getEndereco().getRua());
Console.WriteLine(c2.getNome() + " " + c2.getEndereco().getEnderecoCompleto());
Console.WriteLine(c3.getNome()+ " " + c3.getEndereco().getEnderecoCurto());

Carro carro = new Carro();
carro.Marca = "W";
carro.NumeroPortas = 4;
carro.NumeroRodas = 4;
carro.Cor = "preto";

Aviao aviao = new Aviao();
aviao.PortaInternas = 10;
aviao.NumeroPortas = 2;
aviao.NumeroRodas = 3;
aviao.Cor = "Branco";
aviao.QuantidadeAcentos = 150;
aviao.PagaImposto = false;

Bicicleta bicicleta = new Bicicleta();
bicicleta.PagaImposto= false;
bicicleta.Cor = "Vermelha";

Console.WriteLine(c1.getEndereco().getEnderecoCurto());
Console.WriteLine(aviao.ExibirDados());
Console.WriteLine(carro.ExibirDados());

List<Veiculos> listaVeiculos  = new List<Veiculos>();
listaVeiculos.Add(aviao);
listaVeiculos.Add(carro);
listaVeiculos.Add(bicicleta);

List<Cliente> listaCliente = new List<Cliente>();
listaCliente.Add(c1);
listaCliente.Add(c2);
listaCliente.Add(c3);
listaCliente.Add(c4);


foreach (Cliente item in listaCliente)
{
    Console.WriteLine(item.getNome() + "  Endereço: " + item.getEndereco().getEnderecoCurto());
}