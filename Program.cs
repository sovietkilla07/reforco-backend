using reforco_backend.classes;

string opcao = "";
PessoaJuridica metodosPJ = new PessoaJuridica();

do
{
    Console.Clear();

    Console.WriteLine(@"
    
    1 - Cadastrar PJ
    2 - Listar PJ
    3 - Sair
    ");

    opcao = Console.ReadLine()!;

    switch (opcao)
    {
        case "1":
            PessoaJuridica pj = new PessoaJuridica();

            Console.WriteLine("Informe o nome da PJ: ");
            pj.Nome = Console.ReadLine();

            Console.WriteLine("Informe o rendimento da PJ: ");
            pj.Rendimento = float.Parse(Console.ReadLine()!);

            Console.WriteLine("Informe o CNPJ");
            pj.CNPJ = Console.ReadLine();

            metodosPJ.Inserir(pj);

            Console.WriteLine("PJ cadastrada com sucesso!");
            Console.ReadLine();

            break;

        case "2":

            Console.WriteLine("Digite o nome da PJ: ");

            string nomePJ = Console.ReadLine()!;

            PessoaJuridica pjLeitura = metodosPJ.Ler(nomePJ);

            Console.WriteLine(@$"
            
                Nome: {pjLeitura.Nome}
                Rendimento: R${pjLeitura.Rendimento},00
                CNPJ: {pjLeitura.CNPJ}

            ");
            Console.ReadLine();
            break;

        default:
            break;
    }
} while(opcao !="3");