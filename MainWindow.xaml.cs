using Esri.ArcGISRuntime.Mapping;
using System.Diagnostics;
using System.Windows;

namespace agr_test_executable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private const string rbexe = "C:\\Windows\\System32\\Robocopy.exe";

        public MainWindow()
        {
            InitializeComponent();

        }

        #region Methods



        public void CopyFile()
        {
            try
            {
                Process.Start(rbexe, $"{Source_TextBox.Text} {Destination_TextBox.Text} {FileName_TextBox.Text}");
            }
            catch (System.Exception ex)
            {

                MessageBox.Show("Error", ex.Message, MessageBoxButton.OK);
            }

        }

        #endregion

        #region Events

        private void Copy_File_Click(object sender, RoutedEventArgs e)
        {
            CopyFile();
        }

        #endregion


    }
}
