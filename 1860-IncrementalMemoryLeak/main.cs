public class Solution {
    public int[] MemLeak(int memory1, int memory2) {
        int t = 1;

        int[] ret = new int[3];
        while(memory1 -t >= 0 || memory2 -t >= 0){
            if(memory1 >= memory2)
                memory1 -= t;
            else 
                memory2 -= t;
            
            t++;
        }
        
        ret[0] = t;
        ret[1] = memory1;
        ret[2] = memory2;
        return ret; 
    }
}