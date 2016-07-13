using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao, operacao = 0;
            String cliente = "", produto = "";
            List<String> LisCli = new List<string>();
            ArrayList ListProduto = new ArrayList();

            Console.Clear();
            Console.WriteLine("1- Cliente");
            Console.WriteLine("2- Produto");
            Console.WriteLine("3- Sair");

            opcao = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            do
            {
                switch (opcao)
                {

                    case 1:
                        Console.WriteLine("1- Cadastrar Cliente");
                        Console.WriteLine("2- Consultar Cliente");
                        Console.WriteLine("3- Consultar Cliente por Nome");
                        Console.WriteLine("4- Remover Cliente por Nome");
                        operacao = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("1- Cadastrar Produto");
                        Console.WriteLine("2- Consultar Produto");
                        Console.WriteLine("3- Consultar Produto por Nome");
                        Console.WriteLine("4- Remover Produto por Nome");
                        operacao = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Saindo...");

                        break;
                    default:
                        Console.WriteLine("Operação Inválida!");
                        break;
                }
                Console.Clear();
                if (opcao == 1)
                {
                    if (operacao == 1)
                    {
                        Console.WriteLine("Informe o nome do Cliente:");
                        cliente = Console.ReadLine();
                        LisCli.Add(cliente);
                        Console.Clear();
                        Console.WriteLine("Cliente cadastrado com SUCESSO!");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (operacao == 2)
                    {
                        foreach (String cli in LisCli)
                        {

                            Console.WriteLine("Nome do Cliente: " + cli);
                        }
                        if (LisCli.Count <= 0)
                        {
                            Console.Write("Não existe cliente na lista");

                        }

                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (operacao == 3)
                    {
                        Console.WriteLine("informe o nome para pesquisa");
                        String nomeAux;
                        nomeAux = Console.ReadLine();
                        foreach(String cli in LisCli){
                            if(nomeAux.Equals(cli)){
                                Console.Clear();
                                Console.WriteLine("Achou mizeravi: "+nomeAux);
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Não existe cliente cadastrado com esse nome: " + nomeAux);
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }

                    }
                    else if(operacao == 4){
                        Console.WriteLine("informe o nome para Remoção");
                        String nomeAux;
                        nomeAux = Console.ReadLine();
                        foreach (String cli in LisCli)
                        {
                            if (nomeAux.Equals(cli))
                            {
                                LisCli.Remove(cli);
                                Console.Clear();
                                Console.WriteLine("Cliente " + nomeAux + " removido com SUCESSO!");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Não existe cliente cadastrado com esse nome: " + nomeAux);
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }

                    }else
                    {
                        Console.Write("Inválido");
                        Console.ReadKey();
                    }
                }
                else if (opcao == 2)
                {
                    if (operacao == 1)
                    {
                        Console.WriteLine("Informe o nome do Produto:");
                        produto = Console.ReadLine();
                        ListProduto.Add(produto);
                        Console.Clear();
                        Console.WriteLine("Produto cadastrado com SUCESSO!");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (operacao == 2)
                    {
                        foreach (String prod in ListProduto)
                        {

                            Console.WriteLine("Nome do Produto: " + prod);
                        }

                        if (ListProduto.Count <= 0)
                        {
                            Console.Write("Não existe Produto na lista");

                        }
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (operacao == 3)
                    {
                        Console.WriteLine("Informe a descrição do produto");
                        String prodAux=Console.ReadLine();
                        foreach(String prod in ListProduto){
                            
                            if(prodAux.Equals(prod)){
                                Console.Clear();
                                Console.WriteLine("Produto encontrado: " + prodAux);
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Produto " + prodAux + " não encontrado ");
                                Console.ReadKey();
                                Console.Clear();
                            }

                        }
                    }
                    else if (operacao == 4)
                    {

                        Console.WriteLine("Informe a descrição do produto para a Remoção");
                        String prodAux = Console.ReadLine();
                        foreach (String prod in ListProduto)
                        {

                            if (prodAux.Equals(prod))
                            {
                                ListProduto.Remove(prod);
                                Console.Clear();
                                Console.WriteLine("Produto removido com SUCESSO!: " + prodAux);
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Produto " + prodAux + " não encontrado ");
                                Console.ReadKey();
                                Console.Clear();
                            }

                        }

                    }else
                    {
                        Console.WriteLine("Inválido");
                        Console.ReadKey();

                    }
                }

            } while (opcao != 5);
            {
                Console.WriteLine("Opção Inválida");
                Console.ReadKey();
            }
        }
    }
}
