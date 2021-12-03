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
            txtArray.Clear();
            
            radInsertion.Checked = false;
            radMerge.Checked = false;
            radShell.Checked = false;
            radInsertion.Checked = false;
            txtArraySize.Value = 5;

            


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
            //Check data
            if (radInsertion.Checked == false && radMerge.Checked == false && radShell.Checked == false && radQuick.Checked == false)
            {
                MessageBox.Show("Select at least one sort", "Error");
            }

            else
            {
                grpSetup.Visible = false;
                grpDisplay.Visible = true;
                int[] arr = txtArray.Text.Split(',').Select(int.Parse).ToArray();

                if (radInsertion.Checked == true)
                {
                    //init graph
                    lblSortName.Text = radInsertion.Text + " Sort";
                    chtMain.Series[0].Points.DataBindY(arr);
                    chtMain.ChartAreas[0].AxisX.LabelStyle.Enabled = false;

                    //sort
                    int i = 1;
                    int j = i;
                    int temp = 0;

                    string a = "1: Iterate from arr[1] to arr[n] over the array.";
                    string b = "2: Compare the current element(key) to its predecessor.";
                    string c = "3: If the key element is smaller than its predecessor, " +
                        "compare it to the elements before.Move the greater elements one position up to make space for the swapped element.";

                    for (i = 1; i < arr.Length; i++)
                    {
                        //txtOut.Text = a;

                        for (j = i; j > 0; j--)
                        {
                            ///txtOut.Text = b;

                            if (arr[j - 1] > arr[j])
                            {
                                //txtOut.Text = c;
                                temp = arr[j - 1];
                                arr[j - 1] = arr[j];
                                arr[j] = temp;
                                chartDisplay(arr);
                            }

                           
                            
                        }
                    }

                    chartDisplay(arr);
                }

            

                else if (radMerge.Checked == true)
                {
                    //init graph
                    lblSortName.Text = radMerge.Text + " Sort";
                    chtMain.Series[0].Points.DataBindY(arr);
                    chtMain.ChartAreas[0].AxisX.LabelStyle.Enabled = false;

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
                            sort( m + 1, r);

                            // Merge the sorted halves
                            merge(l, m, r);

                            chartDisplay(arr);

                        }
                    }
                }

                else if (radShell.Checked == true)
                {
                    //init graph
                    lblSortName.Text = radMerge.Text + " Sort";
                    chtMain.Series[0].Points.DataBindY(arr);
                    chtMain.ChartAreas[0].AxisX.LabelStyle.Enabled = false;

                    //sort

                }


                else
                {
                    //init graph
                    lblSortName.Text = radQuick.Text + " Sort";
                    chtMain.Series[0].Points.DataBindY(arr);
                    chtMain.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
                    //Quick_Sort(arr, 0, arr.Length - 1);

                }



            }

            
        }


        public void chartDisplay(int[] arr)
        {
            chtMain.Series[0].Points.DataBindY(arr);
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

        private void btnEnd_Click(object sender, EventArgs e)
        {
            frmMain_Load();
        }

    }

   
}
