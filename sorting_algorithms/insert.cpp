#include<iostream>
using namespace std;

//insertion sort function
void insertionSort(int arr[])
{
    //declare variable j and set to 0
    //this variable is used to be the position in the array
    int j = 0;
    //declare temp variable and set to 0
    // this variable is used for the value at a position
    int temp = 0;

    //Increment i to 1
    //outter for loop loops the length of the array
    //for example I set i<6 to loop through the 6 elements
    for(int i=1; i<6; i++)
    {
        //set temp variable to the [i] position of the array
        temp = arr[i];
        //j = i - 1 moves one position back one
        j = i - 1;
        //The inner while loop makes the compairsons
        //j>=0 so the loop doesn't go out of bounds to the left
        //if position[j] is greater than temp then it will do swaps until it is sorted
        while(j>=0 && arr[j]>temp)
        {
            //this line of code puts the larger number takes the place of the smaller number in the position of the array
            arr[j+1] = arr[j];
            /*decrements to make comparisons untill there is a condition where the interger being compared is lesser than 
            what is being compared or it is at position 0 of the array
            */
            j = j - 1;
        }
        //updates the smallest value in correct postion
        //After this line it will cause the for loop to run and this proccess will repeat til the list is fully sorted
        arr[j+1] = temp;
    }
}

//main function
int main()
{
    //for example I passed in 6 intergers into the array
    int myarray[6];
    //asks for 6 intergers to pass in array
    cout<<"Enter 6 intergers: "<<endl;
    for(int i = 0; i<6; i++)
    {
        cin>>myarray[i];
    }


    cout<<"unsorted: "<<endl;
    for(int i = 0; i<6; i++)
    {
        cout<<myarray[i]<<" ";
    }

    //calls function
    insertionSort(myarray);

    //prints out sorted array
    cout<<"sorted: "<<endl;
    for(int i = 0; i<6; i++)
    {
        cout<<myarray[i]<<" ";
    }

    return 0;
}