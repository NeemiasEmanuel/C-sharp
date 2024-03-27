public class Maquina{
    public int id{get;set;}
    public string marca{get;set;}
    public string modelo{get;set;}
    
    public List<Produto> Produtos = new List<Produto>();


    public string exibirstatus(){
   return"id: " + this.id+
   "\nmarca: " + this.marca+
   "\nmodelo: " + this.modelo;
    }
 

    public void iniciarProducao(Produto p){
        this.Produtos.Add(p);
    }
}