// ./turma.cs

public class Turma
{
    public int anoFormação{get; set;}
    public string turno{get; set;}
    public string sala{get; set;}
    
    public List<Estudante> estudantes = new List<Estudante>();

//metodo adicionar estudante
//recebe um estudante e adiciona esse estudante na lista estudantes
public void AdicionarEstudante(Estudante e)
{
this.estudantes.Add(e);
}

}
