public class Program
{
    public static void Main(string[] args)
    {

        int valorUsuario = 0;
        int valorConta = 4564;

        try 
        {
            var totalPorPessoa = valorConta / valorUsuario;
            Console.WriteLine(totalPorPessoa.ToString());
        } catch (Exception ex) {
            Console.WriteLine("Não foi possível executar a operação");
        } finally
        {
            Console.WriteLine("Execução encerrou");
        }
        

    }
}