using System;
					
public class Program

{
    public static void questaoUm() {

        Console.WriteLine("===========================================================");
        Console.WriteLine();


        Console.WriteLine("Questão 1)");

        int INDICE = 13, SOMA = 0, K = 0;
		
		while (K < INDICE) {
			K = K + 1;
			SOMA = SOMA + K;
		}
		
		System.Console.Write("O valor de soma será de: ");
		System.Console.WriteLine(SOMA);

        Console.WriteLine();
        Console.WriteLine("===========================================================");
        Console.ReadLine();

	}
	
	public static void questaoDois() {

        Console.WriteLine("Questão 2)");

		
        try {
            Console.WriteLine("Digite o número de deseja consultar na sequência Fibonacci:");
            int num = int.Parse(Console.ReadLine());
			
			int max = 0;

            if(num < 7) { max = 7; }
            else { max = num; }
			
			int[] vetor = new int[max]; 

            vetor[0] = 0;
            vetor[1] = 1;

            for (int i = 2; true; i++)
            {
                vetor[i] = vetor[i-1] + vetor[i-2];

                if (vetor[i] == num){
                    Console.WriteLine("O número pertence a sequência Fibonacci");
                    break;
                } else if (vetor[i] > num) {
					
					if(num == 0) { Console.WriteLine("O número pertence a sequência Fibonacci"); } 
					else { Console.WriteLine("O número não pertence a sequência Fibonacci"); }
                    
                    break;
                }
            }

        } catch(FormatException) { Console.WriteLine("Por favor, digite um número inteiro válido"); }

        Console.WriteLine();
        Console.WriteLine("===========================================================");
        Console.ReadLine();

    }

    public static void questaoTres() {

        Console.WriteLine("Questão 3)");

        double[] vetor = {  3427.68, 1600.14, 3541.32, 3800.50, 1673.94, 2664.00, 2721.25 };

        double menor = vetor[0];
        double maior = vetor[0];

        for (int i = 1; i < vetor.Length; i++) {
            if (vetor[i] < menor) {
                menor = vetor[i];
            }

            if (vetor[i] > maior) {
                maior = vetor[i];
            }
        }

        Console.WriteLine("Maior valor de faturamento desse mês: " + maior);
        Console.WriteLine("Menor valor de faturamento desse mês: " + menor);

        Console.WriteLine();
        Console.WriteLine("===========================================================");
        Console.ReadLine();

    }

    public static void questaoQuatro() {

        Console.WriteLine("Questão 4)");

        double SP = 67836.43, RJ = 36678.66,MG = 29229.88, ES = 27165.48, OT = 19849.53;
        double total = SP + RJ + MG + ES + OT;

        double Psp = SP * 100 / total;
        double Prj = RJ * 100 / total;
        double Pmg = MG * 100 / total;
        double Pes = ES * 100 / total;
        double Pot = OT * 100 / total;
        
		Console.WriteLine("Porcentagem de Representação de Cada Estado: ");
		Console.WriteLine("São Paulo:" + Math.Round(Psp, 2) + "%");
		Console.WriteLine("Rio de Janeiro:" + Math.Round(Prj, 2) + "%");
		Console.WriteLine("Minas Gerais:" + Math.Round(Pmg, 2) + "%");
		Console.WriteLine("Espírito Santo:" + Math.Round(Pes, 2) + "%");
		Console.WriteLine("Outros:" + Math.Round(Pot, 2) + "%");

        Console.WriteLine();
        Console.WriteLine("===========================================================");
        Console.ReadLine();

    }

    public static void  questaoCinco() {

        Console.WriteLine("Questão 5)");
        
        Console.WriteLine("Insira o texto de deseja inverter");
        string textoOld = Console.ReadLine();
        string textoNew = "";

        for(int i = textoOld.Length - 1; i >= 0; i--) {
            textoNew += textoOld[i];
        }

        Console.WriteLine("Texto Antigo: " + textoOld);
        Console.WriteLine("Texto Novo: " + textoNew);

        Console.WriteLine();
        Console.WriteLine("==========================================================");
    
    }

	public static void Main()
	{
		questaoUm();
        questaoDois();
		questaoTres();
		questaoQuatro();
        questaoCinco();
	}
}

