namespace Classes.Metodos
{
	public class Ref
	{
		static void Interver(ref int x,ref int y)
		{
			int temp = x;
			x = y;
			y = temp;
		}
		public static void Interver()
		{
			int i = 1, j = 2;
			Interver(ref i,ref j);
			System.Console.WriteLine($"{i}{j}");	//Escreve "2,1"
		}
	}
}