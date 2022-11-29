using bytebank;

ContaCorrente conta = new()
{
    titular = "Thiago Tomé",
    numero_agencia = 1,
    conta = "1223595",
    saldo = 100
};


Console.WriteLine(conta.titular);
Console.WriteLine(conta.numero_agencia);
Console.WriteLine(conta.conta);
Console.WriteLine(conta.saldo);

Console.WriteLine("Antes do saque: R$ " + conta.saldo);
conta.Sacar(50);
Console.WriteLine("Depois do saque: R$ " + conta.saldo);