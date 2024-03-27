/*
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
*/

Curso Curso = new Curso();
Turma turma = new Turma();

//atribuindo o estado do curso
Curso.nome = "ADS";
Curso.duracao = 2;

//atribuindo o estado da turma
turma.ano_formacao = 2025;
turma.turno = "Noturno";

//Adicionar a turma ao curso
Curso.AdicionarTurma(turma);

//Criar outra turma
turma = new Turma();
turma.ano_formacao = 2026;
turma.turno = "Manha";
Curso.AdicionarTurma(turma);
//Imprimir as turmas que foram adcionadas ao curso
foreach(var T in Curso.turmas){
    Console.WriteLine(T.turno + " " + T.ano_formacao);
}