using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Animes
{
    class Program
    {
       
        static AnimeRepositorio repositorio = new();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarAnimes();
                        break;
                    case "2":
                        InserirAnime();
                        break;
                    case "3":
                        AtualizarAnime();
                        break;
                    case "4":
                        ExcluirAnime();
                        break;
                    case "5":
                        VisualizarAnime();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Escolha inválida!");
                        break;
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }
            Console.WriteLine("Obrigado por utilizar nossos serviços!");
            Console.ReadKey();


            static void ListarAnimes()
            {
                Console.WriteLine("Listar Animes");

                var lista = repositorio.Lista();

                if(lista.Count == 0)
                {
                    Console.WriteLine("Não há Animes cadastrados\n");
                    return;
                }

                foreach(var anime in lista)
                {

                    var excluido = anime.retornaExcluido();
                    Console.WriteLine("#ID {0}: - {1} {2}", anime.retornaId(), anime.retornaTitulo(), (excluido ? "*Excluido*" : ""));
                }
            }

             static void InserirAnime()
            {
                Console.WriteLine("Inserir novo Anime\n");

                foreach (int i in Enum.GetValues(typeof(Numeradores.Genero)))
                {
                    Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Numeradores.Genero), i));
                }

                Console.Write("\nDigite o gênero entre as opções acima: ");
                int entradaGenero = int.Parse(Console.ReadLine());


                foreach (int i in Enum.GetValues(typeof(Numeradores.Publico)))
                {
                    Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Numeradores.Publico), i));
                }

                Console.Write("\nDigite Qual o Público entre as opções acima: ");
                int entradaPublico = int.Parse(Console.ReadLine());

                Console.Write("Digite o Título do Anime: ");
                string entradaTitulo = Console.ReadLine();

                Console.Write("Digite o Ano de Início do Anime: ");
                int entradaAno = int.Parse(Console.ReadLine());

                Console.Write("Digite a Descrição do Anime: ");
                string entradaDescricao = Console.ReadLine();

                Console.Write("Digite a Produtora do Anime: ");
                string entradaProdutora = Console.ReadLine();

                Console.Write("Digite a Nota do Anime: ");
                int entradaNota = int.Parse(Console.ReadLine());

                Anime anime = new Anime(id: repositorio.ProximoId(),
                    genero: (Numeradores.Genero)entradaGenero,
                    publico: (Numeradores.Publico)entradaPublico,
                    titulo: entradaTitulo,
                    descricao: entradaDescricao,
                    ano: entradaAno,
                    produtora: entradaProdutora,
                    nota: entradaNota);

                repositorio.Inserir(anime);
            }

            static void AtualizarAnime()
            {
                Console.WriteLine("Digite o id da série: ");
                int indiceAnime = int.Parse(Console.ReadLine());

                foreach (int i in Enum.GetValues(typeof(Numeradores.Genero)))
                {
                    Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Numeradores.Genero), i));
                }

                Console.Write("\nDigite o gênero entre as opções acima: ");
                int entradaGenero = int.Parse(Console.ReadLine());


                foreach (int i in Enum.GetValues(typeof(Numeradores.Publico)))
                {
                    Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Numeradores.Publico), i));
                }

                Console.Write("\nDigite Qual o Público entre as opções acima: ");
                int entradaPublico = int.Parse(Console.ReadLine());

                Console.Write("Digite o Título do Anime: ");
                string entradaTitulo = Console.ReadLine();

                Console.Write("Digite o Ano de Início do Anime: ");
                int entradaAno = int.Parse(Console.ReadLine());

                Console.Write("Digite a Descrição do Anime: ");
                string entradaDescricao = Console.ReadLine();

                Console.Write("Digite a Produtora do Anime: ");
                string entradaProdutora = Console.ReadLine();

                Console.Write("Digite a Nota do Anime: ");
                int entradaNota = int.Parse(Console.ReadLine());

                Anime atualizaAnime = new Anime(id: repositorio.ProximoId(),
                    genero: (Numeradores.Genero)entradaGenero,
                    publico: (Numeradores.Publico)entradaPublico,
                    titulo: entradaTitulo,
                    descricao: entradaDescricao,
                    ano: entradaAno,
                    produtora: entradaProdutora,
                    nota: entradaNota);

                repositorio.Atualizar(indiceAnime, atualizaAnime);

            }

            static void ExcluirAnime()
            {
                Console.WriteLine("Digite o id do anime: ");
                int indiceAnime = int.Parse(Console.ReadLine());

                repositorio.Excluir(indiceAnime);
                Console.WriteLine("Anime excluido com sucesso!\n");
            }

            static void VisualizarAnime()
            {
                Console.WriteLine("Digite o id do anime: ");
                int indiceAnime = int.Parse(Console.ReadLine());

                var anime = repositorio.RetornarPorId(indiceAnime);

                Console.WriteLine("\n",anime);
            }


             static string ObterOpcaoUsuario()
            {
                Console.WriteLine("UP Animations ao seu dispor!");
                Console.WriteLine("Informe a opção que deseja: ");
                Console.WriteLine("1- Listar animes");
                Console.WriteLine("2- Inserir novo anime");
                Console.WriteLine("3- Atualizar Anime");
                Console.WriteLine("4- Excluir Anime");
                Console.WriteLine("5- Visualizar Anime");
                Console.WriteLine("C- Limpar Tela");
                Console.WriteLine("X- Sair");

                string opcaoUsuario = Console.ReadLine().ToUpper();
                Console.WriteLine();
                return opcaoUsuario;
            }
        }
    }
}
