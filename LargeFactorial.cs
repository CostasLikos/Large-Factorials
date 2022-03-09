using System;

public class Kata
{
  public static string Factorial(int n)
  {
    
    int[] apotelesma = new int[500];
    apotelesma[0] = 1;
    int apotelesma_size = 1;
    string gegonos = "";
    int perasma = 0;
    
    if (n < 0)
      return null;
    
    
    for (int i = 2; i <= n; i++)
    {
      for (int j = 0; j < apotelesma_size; j++)
      {
        int paragogos = apotelesma[j] * i + perasma;
        apotelesma[j] = paragogos % 10;
        perasma = paragogos / 10;
      }
      while (perasma != 0)
      {
        apotelesma[apotelesma_size] = perasma % 10;
        perasma /= 10;
        apotelesma_size++;
      }
    }
    for (int i = apotelesma_size - 1; i >= 0; i--) 
			gegonos += apotelesma[i]; 
    return gegonos;
  }
}
