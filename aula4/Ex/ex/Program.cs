Industria ind = new Industria();
linhaProducao Linha = new linhaProducao();
Maquina maquina = new Maquina();
Produto produto;
ind.nome = "Gauss";
ind.localizacao = "Cic";
ind.anoFundacao = 1995;

Console.WriteLine("Empresa:\n" + ind.ExibirInformacoes());

//crio linha producao 1 
Linha.numero = 1;
Linha.tipo = "medidor";
Linha.quantidade = 50;

    maquina.id = 1;
    maquina.marca = "marca1";
    maquina.modelo = "Maquina1";
    Linha.AdicionarMaquina(maquina);
        produto = new Produto();
        produto.nome = "Ga001";
        produto.codigo = 1;       
        produto.preco = 120.20;
        produto.atualizarPreco(80.80);
        maquina.iniciarProducao(produto);
        Console.WriteLine(produto.ExibirInformacoes());

    maquina = new Maquina();
    maquina.id = 2;
    maquina.marca = "marca2";
    maquina.modelo = "Maquina2";

    Linha.AdicionarMaquina(maquina);
        produto = new Produto();
        produto.nome = "Ga002";
        produto.codigo = 2;       
        produto.preco = 230;
        maquina.iniciarProducao(produto);
        Console.WriteLine(produto.ExibirInformacoes());

foreach(var M in Linha.maquinas){
    Console.WriteLine(M.exibirstatus());
}
ind.AdicionarLinhaproduçao(Linha);



//Console.WriteLine(Linha.exibirDetalhes());

Linha = new linhaProducao();

Linha.numero = 2;
Linha.tipo = "regulador";
Linha.quantidade = 100;
ind.AdicionarLinhaproduçao(Linha);
  maquina = new Maquina();
  maquina.id = 3;
    maquina.marca = "marca3";
    maquina.modelo = "Maquina3";
    Linha.AdicionarMaquina(maquina);
        produto = new Produto();
        produto.nome = "Ga003";
        produto.codigo = 3;       
        produto.preco = 20.50;
        maquina.iniciarProducao(produto);
        Console.WriteLine(produto.ExibirInformacoes());

    maquina = new Maquina();
    maquina.id = 4;
    maquina.marca = "marca4";
    maquina.modelo = "Maquina4";
    Linha.AdicionarMaquina(maquina);
        produto = new Produto();
        produto.nome = "Ga004";
        produto.codigo = 4;       
        produto.preco = 40;
        maquina.iniciarProducao(produto);
        Console.WriteLine(produto.ExibirInformacoes());
        
foreach(var M in Linha.maquinas){
    Console.WriteLine(M.exibirstatus());
}

//Console.WriteLine(Linha.exibirDetalhes());

foreach(var L in ind.linhaProducoes){
    Console.WriteLine(L.exibirDetalhes());
}
