using System;
public class Calcular {
        
    public static float numero1;
    public static float numero2;
    public static float resultado;
        
        
    public static void Main() {
         Valida1();
         Valida2();
         Calculo();
    }
    static void Valida1() {
                
        try {
                Console.WriteLine("Por favor digite o primeiro numero: ");
                numero1 = float.Parse(Console.ReadLine());
            }
        catch (FormatException) {
            Console.WriteLine("Digite um valor valido, por favor.");
            Valida1();
            return;
        }
    }
    
    static void Valida2() {
        try {
                {
                 Console.WriteLine("Por favor digite o segundo numero: ");
                 numero2 = float.Parse(Console.ReadLine());
                }
            }
        catch (FormatException) {
            Console.WriteLine("Digite um valor valido, por favor.");
            Valida2();
            return;
        }
    }
    
    static void Calculo () {
        Console.WriteLine("\nDigite 1 para soma: ");
        Console.WriteLine("Digite 2 para subtração: ");
        Console.WriteLine("Digite 3 para multiplicação: ");
        Console.WriteLine("Digite 4 divisão: ");
          
        int operacao = int.Parse(Console.ReadLine());
      
        float resultado = 0;
        
        if (operacao == 1) {
            resultado = numero1 + numero2;
        } else if (operacao == 2) {
            resultado = numero1 - numero2;
        } else if (operacao == 3) {
            resultado = numero1 * numero2;
        } else if (operacao == 4) {
            if (numero2 != 0) {
               resultado = numero1/numero2; 
            } else {
                Console.WriteLine("Divisão impossivel, denominador = 0");
                Main();
            }
        } else {
            Console.WriteLine("Operação invalida");
            Calculo();
        }
        
        Console.WriteLine("Resultado: " + resultado);

    }
   
}


