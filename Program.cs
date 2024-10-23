namespace TodoApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Instancia um objeto que vai "buildar" a aplica��o web
            var builder = WebApplication.CreateBuilder(args);

            //Usa a instancia builder para construir a aplicacao web
            var app = builder.Build();

            //Lan�a um comando de requisi��o HTTP para a rota especificada
            //app.MapXXX(rota:String, o que fazer:Funcao)
            //XXX - Nome do comando HTTP(Get,Put, Patch,Delete,...)
            app.MapGet("/", () => "Hello, World!");

            app.Run();
        }
    }
}
