static class ListMethods{
    public static B[] Select<A,B>(A[] arr, Func<A,int,B> func){
        B[] res=new B[arr.Length];
        for(int i=0; i<arr.Length; i++){
            res[i]=func(arr[i],i);
        }
        return res;
    }
    public static T[] Where<T>(T[] arr, Func<T,int,bool> cond){
        bool[] match=Select(arr,cond);
        int k=0;
        foreach(bool f in match) if(f) k++;
        T[] res=new T[k];
        int ind=0;
        for(int i=0; i<arr.Length; i++) if(match[i]){res[ind]=arr[i];ind++;};
        return res;
    }
    public static int Min(int[] arr){
        int min=arr[0];
        foreach(int e in arr) if(e<min) min=e;
        return min;
    }
    public static T[] OnPosRange<T>(T[] arr, int left, int right)=>Where(arr,(a,i)=>left<=i && i<right);
    public static int[] IntRange(int start,int end, int step){
        if((end-start)/step<0) return new int[0];
        int[] res=new int[(end-start)/step];
        for(int i=0; i<(end-start)/step; i++){
            res[i]=start+step*i;
        }
        return res;
    }
    public static int[] IntRange(int start,int end)=>IntRange(start,end,1);
    public static int[] IntRange(int stop)=>IntRange(0,stop);
    public static T[] Contact<T>(T[] prefix, T[] postfix){
        return Select(
            IntRange(0,prefix.Length+postfix.Length,1),
            (a,i)=>{if(i<prefix.Length) return prefix[i]; else return postfix[i-prefix.Length];}
        );
    }
    public static T First<T>(T[] arr, Func<T,int,bool> cond){
        for(int i=0; i<arr.Length; i++) if(cond(arr[i],i)) return arr[i];
        throw new Exception($"No such element in array");
    }
    public static T Last<T>(T[] arr, Func<T,int,bool> cond)=>First(
        Select(
            IntRange(arr.Length-1,-1,-1),
            (a,i)=>arr[a]
        ),
        (a,i)=>cond(a,arr.Length-i-1)
    );
    //tested (dep - Where)
    public static T[] WithoutPositions<T>(T[] arr, int leftInclude, int rightNonInclude)=>
        Where(
            arr,
            (a,i)=>!(leftInclude<=i&&i<rightNonInclude)
        );
    //tested (dep - WithoutPositions)
    public static T[,] WithoutColumns<T>(T[,] arr, int leftInclude, int rightNonInclude){
        int[] ind=WithoutPositions(IntRange(arr.GetLength(1)),leftInclude,rightNonInclude);
        T[,] res=new T[arr.GetLength(0),ind.Length];
        for(int i=0; i<res.GetLength(0); i++)
            for(int j=0; j<res.GetLength(1); j++)
                res[i,j]=arr[i,ind[j]];
        return res;
    }
}
