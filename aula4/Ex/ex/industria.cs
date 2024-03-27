public class Industria{
    public string nome{get;set;}
    public string localizacao{get;set;}
    public int anoFundacao{get;set;}
    public List<linhaProducao> linhaProducoes = new List<linhaProducao>();

    public string ExibirInformacoes(){
        return "Nome: " + this.nome +
        "\nLocalizacao: " + this.localizacao +
        "\nAno Fundacao: " + this.anoFundacao;
    }
    public void AdicionarLinhaproduçao(linhaProducao lp){
        this.linhaProducoes.Add(lp);
    }
}