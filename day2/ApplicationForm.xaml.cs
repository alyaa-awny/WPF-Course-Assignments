using System.Windows;

namespace day2
{
    /// <summary>
    /// Interaction logic for ApplicationForm.xaml
    /// </summary>
    public partial class ApplicationForm : Window
    {
        public ApplicationForm()
        {
            InitializeComponent();
        }



        private void Cancle_Click(object sender, RoutedEventArgs e)
        {

            ClearValue();
        }

        private void ClearValue()
        {
            textBoxFirstName.Text = "";
            textBoxEmail.Text = "";
            textBoxLastName.Text = "";
            textBoxGender.Text = "";
            textBoxPhone.Text = "";
            textBoxJobtitle.Text = "";
            textBoxMobile.Text = "";
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"First name: {textBoxFirstName.Text} \n Last name:{textBoxLastName.Text} \n " +
                $"Phone: {textBoxPhone.Text}\n " +
                $"Mobile: {textBoxMobile.Text}\n" +
                $"Email: {textBoxEmail.Text}\n" +
                $"Gender: {textBoxGender.Text}\n" +
                $"Jobtitle:{textBoxJobtitle.Text} ");
            MessageBox.Show("Data Saved Successfully");

        }
    }
}
