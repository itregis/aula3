using CursoConsoleApplication;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace CursoConsole
{
    class Program
    {

        static void Main(string[] args)
        {
            inicio:
            
            int opcao, operacao = 0;
            Cliente cliente = new Cliente();
            List<Cliente> LisCli = new List<Cliente>();
            Produto produto = new Produto();
            List<Produto> ListProduto = new List<Produto>();

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
                        Console.WriteLine("5- Retornar ao Menu Principal");
                        operacao = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("1- Cadastrar Produto");
                        Console.WriteLine("2- Consultar Produto");
                        Console.WriteLine("3- Consultar Produto por Nome");
                        Console.WriteLine("4- Remover Produto por Nome");
                        Console.WriteLine("5- Retornar ao Menu Principal");
                        operacao = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                       
                      Console.Write("Saindo");

                      for (int i=0;i<10 ;i++ )
                      {
                          
                          Thread.Sleep(100);
                          Console.Write(".");
                          
                      }
                        
                        break;
                    default:
                        opcao = 3;
                        Console.WriteLine("Operação Inválida!");
                        break;
                }
                Console.Clear();
                if (opcao == 1)
                {
                    if (operacao == 1)
                    {
                        Console.WriteLine("Informe o nome do Cliente:");
                        cliente.Nome = Console.ReadLine();
                        Console.WriteLine("Informe o CPF do Cliente:");
                        cliente.Cpf = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("Informe o Sexo do Cliente:");
                        cliente.Sexo = Convert.ToChar(Console.ReadLine());
                        Console.WriteLine("Informe o Idade do Cliente:");
                        cliente.Idade = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o Telefone do Cliente:");
                        cliente.Telefone = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("Informe o Endereço do Cliente:");
                        cliente.Endereco = Console.ReadLine();
                        LisCli.Add(cliente);
                        Console.Clear();
                        Console.WriteLine("Cliente cadastrado com SUCESSO!");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (operacao == 2)
                    {
                        foreach (Cliente cli in LisCli)
                        {

                            Console.WriteLine("Nome do Cliente: " + cli.Nome);
                            Console.WriteLine("CPF do Cliente: " + cli.Cpf);
                            Console.WriteLine("Sexo do Cliente: " + cli.Sexo);
                            Console.WriteLine("Idade do Cliente: " + cli.Idade);
                            Console.WriteLine("Telefone do Cliente: " + cli.Telefone);
                            Console.WriteLine("Endereço do Cliente: " + cli.Endereco);
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
                        if(LisCli.Count<=0){
                        foreach(Cliente cli in LisCli){
                            if(nomeAux.Equals(cli.Nome)){
                                Console.Clear();
                                Console.WriteLine("Achou mizeravi: "+cli.Nome);
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
                        Console.Clear();
                        Console.WriteLine("Não existe cliente cadastrado com esse nome: " + nomeAux);
                        Console.ReadKey();
                        Console.Clear();
                        }
                        

                    }
                    else if(operacao == 4){
                        Console.WriteLine("informe o nome para Remoção");
                        String nomeAux;
                        nomeAux = Console.ReadLine();
                        foreach (Cliente cli in LisCli)
                        {
                            if (nomeAux.Equals(cli.Nome))
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

                    }else if(operacao == 5){
                        
                        goto inicio;
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
                        Console.WriteLine("Informe o Código do Produto:");
                        produto.Codigo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe a Descrição do Produto:");
                        produto.Descricao = Console.ReadLine();
                        Console.WriteLine("Informe o Valor do Produto:");
                        produto.Valor = (float)Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Informe a Fabricante do Produto:");
                        produto.Fabricante = Console.ReadLine();
                        ListProduto.Add(produto);
                        Console.Clear();
                        Console.WriteLine("Produto cadastrado com SUCESSO!");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (operacao == 2)
                    {
                        foreach (Produto prod in ListProduto)
                        {

                            Console.WriteLine("Código do Produto: " + prod.Codigo);
                            Console.WriteLine("Descrição do Produto: " + prod.Descricao);
                            Console.WriteLine("Valor do Produto: " + prod.Valor);
                            Console.WriteLine("Fabricante do Produto: " + prod.Fabricante);
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
                        if(ListProduto.Count<=0){
                        foreach(Produto prod in ListProduto){
                            
                            if(prodAux.Equals(prod.Descricao)){
                                Console.Clear();
                                Console.WriteLine("Produto encontrado: " + prod.Descricao);
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
                            Console.Clear();
                            Console.WriteLine("Produto " + prodAux + " não encontrado ");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    else if (operacao == 4)
                    {

                        Console.WriteLine("Informe a descrição do produto para a Remoção");
                        String prodAux = Console.ReadLine();
                        foreach (Produto prod in ListProduto)
                        {

                            if (prodAux.Equals(prod.Descricao))
                            {
                                ListProduto.Remove(prod);
                                Console.Clear();
                                Console.WriteLine("Produto removido com SUCESSO!: " + prod.Descricao);
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

                    }else if(operacao==5){
                        goto inicio;
                    }else
                    {
                        Console.WriteLine("Inválido");
                        Console.ReadKey();

                    }
                }

            } while (opcao != 3);
           
        }

    }
}
