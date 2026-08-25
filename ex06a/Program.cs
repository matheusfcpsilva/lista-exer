Console.Clear();

int[] valoresNOrdenado = new int[1000];

Random random = new Random();
for (int i = 0; i < valoresNOrdenado.Length; i++)
{
    valoresNOrdenado[i] = random.Next(1, 1001);
}

for (int i = 0; i < valoresNOrdenado.Length; i++)
{
    Console.Write(valoresNOrdenado[i] + " ");
}

/*for (int i = 0; i < valoresNOrdenado.Length - 1; i++)
{
    if (valoresNOrdenado[i] > valoresNOrdenado[i + 1])
    {
        int temp = valoresNOrdenado[i];
        valoresNOrdenado[i] = valoresNOrdenado[i + 1];
        valoresNOrdenado[i + 1] = temp;
    }
}*/

bool troca = false;

do
{
    troca = false;
    for (int i = 0; i < valoresNOrdenado.Length - 1; i++)
    {
        if (valoresNOrdenado[i] > valoresNOrdenado[i + 1])
        {
            troca = true;
            int temp = valoresNOrdenado[i];
            valoresNOrdenado[i] = valoresNOrdenado[i + 1];
            valoresNOrdenado[i + 1] = temp;
        }
    }
}while (troca == true);

Console.WriteLine("\n");

/*for (int i = 0; i < valoresNOrdenado.Length - 1; i++)
{
    for (int j = 0; j < valoresNOrdenado.Length - 1; j++)
    {
        if (valoresNOrdenado[j] > valoresNOrdenado[j + 1])
        {
            int temp = valoresNOrdenado[j];
            valoresNOrdenado[j] = valoresNOrdenado[j + 1];
            valoresNOrdenado[j + 1] = temp;
        }
    }
}*/

for (int i = 0; i < valoresNOrdenado.Length; i++)
{
    Console.Write(valoresNOrdenado[i] + " ");
}
