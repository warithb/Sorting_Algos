
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
 //Random number Generator
    srand((unsigned)time(0)); 
        for(int i=0; i<size; i++){ 
            array[i] = (rand()%100)+1;
            cout << array[i] << endl;
        }

    int low =0;
    int high=size-1;
    mergeSort(array,low,high);
    cout<<"Sorted List";
    for(int i=0;i<size;i++)
    {
        cout<<array[i]<<" ";
    }
    return 0;
}

using namespace std;
int Merge(int A[],int p, int q,int r)     
{

    int n1,n2,i,j,k; 
    //size of left array=n1
    //size of right array=n2       
    n1=q-p+1;
    n2=r-q;             
    int L[n1],R[n2];
    //initializing the value of Left part to L[]
    for(i=0;i<n1;i++)
    {
        L[i]=A[p+i];
    }
    //initializing the value of Right Part to R[]
    for(j=0;j<n2;j++)
    {
        R[j]=A[q+j+1];
    }
    i=0,j=0;
    //Comparing and merging them
    //into new array in sorted order 
    for(k=p;i<n1&&j<n2;k++)
    {
        if(L[i]<R[j])
        {
            A[k]=L[i++];
        }
        else
        {
            A[k]=R[j++];
        }
    }
    //If Left Array L[] has more elements than Right Array R[]
    //then it will put all the
    // reamining elements of L[] into A[]
    while(i<n1)             
    {
        A[k++]=L[i++];
    }
    //If Right Array R[] has more elements than Left Array L[]
    //then it will put all the
    // reamining elements of L[] into A[]
    while(j<n2)
    {
        A[k++]=R[j++];
    }
}
//This is Divide Part
//This part will Divide the array into 
//Sub array and then will Merge them
//by calling Merge()
int MergeSort(int A[],int p,int r)    
{
    int q;                                
    if(p<r)
    {
        q=(p+r)/2;
        MergeSort(A,p,q);
        MergeSort(A,q+1,r);
        Merge(A,p,q,r);
    }
}
