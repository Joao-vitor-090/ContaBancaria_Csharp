using System;

namespace aula24___banco {
    class Program {
        static void Main ( string [ ] args ) {

            Banco x;

            Console.WriteLine ( "Qual sua conta ?  " );
            int conta = int.Parse ( Console.ReadLine () );

            if ( conta.ToString ().Length < 9 ) {
                Console.WriteLine ( "Conta inválida (A conta deve ser composta de 9 números;)" );
            }
            else {

                Console.WriteLine ( "" );

                Console.WriteLine ( "Entre com  o títular da conta : " );
                string titular = Console.ReadLine ();
                Console.WriteLine ( "" );

                Console.WriteLine ( "Haverá depósito inicial ? (s/n) " );
                char choice = char.Parse ( Console.ReadLine () );

                if ( choice == 's' || choice == 'S' ) {

                    Console.WriteLine ( "Entre com o valor inicial : " );
                    double depositoInicial = double.Parse ( Console.ReadLine () );
                    x = new Banco ( titular, conta, depositoInicial );


                }
                else {

                    x = new Banco ( titular, conta );
                    Console.WriteLine ( x );
                }

                Console.WriteLine ();
                Console.WriteLine ( "Dados da conta  : " );
                Console.WriteLine ( x );

                Console.WriteLine ();
                Console.WriteLine ( "Entre com um valor para depósitio : " );
                double valor = double.Parse ( Console.ReadLine () );
                x.Deposito ( valor );

                Console.WriteLine ( "Conta atualizada : " );
                Console.WriteLine ();
                Console.WriteLine ( x );
                Console.WriteLine ();

                Console.WriteLine ( "Entre com um valor para saque : " );
                double quant = double.Parse ( Console.ReadLine () );
                x.Saque ( quant );

                Console.WriteLine ( "Conta atualizada : " );
                Console.WriteLine ( x );

                Console.WriteLine ( "Deseja fazer mais alguma operação ? (s/n)" );
                char opt = char.Parse ( Console.ReadLine () );
                if ( opt == 's' || opt == 'S' ) {
                    Console.WriteLine ( "Qual operação deseja realizar ?(Digite o número da operação requerida : ) " );
                    Console.WriteLine ( "1 -> Depósito" );
                    Console.WriteLine ( "2 -> Saque" );
                    int op = int.Parse ( Console.ReadLine () );
                    if ( op == 1 ) {
                        Console.WriteLine ( "Entre com um valor para depósitio : " );
                        valor = double.Parse ( Console.ReadLine () );
                        x.Deposito ( valor );
                        Console.WriteLine ( "Conta atualizada : " );
                        Console.WriteLine ();
                        Console.WriteLine ( x );
                        Console.WriteLine ();
                    }
                    else if ( op == 2 ) {

                        Console.WriteLine ( "Entre com um valor para saque : " );
                        quant = double.Parse ( Console.ReadLine () );
                        x.Saque ( quant );
                        Console.WriteLine ( "Conta atualizada : " );
                        Console.WriteLine ();
                        Console.WriteLine ( x );
                        Console.WriteLine ();
                    }
                    else {
                        Console.WriteLine ( "OPÇÃO INVÁLIDA !" );
                    }
                }
            }
        }
    }
}
