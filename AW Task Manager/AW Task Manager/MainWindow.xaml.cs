using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.ObjectModel;
using System.ComponentModel;


namespace AW_Task_Manager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region List Collections
        ObservableCollection<Process> ListOfProcesses = new ObservableCollection<Process>();
        /// <summary>
        /// Return the list of processes to the ProcessesListView
        /// </summary>
        public ObservableCollection<Process> _Processes
        {
            get
            {
                return ListOfProcesses;
            }
        }
        #endregion

        #region Methods

        /// <summary>
        /// Updates the list of processes
        /// </summary>
        private void UpdateProcessList()
        {
            ProcessesListView.ItemsSource = null; // Reset the binding of the item source
            ListOfProcesses.Clear(); // Clear the list of processes
            bool AddProcess = false;

            // Create a list of processes
            foreach (Process process in Process.GetProcesses())
            {
                AddProcess = false;
                if (UnRespondingProcessesRadioBttn.IsChecked == true) // if check for unresponding processes check box is checked
                {
                    if (process.Responding == false) // if the process is unresponding then add it to the list view
                    {
                        AddProcess = true;
                    }
                }
                else
                {
                    AddProcess = true;
                }

                if (AddProcess == true)
                {
                    if (ProgramOpenCheckBox.IsChecked == true && process.MainWindowTitle != "")
                    {
                        ListOfProcesses.Add(process);
                    }
                    else if (ProgramOpenCheckBox.IsChecked == false)
                    {
                        ListOfProcesses.Add(process);
                    }
                }

            }

            // Assign the process list view item source to the process list
            ProcessesListView.ItemsSource = ListOfProcesses;
            ProcessesListView.Items.SortDescriptions.Add(new SortDescription("ProcessName", ListSortDirection.Ascending)); // order the list view according to ID
        }

        /// <summary>
        /// Find process via the search text entered
        /// </summary>
        /// <param name="SearchTextLength">The length of the search text</param>
        /// <param name="SearchText">The actual search text</param>
        private void FindProcess(int SearchTextLength, string SearchText)
        {

            int PointerProcessName, PointerSearchText; // Step through the strings
            bool AddToList = false; // If the process name has those letters
            int CheckLength = 0;
            string ProcessString;

            ProcessesListView.ItemsSource = null; // Reset the binding of the item source
            ListOfProcesses.Clear(); // Clear the list of processes

            foreach (Process _Process in Process.GetProcesses()) // loop through the Processes
            {
                PointerProcessName = 0;
                PointerSearchText = 0;

                if (ProgramOpenCheckBox.IsChecked == true)
                {
                    ProcessString = _Process.MainWindowTitle;
                }
                else
                {
                    ProcessString = _Process.ProcessName;
                }

                AddToList = false;
                while (PointerProcessName < ProcessString.Length && PointerSearchText < SearchTextLength)
                {
                    if (ProcessString[PointerProcessName].ToString().ToUpper() == SearchText[PointerSearchText].ToString().ToUpper())
                    {
                        if (PointerSearchText == 0) // found and start checking equals from here
                        {
                            CheckLength = SearchTextLength + PointerProcessName;
                            if (CheckLength > ProcessString.Length)// check that the name can take the search text length
                            {
                                AddToList = false;
                                break;
                            }
                        }
                        AddToList = true; // Add process after looping through
                        // increment counters to search further
                        PointerProcessName += 1;
                        PointerSearchText += 1;
                    }
                    else if (AddToList == true) // If previously matched but now doesnt the break and dont add
                    {
                        PointerSearchText = 0;
                        AddToList = false;
                    }
                    else if (AddToList == false) // if has not found yet then keep checking
                    {
                        PointerProcessName += 1;
                    }
                }

                if (AddToList == true) // If the process Name Has those letters in that order then add them to the listview
                {
                    ListOfProcesses.Add(_Process); // Add the Process to the collection used for the listview
                }
            }

            ProcessesListView.ItemsSource = ListOfProcesses;

            // Check if a process has been found, if "no" then display a red label
            if (ListOfProcesses.Count == 0)
            {
                FindProcessLB.Foreground = Brushes.Red;
            }
            else
            {
                FindProcessLB.Foreground = Brushes.Black;
                ProcessesListView.Items.SortDescriptions.Add(new SortDescription("ProcessName", ListSortDirection.Ascending)); // order the list view according to ID
            }
        }

        #endregion

        #region Window Controls

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RefreshProcessListRadioBttn.IsChecked = true;
            ProgramOpenCheckBox.IsChecked = true;
            UpdateProcessList(); // Load the process List

        }

        private void RefreshProcessListRadioBttn_Click(object sender, RoutedEventArgs e)
        {
            UpdateProcessList(); // Update the process List
        }

        private void UnRespondingProcessesRadioBttn_Click(object sender, RoutedEventArgs e)
        {
            UpdateProcessList(); // Update the process List with constraints
        }

        private void KillProcessBttn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (ProcessesListView.SelectedIndex >= 0) // if there is an item selected in the gallery list view 
                {
                    Process _SelectedProcess = null;
                    _SelectedProcess = (dynamic)ProcessesListView.SelectedItems[0]; // set the artwork reference to the art selected

                    if (MessageBox.Show("Are You Sure?", "Kill Process", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                    {
                        ProcessesListView.SelectedItem = null;
                    }
                    else
                    {
                        _SelectedProcess.Kill();
                        UpdateProcessList();
                    }
                }
                else
                {
                    MessageBox.Show("Please Select a Process to Kill");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void ProgramOpenCheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (ProgramOpenCheckBox.IsChecked == true)
            {
                ProcessNameColumn.DisplayMemberBinding = new Binding("MainWindowTitle");
            }
            else
            {
                ProcessNameColumn.DisplayMemberBinding = new Binding("ProcessName");
            }
            UpdateProcessList();
        }

        #region FindProcess

        private void FindProcessTxt_GotFocus(object sender, RoutedEventArgs e)
        {
            FindProcessTxt.Text = ""; // Clear the process Name text box
        }

        private void FindProcessTxt_LostFocus(object sender, RoutedEventArgs e)
        {
            if (FindProcessTxt.Text == "") // reset the process search text box if its blank
            {
                FindProcessTxt.Text = "Name of Process";
            }
        }

        private void FindProcessTxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            string SearchText = FindProcessTxt.Text;
            if (SearchText != "" && SearchText != "Name of Process")
            {
                FindProcess(SearchText.Length, SearchText); // Find Process
            }
            else if (ProgramOpenCheckBox != null)
            {
                RefreshProcessListRadioBttn.IsChecked = true;
                UpdateProcessList(); // Update the process List
            }

        }

        #endregion

        #endregion

        

    }
}
