//Implementação de listas de objetos
class VariosEstudantes{
    static void Main(){

    List<Estudante> estudantes= new List<Estudante>();
    //Construir 3 estudantes e adicionar na lista "estudantes"
    Estudante aluno;//Intanciar o objeto aluno
    for (int i = 0; i < 3; i++)
    {
        aluno = new Estudante("R"+ i,"Nome"+i);//Construir um novo aluno
        estudantes.Add(aluno);//adiciona os novos alunos na lista "estudantes"
       // System.Console.WriteLine(aluno.Rgm + " " + aluno.Nome);
        
    }
    //imprimir lista 
    System.Console.WriteLine("Depois de adicionar os alunos na lista \nIniciando os dados dos alunos que estao na lista");
    foreach (var Estudante in estudantes)
    {
        System.Console.WriteLine(Estudante.Rgm + " " + Estudante.Nome);
    }
    }
}
