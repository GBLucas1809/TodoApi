using Microsoft.EntityFrameworkCore;

namespace TodoApi
{
    public class TodoDb : DbContext
    {
        //Cria um construtor passando como referência
        //uma variável de opções para o contexto do
        //banco de dados
        public TodoDb(DbContextOptions<TodoDb> options)
        : base(options){ }//O comando base() é
                          //como se fosse o super() do Java
                          //Pega o construtor da classe-pai

        public DbSet<Todo> Todos => Set<Todo>();
    }
}
