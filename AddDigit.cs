using System.Collections.Generic;

public class AddDigitClass {
    Dictionary<char,int> dic = new Dictionary<char,int>{
            {'1',1},
            {'2',2},
            {'3',3},
            {'4',4},
            {'5',5},
            {'6',6},
            {'7',7},
            {'8',8},
            {'9',9},
            {'0',0}
        };
        
    public int AddDigits(int num) {
        string str = num.ToString();
        if(num > 9){
         int sum = 0;
        foreach(var item in str){
            sum += dic[item];
        }
        return AddDigits(sum);
        }
        return num;
    }
}