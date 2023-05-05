using MyProject.MODEL;
using MyProject.DAL.DBContext;
using Microsoft.EntityFrameworkCore;

namespace MyProject.BLL
{
    public class ProjetoRepository
    {
        public static void Add(Projeto _projeto)
        {
            using(var dbContext = new CUsersSpeedSourceReposAv2MyprojectDalDatabaseDatabase1MdfContext())
            {
                dbContext.Add(_projeto);
                dbContext.SaveChanges();
            }
        }

        public static Projeto GetById(int Id)
        {
            using (var dbContext = new CUsersSpeedSourceReposAv2MyprojectDalDatabaseDatabase1MdfContext())
            {
                var projeto = dbContext.Projetos.Single(p=>p.Id == Id);
                return projeto;
            }
        }

        public static List<Projeto> GetAll()
        {
            using (var dbContext = new CUsersSpeedSourceReposAv2MyprojectDalDatabaseDatabase1MdfContext())
            {
                var projeto = dbContext.Projetos.ToList();
                return projeto;
            }
        }

        public static void Update(Projeto _projeto)
        {
            using (var dbContext = new CUsersSpeedSourceReposAv2MyprojectDalDatabaseDatabase1MdfContext())
            {
                var projeto = dbContext.Projetos.Single(p=>p.Id==_projeto.Id);
                projeto.Nome= _projeto.Nome;
                projeto.Gerente= _projeto.Gerente;
                projeto.DataInicio= _projeto.DataInicio;
                projeto.DataFim = _projeto.DataFim;
                projeto.Resumo= _projeto.Resumo;
                projeto.Status= _projeto.Status;
                dbContext.SaveChanges();
            }
        }

        public static void Excluir(Projeto _projeto)
        {
            using (var dbContext = new CUsersSpeedSourceReposAv2MyprojectDalDatabaseDatabase1MdfContext())
            {
                var projeto = dbContext.Projetos.Single(p=>p.Id == _projeto.Id);
                dbContext.Remove(projeto);
                dbContext.SaveChanges();
            }
        }
    }
}