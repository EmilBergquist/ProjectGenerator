using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace ProjektGenerator_Test1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            loadSettings();

        }

        private void openSettingsWindow_Click(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings();

            settings.openSettingsWindow();

            
        } //Opens the settings window.

        private void DirectoryDialog_Click(object sender, RoutedEventArgs e)
        {
            DirectoryDialog dialog = new DirectoryDialog();
            textBoxPathToNewProject.Text = dialog.GetDirectoryFromUser();
        } //Gets a destiny for the new project from the user.

        private void buttonGenerateProject_Click(object sender, RoutedEventArgs e)
        {
            saveSettings();
            copyDirectory();

            //Code to call methods where the project is generated.


            Application.Current.Shutdown();
        } // Generates the project and saves settings. Then closes the app.

        private void buttonExecution_Click(object sender, RoutedEventArgs e)
        {
            copyDirectory();
            saveSettings();
        } //Just generates the project and saves settings without closing the app.

        private void buttonExitApp_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        } //Closes the app without saving och generate a project.

        private void saveSettings()
        {
            Properties.Settings.Default.ProjectManager = textBoxProjectManager.Text;
            Properties.Settings.Default.ProjectManagerPhoneNr = textBoxProjectManagerPhone.Text;
            Properties.Settings.Default.PathToNewProject = textBoxPathToNewProject.Text;
            Properties.Settings.Default.Save();
        } //Function to save settings for next time use.

        private void loadSettings()
        {
            textBoxProjectManager.Text = Properties.Settings.Default.ProjectManager;
            textBoxProjectManagerPhone.Text = Properties.Settings.Default.ProjectManagerPhoneNr;
            textBoxPathToNewProject.Text = Properties.Settings.Default.PathToNewProject;
        } // Loads settings from last time use.

        private void copyDirectory()
        {
            string newPath = textBoxPathToNewProject.Text + @"\" + textBoxProjectNumber.Text + " " + textBoxProjectName.Text;
            System.Windows.Forms.MessageBox.Show(newPath);
            string sourcePath = @"server/Mallar/Mappstruktur Projekt Entreprenad med mallar";


            CopyDirs.Copy(sourcePath, newPath);
        } //Copy the directorys. THIS FUNCTION SHOULD BE CHANGED. New Directorys shoud be generated from TreeView instead of being copyd.
          //What happends if there are a project with the same name already?
    }
}
