namespace AlgorithmLibrary
{
public partial class Mathematics{
    static int DiffFromNextMultiPleOfaNumber(int a,int b)
        {
            //divide by 5
            if(a%b!=0)
            {
                int x = a/b;
            int y = x+1;
            int multiple = y*b;
            return (multiple - a);
            }else{
                return 0;
            }
            

        }
}
}
