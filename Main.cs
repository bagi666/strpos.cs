using System;

class search {

	public string x;
	public string y;
	
	public int searching (string f, string g) {
		
		x = f;
		y = g;

		int j, k;
		int [] i = new int [x.Length];

		for (j = 0, k = 0; j < y.Length; j++) {
			if (x[k] == y[j]) {
				i[k] = j;
				if (k+1 == x.Length) return i[0];
				if (j+1 == y.Length) return -1;
				k++;
				if (x[k] != y[j+1]) k = 0;
				continue;
			}	 
		}
		return -1;
	}

}


class strpos {

	public static void Main() {

		search a = new search();
		int b;
		b = a.searching("abc", "ab xxx abc xxx");
		Console.WriteLine("{0}", b);
	}
	

}
