Sort Algorithm Time & Visualization Tool

Description
A tool, that can either be used to time, or visualize insertion, shell, merge, and quick sorting algorithms. 
The program allows users to create random, sorted, or reverse arrays of variable lengths. 
It is a Microsoft Forms application written in C# as a final project for CSC-212 at the University of Rhode Island.

Usage
The user will be greeted with an option to build an array. To do so, an array length, array maximum value, 
and minimum values must be entered by typing or scrolling on the 3 numeric drop-down selection boxes. After clicking the “Generate Array” button.

![alt text](https://github.com/warithb/Sorting_Algos/blob/main/images/genArray.PNG?raw=true)


If all data is valid, the text box to the right of the option will display the array. Also, a chart will appear to show the values visually as well. 
From here the user should select whether or not they want to visualize the sort, but checking or unchecking the box labeled visualizer. 
Visualization works best on smaller array sets, so this feature was added in case you want to time a sort on a large set. Once a valid array is generated, 
and a visual option is selected, the user can choose which sort they want to run on the set by clicking one of the labeled radio buttons. 

![alt text](https://github.com/warithb/Sorting_Algos/blob/main/images/selectSort.PNG?raw=true)

There will also be a text box with elapsed time in seconds counting up until the sort is displayed. Visualization will affect this time heavily, 
so to test the sorts alone, uncheck visualization. When “Sort!” is clicked, this entire menu is replaced with a chart either displaying visuals for the sort, or just the sorted array on a chart. After the sort completes, from the file menu at the top right, the user can click the back button. This will bring you back to the home menu, where your unsorted array saves in the case you select/deselect the visualization button, or switch to a different so to compair times.


![alt text](https://github.com/warithb/Sorting_Algos/blob/main/images/viewSort.PNG?raw=true)

Sorts were written in C++ for team research purposes (as this was the language used in class), and converted to C# for ease of GUI design.  

Authors
Andre Savage, Warith Balogun, Ade Abujade, Cody Chu
