using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Digite um valor numérico:");
        double valor = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(ValorPorExtenso(valor));
    }

    static string ValorPorExtenso(double valor) {
        string[] unidades = {"zero", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove"};
        string[] dezenas = {"", "dez", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa"};
        string[] centenas = {"", "cento", "duzentos", "trezentos", "quatrocentos", "quinhentos", "seiscentos", "setecentos", "oitocentos", "novecentos"};
        string[] milhares = {"", "mil", "milhões", "bilhões", "trilhões", "quatrilhões", "quintilhões", "sextilhões", "septilhões", "octilhões", "nonilhões", "decilhões", "undecilhões", "duodecilhões", "tredecilhões", "quattuordecilhões", "quindecilhões", "sexdecilhões", "septendecilhões", "octodecilhões", "novemdecilhões", "vigintilhões"};

        string valorPorExtenso = "";
        string valorString = valor.ToString().Replace(",", "").Replace(".", "");

        int qtdMilhares = (int)Math.Ceiling((double)valorString.Length / 3);
        int qtdZerosEsquerda = qtdMilhares * 3 - valorString.Length;

        valorString = valorString.PadLeft(qtdZerosEsquerda + valorString.Length, '0');

        for (int i = 0; i < qtdMilhares; i++) {
            string parteValorString = valorString.Substring(i * 3, 3);
            int parteValor = Convert.ToInt32(parteValorString);

            if (parteValor > 0) {
                string extensoParteValor = "";

                if (parteValor >= 100) {
                    int centena = parteValor / 100;
                    extensoParteValor += centenas[centena];

                    if (parteValor % 100 > 0) {
                        extensoParteValor += " e ";
                    }
                }

                if (parteValor % 100 >= 10 && parteValor % 100 <= 19) {
                    int unidade = parteValor % 100;
                    extensoParteValor += unidades[unidade];
                } else {
                    int dezena = (parteValor % 100) / 10;
                    extensoParteValor += dezenas[dezena];

                    int unidade = parteValor % 10;
                    if (unidade > 0) {
                        if (dezena > 0) {
                            extensoParteValor += " e ";
                        }

                        extensoParteValor += unidades[unidade];
                    }
                }

                if (i > 0) {
                    if (parteValor > 1) {
                        extensoParteValor += " " + milhares
