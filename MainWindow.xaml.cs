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




namespace ToDoList
{
    public class TextCheckBox
    {
        public TextBox textBox;
        public CheckBox checkBox;

        public bool completed = false;

        public TextCheckBox()
        {
            textBox = new TextBox();
            checkBox = new CheckBox();
        }
    }
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddTask_Click(object sender, RoutedEventArgs e)
        {
    
            TextCheckBox tCB = new TextCheckBox();
            tCB.textBox.Text = "Type here";
            tCB.textBox.Width = 300;
          
            List.Items.Add(tCB.textBox);
           tCB.checkBox.Margin = new Thickness(0,6.8f,0,0);
            checkBoxList.Items.Add(tCB.checkBox);
            
            MessageBoxButton mBBTN = MessageBoxButton.YesNo;
            string caption = "Add Task";
            MessageBoxImage mBIcon = MessageBoxImage.Asterisk;
            MessageBoxResult mBResult = MessageBoxResult.Yes;
            mBResult = MessageBox.Show("Task added, do you want to add another task?", caption, mBBTN, mBIcon, mBResult);
            
            switch (mBResult)
            {
                case MessageBoxResult.Yes:
                    AddTask_Click(sender, e);
                    break;
                case MessageBoxResult.No:
                    break;
            }
        }
    }
}
