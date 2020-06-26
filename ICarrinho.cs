namespace Aula26Interfaces
{
    public interface ICarrinho
    {

        //criamos uma espécie de "contrato" para deixar obrigatória a
        //implementação de todos os métodos e estruturas que herdarem 
        //dessa interface

        //C R U D
        void Create(Product product);

        void Read();

        void Update(int _code, Product product);

        void Delete(Product product);


    }
}