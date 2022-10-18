//namespace organiza as classes no seu projeto puramente organização
//voce pode ter duas classes com o mesmo nome des de que tenham namespace diferentes
namespace CSharpFundamentos.models
{
    //classes são coisas q vc quer representar/representações: 
    public class Pessoa
    //nome de classes e metodos sempre em PascalCase
    //o nome da classe n precisa ser o mesmo do arquivo mas é recomendavel
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        //nunca abrevie que o nome da variavel seja muito grande
    
    //metodos=funções=ações
        public void Apresentar ()
        {
            // \n quebra linhas
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos");
        }
    }
}