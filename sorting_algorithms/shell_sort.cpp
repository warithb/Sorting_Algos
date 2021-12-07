// Shell Sort in C++ programming
#include <iostream>
using namespace std;

void shellSort(int array[], int n);
void printArray(int array[], int size);

int main() {
  int data[] = {9, 8, 3, 7, 5, 6, 4, 1};
  int size = sizeof(data) / sizeof(data[0]);
  shellSort(data, size);
  cout << "Sorted array: \n";
  printArray(data, size);
}

// Shell sort
void shellSort(int array[], int n) {
  //The interval is always the length divided by 2, and it will continue
  // to be divided by two until the interval is less than or equal to 0
  for (int interval = n/2; interval >0; interval /=2){

    //when i becomes == to or greater than the legnth of the array the pass is done,
    //and we go outside the
    for (int i = interval; i < n; i += 1) {
      int temp = array[i];
      int j = 0;
      // in our for loop we check conditions if j >= interval, and the array[j- interval]
      //is greater than temp(arr[i])

      //after our first run through the loop, we decrement our 'i', if i is greater than
      // or equal to interval and array[j - interval] > temp, then we run the expression in our loop again
      //This means that we do another swap in our array, but this time we are backtracking
      //using our interval to compare backwards, we continously backtrck if after we decrement
      //our 'i', both conditions are true. The result is a coninous swap between the values
      for (j = i; j >= interval && array[j - interval] > temp; j -= interval) {
        //since both our condtion checks are true, arr[j], which is also arr[i], 
        //is now equal to arr[j-interval], which means that the original value of arr[j] 
        //is replaced by he value of arr[j-interval] which was less
        //the original value of arr[j] is still stored in temp, while arr[j-interval]
        //has taken it's place
        array[j] = array[j - interval];
      }
      
      //when our conitions in the 2nd forloop  are no lomnger met, we come
      //outside of the for loop, and  and the current value of array[j] is now temp
      //usually that takes care of the final swapping of the values, and
      //the original value that was replaced by arr[j-interval], is now placed
      //at the index where arr[j-interval]'s value used to be
      array[j] = temp;
    }
  }

}
// Print an array
void printArray(int array[], int size) {
  int i;
  for (i = 0; i < size; i++)
    cout << array[i] << " ";
  cout << endl;
}
