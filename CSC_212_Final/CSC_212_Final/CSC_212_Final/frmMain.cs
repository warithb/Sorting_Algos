using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace CSC_212_Final
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            grpDisplay.Visible = false;
            grpSetup.Visible = true;
            grpSortSelect.Visible = false;
            //txtArray.Clear();
            
            radInsertion.Checked = false;
            radMerge.Checked = false;
            radShell.Checked = false;
            radInsertion.Checked = false;
            txtArraySize.Value = 5;
            txtMax.Value = 1;
            txtTime.Clear();

            if (txtArray.Text != string.Empty)
            {
                grpSortSelect.Visible = true;
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain_Load(sender, e);
        }


        private void btnSort_Click_1(object sender, EventArgs e)
        {
            Form form = this;
            int[] arr = txtArray.Text.Split(',').Select(int.Parse).ToArray();


            //Check data
            if (radInsertion.Checked == false && radMerge.Checked == false && radShell.Checked == false && radQuick.Checked == false)
            {
                MessageBox.Show("Select at least one sort", "Error");
            }

            else
            {
                grpSetup.Visible = false;
                grpDisplay.Visible = true;
                

                if (radInsertion.Checked == true)
                {
                    

                    var insertionWatch = System.Diagnostics.Stopwatch.StartNew();

                    //init graph
                    lblSortName.Text = radInsertion.Text + " Sort";
                    chtMain.Series[0].Points.DataBindY(arr);
                    chtMain.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
                    long insertionTime;

                    //sort
                    int i = 1;
                    int j = i;
                    int temp = 0;


                    for (i = 1; i < arr.Length; i++)
                    {

                        for (j = i; j > 0; j--)
                        {

                            if (arr[j - 1] > arr[j])
                            {

                                temp = arr[j - 1];
                                arr[j - 1] = arr[j];
                                arr[j] = temp;
                                chartDisplay(ref arr);
                                insertionTime = insertionWatch.ElapsedMilliseconds;
                                txtTime.Text = $"Execution Time: {insertionTime / 1000} seconds";

                                chartDisplay(ref arr);
                                
                            }



                        }
                    }

                    chartDisplay(ref arr);
                    insertionWatch.Stop();
                    txtTime.Text = $"Time To Execute: {insertionWatch.ElapsedMilliseconds / 1000}.{insertionWatch.ElapsedMilliseconds % 1000} seconds";

                }



                else if (radMerge.Checked == true)
                {
                    //init graph
                    lblSortName.Text = radMerge.Text + " Sort";
                    chtMain.Series[0].Points.DataBindY(arr);
                    chtMain.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
                    var mergeWatch = System.Diagnostics.Stopwatch.StartNew();
                    long mergeTime;

                    //sort

                    sort(0, arr.Length - 1);


                    // Merges two subarrays of []arr.
                    // First subarray is arr[l..m]
                    // Second subarray is arr[m+1..r]
                    void merge(int l, int m, int r)
                    {
                        // Find sizes of two
                        // subarrays to be merged
                        int n1 = m - l + 1;
                        int n2 = r - m;

                        // Create temp arrays
                        int[] L = new int[n1];
                        int[] R = new int[n2];
                        int i, j;

                        // Copy data to temp arrays
                        for (i = 0; i < n1; ++i)
                            L[i] = arr[l + i];
                        for (j = 0; j < n2; ++j)
                            R[j] = arr[m + 1 + j];

                        // Merge the temp arrays

                        // Initial indexes of first
                        // and second subarrays
                        i = 0;
                        j = 0;

                        // Initial index of merged
                        // subarray array
                        int k = l;
                        while (i < n1 && j < n2)
                        {
                            if (L[i] <= R[j])
                            {
                                arr[k] = L[i];
                                i++;
                            }
                            else
                            {
                                arr[k] = R[j];
                                j++;
                            }
                            k++;
                        }

                        // Copy remaining elements
                        // of L[] if any
                        while (i < n1)
                        {
                            arr[k] = L[i];
                            i++;
                            k++;
                        }

                        // Copy remaining elements
                        // of R[] if any
                        while (j < n2)
                        {
                            arr[k] = R[j];
                            j++;
                            k++;
                        }

                    }

                    // Main function that
                    // sorts arr[l..r] using
                    // merge()
                    void sort(int l, int r)
                    {

                        if (l < r)
                        {
                            // Find the middle
                            // point
                            int m = l + (r - l) / 2;

                            // Sort first and
                            // second halves
                            sort(l, m);
                            sort(m + 1, r);

                            // Merge the sorted halves
                            merge(l, m, r);

                           
                            
                            mergeTime = mergeWatch.ElapsedMilliseconds;
                            txtTime.Text = $"Time to Execute: {mergeTime / 1000} seconds";
                        }
                    }

                    chartDisplay(ref arr);
                    mergeWatch.Stop();
                    txtTime.Text = $"Time To Execute: {mergeWatch.ElapsedMilliseconds / 1000}.{mergeWatch.ElapsedMilliseconds % 1000} seconds";
                }

                else if (radShell.Checked == true)
                {
                    //init graph
                    lblSortName.Text = radShell.Text + " Sort";
                    chtMain.Series[0].Points.DataBindY(arr);
                    chtMain.ChartAreas[0].AxisX.LabelStyle.Enabled = false;

                    //sort
                    int n = arr.Length;

                    // Start with a big gap,
                    // then reduce the gap
                    for (int gap = n / 2; gap > 0; gap /= 2)
                    {
                        // Do a gapped insertion sort for this gap size.
                        // The first gap elements a[0..gap-1] are already
                        // in gapped order keep adding one more element
                        // until the entire array is gap sorted
                        for (int i = gap; i < n; i += 1)
                        {
                            // add a[i] to the elements that have
                            // been gap sorted save a[i] in temp and
                            // make a hole at position i
                            int temp = arr[i];

                            // shift earlier gap-sorted elements up until
                            // the correct location for a[i] is found
                            int j;
                            for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                            {


                                arr[j] = arr[j - gap];
                                chartDisplay(ref arr);
                            }
                            // put temp (the original a[i])
                            // in its correct location
                            arr[j] = temp;
                            chartDisplay(ref arr);
                        }

                        chartDisplay(ref arr);
                    }

                }


                else
                {
                    //init graph
                    lblSortName.Text = radQuick.Text + " Sort";
                    chtMain.Series[0].Points.DataBindY(arr);
                    chtMain.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
                    

                    var  quickwatch = System.Diagnostics.Stopwatch.StartNew();
                    long quickTime;
                    QuickSort(0, arr.Length - 1);




                    //sort
                    void QuickSort(int start, int end)
                    {
                        chartDisplay(ref arr);

                        int i;
                        if (start < end)
                        {
                            i = Partition(start, end);

                            QuickSort(start, i - 1);
                            QuickSort(i + 1, end);
                        }
                    }

                    int Partition(int start, int end)
                    {
                        int temp;
                        int p = arr[end];
                        int i = start - 1;

                        for (int j = start; j <= end - 1; j++)
                        {
                            if (arr[j] <= p)
                            {
                                i++;
                                temp = arr[i];
                                arr[i] = arr[j];
                                arr[j] = temp;
                            }
                        }

                        temp = arr[i + 1];
                        arr[i + 1] = arr[end];
                        arr[end] = temp;
                        return i + 1;
                    }



                    quickwatch.Stop();
                    chartDisplay(ref arr);
                    quickTime = quickwatch.ElapsedMilliseconds;
                    chartDisplay(ref arr);
                    txtTime.Text = $"Time To Execute: {quickwatch.ElapsedMilliseconds / 1000}.{quickwatch.ElapsedMilliseconds % 1000} seconds";
                    

                }
            }
        }


        public void chartDisplay(ref int[] arr)
        {
            chtMain.Series[0].Points.DataBindY(arr);
            txtOut.Text = string.Join(",", arr);
            Task.Delay(1).GetAwaiter().GetResult();
   
        }





        static async Task delay()
        {
            await Task.Delay(1);
        }



        private void btnGenArray_Click(object sender, EventArgs e)
        {

            int[] arr = new int[Convert.ToInt32(txtArraySize.Value)];
            var rand = new Random();
            string o = string.Empty;
            //string sep = ", ";

            for (int i = 0; i < Convert.ToInt32(txtArraySize.Value); i++)
            {
                if (i == Convert.ToInt32(txtArraySize.Value) - 1)
                {
                    int temp = rand.Next(Convert.ToInt32(txtMin.Value), Convert.ToInt32(txtMax.Value));
                    //arr.Append(temp);
                    o += temp.ToString();
                }

                else
                {
                    int temp = rand.Next(Convert.ToInt32(txtMin.Value), Convert.ToInt32(txtMax.Value));
                    //arr.Append(temp);
                    o += temp.ToString() + ",";
                }

            }

            //txtArray.Visible = false;
            txtArray.Text = o;

            grpSortSelect.Visible = true;
            
        }


    }

   
}
