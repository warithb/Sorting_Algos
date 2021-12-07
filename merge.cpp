#include <iostream>
#include <random>
#include <cstdlib> 
#include <ctime> 
using namespace std;

void randomarrays();
void merge(int A[], int low, int high, int mid);
void mergeSort(int A[],int low, int high);

int size;

int main(){
    cout<< "How many numbers you want in the array?" << endl;
    cin >> size;
    int array[size];
 
    srand((unsigned)time(0)); 
        for(int i=0; i<size; i++){ 
            array[i] = (rand()%100)+1;
            cout << array[i] << endl;
        }

    int low =0;
    int high=size-1;
    mergeSort(array,low,high);
    for(int i=0;i<7;i++){
        cout<<array[i]<<endl;
    }
    return 0;

}

// Merge two subarrays together
void merge(int A[], int low, int high, int mid){
    //intializes the variable for low and high and mid value   
    int i, j, k, c[50];
    i = low;
    k= low;
    j = mid + 1;
    //While is less than or equal to mid and j is less than or equal to high
    while (i <= mid && j <= high)
    {
        //if the i value is less than the j value the 
        if (A[i] < A[j])
        {
            //
            c[k] = A[i];
            k++;
            i++;
        }
        else
        {
            c[k] = A[j];
            k++;
            j++;
        }
    }
    while (i <= mid)
    {
        c[k] = A[i];
        k++;
        i++;
    }
    while (j <= high)
    {
        c[k] = A[j];
        k++;
        j++;
    }
    for (i = low; i < k; i++)
    {
        A[i] = c[i];
    }
}
void mergeSort(int A[],int low, int high){

    if(low<high){

        int mid;
        mid= (low+high)/2;
        mergeSort(A,low,mid);
        mergeSort(A,mid+1,high);
        
        merge(A,low,high,mid);
    }
    return;
}