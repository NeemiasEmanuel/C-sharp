public class linhaProducao{
    public int numero{get;set;}
    public string tipo{get;set;}
    public int quantidade{get;set;}
    public List<Maquina> maquinas = new List<Maquina>();

    public string exibirDetalhes(){
    return "Numero: " + this.numero+
    "\nTipo: " + this.tipo+
    "\nQuantidade: " + this.quantidade + "p/h";
    }

    public void AdicionarMaquina(Maquina M){
        this.maquinas.Add(M);
    }
}