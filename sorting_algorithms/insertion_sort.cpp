#include <iostream>
//main function
function insertionSort(array){
        for (var i = 0; i<array.length - 1; i++){
        var temp = array[i];
    
        for (var j = i -1; j > -1 && array[i] > temp; j--){
            array[j+1] = array[j];
        
        }
    
        array[j+1] = temp;
    }
    return array;
}


  




int main(){




}