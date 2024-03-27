// ./universidade

public class Universidade
{
    public string nome{get; set;}
    public string localizacao{get; set;}
    public int anofundacao{get; set;}

    public List<Curso> cursos = new List<Curso>();

    public void AdicionarCurso(Curso c)
    {
        this.cursos.Add(c);
    }
}