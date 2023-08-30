namespace FirstLesson
{   
    class Program
    {
        static void Main(string[] args)
        {
            // 8-bit - vai de 0 até 255
            // trabalhar com arquivos
            //byte idade = 27;

            // 8-bit - permite valores negativos - vai de -128 até 127
            //sbyte nota = -30;

            // números inteiro
            // short/unshort - int/uint - long/ulong
            // u significa unsigned -  que significa que não permite sinal

            //float salario = 2.500f;
            //double salarioSemestral = 22.000;
            //decimal salarioAnual = 25.000m;

            // variável tipo booleano
            //bool usuarioCadastrado = false;

            // variável tipo char - unicode
            //char primeiraLetra = 'C';
            //var segundaLetra = 'D';

            // variável tipo string - cadeia de caracteres
            //string primeiroNome = "Nathan";

            // variável tipo var - sempre assume o tipo com o primeiro item assimilado a ele - precisamos definir o tipo
            //var texto = "Hello World";

            // variável tipo object - pode ser qualquer coisa
            //object idade1 = 25;
            //object nome = "Nathan";

            // void significa vazio - espaço vazio - retorno de método
            // null significa vazio também - definição de tipo

            // Nullable Type - possui valor nulo
            //int? idade2 = null;

            // alias - é um apelido que todo tipo do .NET tem, é recomendado utilizar ele
            //int idade4 = 25; // Alias
            //Int32 idade5 = 25; // Tipo

            // tipo built-in são valores padrão que sempre vem com o valor padrão quando declarados sem colocar um valor, nunca vem nulo
            //int => 0
            //float => 0
            //decimal => 0
            //bool => false
            //char => '\0'
            //string => ""



            //Conversão de Dados - existem dois tipos que veremos abaixo
            // Conversão Implícita - podem ser executadas apenas com passagem de dados e possuem tipos compatíveis
            //float valor = 25.8F;
            //int outro = 25;

            //valor = outro;

            // Conversão Explícita - temos que informar o tipo que estamos convertendo
            //int inteiro = 100;

            // colocamos o tipo antes da variável, sempre que tiver assim, está fazendo uma conversão explícita
            //uint inteiroSemSinal = (uint)inteiro; // Conversão Explícita

            // Converter um tipo para outro
            // Parse - converte caractere/string para qualquer tipo, se gerar incompatibilidade, gera um erro
            //int inteiro = int.Parse("100");

            // Convert - permite converter vários tipos de valor
            //int inteiro = 100;
            //float real = 25.4f;

            // real = inteiro; // 100.0f // Conversão Implícita
            // inteiro = (int)real; // 25 // Conversão Explícita

            // ToString() - converte para uma cadeia de caracteres
            //string valorReal = real.ToString();

            //inteiro = int.Parse("255"); // o número que vai converter usando 'Parse' precisa ser uma string ou caractere

            //inteiro = Convert.ToInt32(real); // 26 - ele arredonda o número se for converter para inteiro



            // Operadores Aritméticos
            //int soma = 25 + 22; // 47
            //int subtracao = 25 - 22; // 3
            //int multiplicacao = 25 * 22; // 550
            //int divisao = 22 / 5; // 4 - foi arredondado

            // para trocar a ordem de execução, utiliza-se o parênteses
            //int x = 2 + 2 * 2; // 6
            //int y = 2 + (2 * 2); // 6 - mesmo do anterior
            //int z = (2 + 2) * 2; // 8 - executou a soma primeiro



            //Operadores de Atribuição
            //int x = 0; // Atribuição
            //x += 5; // x = x + 5;
            //x -= 1; // x = x - 1;
            //x *= 10; // x = x * 10;
            //x /= 2; // x = x / 2;



            // Operadores de Comparação - ela sempre retorna true ou false
            // igual - ==
            // diferente - !=
            // maior que - >
            // menor que - <
            // maior ou igual a - >=
            // menor ou igual que - <=



            // Operadores Lógicos - são operações condicionais - sempre retorna true ou false
            // && - E/and - deve atender todas as condições
            // || - OU/or - se atender uma condição retorna verdadeiro
            // ! - NEGAÇÃO/not

            

            // Escrever na tela
            Console.WriteLine(Convert.ToBoolean(0));
        }
    }
}