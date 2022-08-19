int FirstBadVersion(int n) {
    
    if(n == 1) return 1;
    
    int low = 1;
    int high = n;
    
    while(low < high)
    {
        int mid = low + (high - low) / 2;
        if(IsBadVersion(mid)) high = mid ;
        else low = mid + 1;
    }
    
    return low;
}                                   