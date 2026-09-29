namespace newStart;

public class MyList<T> /*: ICollection<T>*/
{
    public int Count {get; private set;}  = 0;
    private int VaultSize = 16;
    private T[]? Vault = new T[16];


    // public void Add(T item){
    //     T[] newValue = new T[Count + 1];
    //     int counter = 0;
    //     foreach(T i in Value){
    //         newValue[counter] = i;
    //         counter++;
    //     }
    //     newValue[counter] = item;
    //     Value = newValue;
    // }

    public void Add(T item){
        if (Count >= VaultSize) IncreeaseVaultSize();

        Vault[Count] = item;
        Count++;
    }

    private void IncreeaseVaultSize(){
        T[] newVault = new T[VaultSize + 16];
        int c = 0;
        foreach(T i in Vault){
            newVault[c] = i;
            c++;
        }
        Vault = newVault;
    }

    public void Clear(){
        Vault = new T[16];
        VaultSize = 16;
        Count = 0;
    }

    public bool Remove(T item){
        int c = 0;
        foreach (T i in Vault){
            if ((item is null && i is null) || (i is not null && i.Equals(item))){
                RemoveAt(c);
                return true;
            }
        }
        return false;
    }

    public bool RemoveAt(int Index) {
        int c = Index;
        while (c <= Count){
            Vault?[c] = Vault[c+1];
            c++;
        }
        Vault?[c] = default(T);;
        Count--;
        return true;
    }

    // public int Count { get{
    //     int count = 0;
    //     foreach (T item in Value){
    //         count++;
    //     }
    //     return count;
    // }}


}
