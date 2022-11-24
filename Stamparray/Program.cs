int[] arrayInteri = { 2, 6, 7, 5, 3, 9 };
StampaArrayInteri(arrayInteri);
Console.Write("Vuoi cambiare questo array di numeri? (s/N)");
bool cambiare = convalida();
if (cambiare == true) {
	bool utonto = false;
	Console.Write("Quanti elementi ha il tuo array? ");
	if (Int32.TryParse(Console.ReadLine(), out int j)) {
		int quanti = j;
		int[] copiainteri = (int[])arrayInteri.Clone();
		copiainteri = new int[quanti];
		// Check anti-utonti
		for (int i = 0; i < quanti; i++) {
			Console.Write("Inserisci il " + (i + 1) + "º numero: ");
			try {
				copiainteri[i] = Int32.Parse(Console.ReadLine());
			} catch {
				Console.WriteLine("Haha. Molto divertente. Verrà usato l'array di default.");
				utonto = true;
				break;
			}
		}
		if (utonto == false) {
			arrayInteri = (int[])copiainteri.Clone();
		}
		Console.Write("Nuovo array: ");
		StampaArrayInteri(arrayInteri);
	} else {
		Console.WriteLine("Non hai inserito un numero valido. Verrà usato l'array di default.");
	}
	 
}
string[] arrayStringhe = { "Ericchi", "Thomas", "Bryan", "Francesco1", "Francesco2" };
// StampaArrayStringhe(arrayStringhe);
Console.Write("Quadrato di 5: ");
Quadrato(5);
ElevaArrayAlQuadrato(arrayInteri);
Console.WriteLine("Premi Invio per uscire.");
Console.ReadLine();

// Punto 1
void StampaArrayInteri(int[] arrayInteri) {
	Console.Write("[");
	for (int i = 0; i < arrayInteri.Length; i++) {
		Console.Write(arrayInteri[i]);
		if (i == arrayInteri.Length - 1) {
			Console.Write("]\n");
		}
		else {
			Console.Write(", ");
		}
	}
	
	/* VERSIONE FOREACH 
	 
	 * foreach(int numero in arrayInteri){
	 *      Console.Write(numero);
	 * }
	
	 */
}

// Punto 2
int Quadrato(int numero) {
	numero = numero * numero;
	Console.WriteLine(numero);
	return numero;
}

// Punto 3
int[] ElevaArrayAlQuadrato(int[] array) {
	int[] copiarray = (int[])array.Clone();
	for (int i = 0; i < copiarray.Length; i++) {
		copiarray[i] = copiarray[i] * copiarray[i];
	}
	Console.Write("Array originale: ");
	StampaArrayInteri(array);
	Console.Write("Array elevato al quadrato: ");
	StampaArrayInteri(copiarray);
	return copiarray;
}

// Punto 4
int sommaElementiArray(int[] array) {
	int[] copiarray = (int[])array.Clone();
	int somma = 0;
	for (int i = 0; i < copiarray.Length; i++) {
		somma = somma + copiarray[i];
	}
	Console.WriteLine(somma);
	return somma;
}

// Altre cose
void StampaArrayStringhe(string[] arrayStringhe) {
	Console.Write("[");

	for (int i = 0; i < arrayStringhe.Length; i++) {
		Console.Write("\"" + arrayStringhe[i] + "\"");
		if (i == arrayStringhe.Length - 1) {
			Console.Write("]\n");
		}
		else {
			Console.Write(", ");
		}
	}
}

bool convalida() {
	bool ancora = true;
	bool valid = false;
	do {
		string letter = Console.ReadLine().ToLower();
		if (letter == "s" || letter == "n" || letter == "") {
			valid = true;
			if (letter == "s") {
				ancora = true;
			}
			else {
				ancora = false;
			}
		}
		else {
			Console.Write("Non è una scelta valida. Inserisci \"s\" o \"n\": ");
		}
	} while (!valid);
	return ancora;
}

