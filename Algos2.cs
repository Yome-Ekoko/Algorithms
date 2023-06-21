 public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        int piece=0;
        int lastPiece=n;
        while(piece<lastPiece){ 
        int middle = piece + (lastPiece-piece)/2;
        if(IsBadVersion(middle)){
        lastPiece=middle;
        }
        else{
        piece=middle+1;
        }
    }

return piece;
    
  }
    
}
