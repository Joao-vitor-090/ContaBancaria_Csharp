
namespace aula24___banco {
    class Banco {
        public string Titular { get; private set; }
        public int Conta { get;  set; }
        public double Saldo { get; private set; }

        public Banco ( string titular, int conta) {
            Titular = titular;
            Conta = conta;
        }
       public Banco (string titular, int conta, double saldo) : this ( titular, conta ) {
            Saldo = saldo;
        }

        public void Deposito (double valor ) {
            
            Saldo += valor;

        }
        public void Saque (double valor ) {

            Saldo = Saldo - ( valor + 5.0 );

        }

        public override string ToString ( ) {
            return $"Conta: {Conta} , Titular: {Titular} , Saldo R$: {Saldo} ";
          
         }
    }
}
