//instanciar uma universidade
Universidade objUniversidade = new Universidade();
objUniversidade.nome = "Up";
objUniversidade.localizacao = "Ecoville";
objUniversidade.anofundacao = 1990;
//Criar o curso ADS e adicionar na universade
Curso objCurso = new Curso();
objCurso.nome = "ADS";
objUniversidade.AdicionarCurso(objCurso);

//Criar o curso BSI e adicionar na universade
objCurso = new Curso();
objCurso.nome = "BSI";
objUniversidade.AdicionarCurso(objCurso);


System.Console.WriteLine(objUniversidade.nome);

foreach (var curso in objUniversidade.cursos)
{
    System.Console.WriteLine(curso.nome);
}