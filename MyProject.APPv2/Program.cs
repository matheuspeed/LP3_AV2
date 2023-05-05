using MyProject.BLL;
using MyProject.MODEL;


Console.WriteLine("Iniciando primeira inserção\n");
Projeto j = new Projeto();
j.Nome = "projeto1";
j.Gerente = "Matheus";
j.DataInicio = new DateTime(2020, 07, 02, 22, 59, 59);
j.DataFim = new DateTime(2022, 07, 02, 22, 59, 59);
j.Resumo = "Projeto teste";
j.Status = "Concluido";

ProjetoRepository.Add(j);

Console.WriteLine(j.Nome + " inserido com sucesso\n");

Console.WriteLine("Iniciando segunda inserção\n");
Projeto j2 = new Projeto();
j2.Nome = "projeto2";
j2.Gerente = "José";
j2.DataInicio = new DateTime(2019, 07, 02, 22, 59, 59);
j2.DataFim = new DateTime(2021, 07, 02, 22, 59, 59);
j2.Resumo = "Projeto teste 2";
j2.Status = "Concluido";

ProjetoRepository.Add(j2);

Console.WriteLine(j2.Nome + " inserido com sucesso\n");


Console.WriteLine("Listando projetos cadastrados:\n");
List<Projeto> list = ProjetoRepository.GetAll();
foreach (Projeto proj in list)
{
    Console.WriteLine(proj.Nome+"\n");

}

Console.WriteLine("Lista de projetos cadastrados concluída\n");

Console.WriteLine("Removendo projetos\n");

list = ProjetoRepository.GetAll();
foreach (Projeto proj in list)
{
    ProjetoRepository.Excluir(proj);

}


Console.WriteLine("\nProjetos excluídos, listando projetos cadastrados:\n");

list = ProjetoRepository.GetAll();
foreach (Projeto proj in list)
{
    Console.WriteLine(proj.Nome + "\n");

}

Console.WriteLine("Lista de projetos cadastrados concluída\n");