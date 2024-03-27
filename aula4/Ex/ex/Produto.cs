public class Produto{
    public string nome {get;set;}
    public int codigo {get;set;}
    public double preco{get;set;}

    public string ExibirInformacoes(){
    return "Nome: " + this.nome+
    "\nCodigo: " + this.codigo+
    "\nPreco: " + this.preco;
    }
    public void atualizarPreco(double novoPreco){
        this.preco = novoPreco;
    }

}