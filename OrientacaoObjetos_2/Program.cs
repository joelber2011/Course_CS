using System;
using System.Globalization;

namespace Course{

    class Program{

        static void Main(String[] args){

            /*Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            System.Console.WriteLine("Entre com as medidas do triangulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("Entre com as medidas do triangulo Y");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double areaY = y.Area();

            System.Console.WriteLine("Área de x: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Área de y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY){

                System.Console.WriteLine("Maior área: X");
            }else{
                
                System.Console.WriteLine("Maior área: Y");
            }*/

            //==========================================================================================================

            
            /*Produto p = new Produto();

            System.Console.WriteLine("Entre os dados do produto:");
            System.Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            System.Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.Write("Quantidade em estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            System.Console.WriteLine("");
            System.Console.Write("Dados do produto: " + p);
            
            System.Console.WriteLine();
            System.Console.Write("Digite o número de produtos a ser adicionados ao estoque: ");
            int qtde = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.AdicionarProdutos(qtde);

            System.Console.WriteLine();
            System.Console.WriteLine("Dados atualizados: " + p);

            System.Console.WriteLine();
            System.Console.Write("Digite o número de produtos a ser removidos: ");
            qtde = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            p.RemoverProdutos(qtde);

            System.Console.WriteLine();
            System.Console.Write("Dados atualizados: " + p );*/

            //==========================================================================================================

            /*Retangulo r = new Retangulo();

            System.Console.WriteLine("Entre com a largura e altura do retangulo:");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine();
            System.Console.WriteLine("ÁREA: " + r.AreaRetangulo().ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine("PERÍMETRO: " + r.PerimetroRetangulo().ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine("DIAGONAL: " + r.DiagonalRetangulo().ToString("F2", CultureInfo.InvariantCulture));*/

            //========================================================================================================

            Funcionario f = new Funcionario();

            System.Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            System.Console.Write("Salário bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine();
            System.Console.Write("Funcionário: " + f.Nome + ", R$ " + f.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));

            System.Console.WriteLine();
            System.Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            f.AumentarSalario(porc);

            System.Console.WriteLine();
            System.Console.WriteLine("Dados atualizados: " + f.Nome + ", R$ " + f.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));
            



        }
        
    }
    
}