int[] arrayInteri = { 0, 4, 6, 1, 8, 0, 2, 5 };
string[] arrayStringhe = { "Ericchi", "Thomas", "Bryan", "Francesco1", "Francesco2" };
StampaArrayInteri(arrayInteri);
StampaArrayStringhe(arrayStringhe);

void StampaArrayInteri(int[] arrayInteri) {
    Console.Write("[ ");
    for (int i = 0; i < arrayInteri.Length; i++) {
        Console.Write(arrayInteri[i]);
        if (i == arrayInteri.Length - 1) {
            Console.Write(" ");
        }
        else {
            Console.Write(", ");
        }
    }
    Console.Write("]\n");
    /* VERSIONE FOREACH 
     
     * foreach(int numero in arrayInteri){
     *      Console.Write(numero);
     * }
    
     */
}

void StampaArrayStringhe(string[] arrayStringhe) {
    Console.Write("[ ");

    for (int i = 0; i < arrayStringhe.Length; i++) {
        Console.Write("\"" + arrayStringhe[i] + "\"");
        if (i == arrayStringhe.Length - 1) {
            Console.Write(" ");
        }
        else {
            Console.Write(", ");
        }
    }
    Console.Write("]\n");
}