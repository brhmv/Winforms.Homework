using System.Reflection;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Anket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void addNewPesonFile(Person person)
        {
            var json = JsonSerializer.Serialize(person);
            File.WriteAllText($"{person.Name}{person.Surname}.json", json);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                Person person = new();
                person.City = txtbox_city.Text;
                person.Country = txtbox_country.Text;
                person.Surname = txtbox_surname.Text;
                person.Phone = txtbox_phone.Text;
                person.Father = txtbox_father.Text;
                person.Name = txtbox_name.Text;
                person.bDate = dateTimePicker1.Value;

                if (rdbtn_male.Checked)
                    person.Gender = Gender.male;
                else
                    person.Gender = Gender.female;

                addNewPesonFile(person);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            try
            {
                var json = File.ReadAllText($"{txtbx_search.Text}{txtbox_searchsurname}.json");
                Person temp = JsonSerializer.Deserialize<Person>(json);

                txtbox_phone.Text = temp.Phone;
                txtbox_name.Text = temp.Name;
                txtbox_surname.Text = temp.Surname;
                txtbox_country.Text = temp.Country;
                txtbox_phone.Text = temp.Phone;
                txtbox_father.Text = temp.Father;
                txtbox_city.Text = temp.City;

                if (temp.Gender == Gender.male)
                    rdbtn_male.Checked = true;
                else
                    rdbtn_female.Checked = true;

                dateTimePicker1.Value=temp.bDate;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);            
                MessageBox.Show(ex.Message);
                
            }
        }

        private void txtbox_name_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new("^[a-zA-Z]{3,15}$");
            if (!regex.IsMatch(txtbox_name.Text))
            {
                txtbox_name.ForeColor = Color.Red;
                btn_save.Enabled = false;
            }
            else
            {
                txtbox_name.ForeColor = Color.Green;
                btn_save.Enabled = true;
            }
        }

        private void txtbox_phone_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new("^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$");
            if (!regex.IsMatch(txtbox_phone.Text))
            {
                txtbox_phone.ForeColor = Color.Red;
                btn_save.Enabled = false;
            }
            else
            {
                txtbox_phone.ForeColor = Color.Green;
                btn_save.Enabled = true;
            }
        }

        private void txtbox_surname_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new("^[a-zA-Z]{3,15}$");
            if (!regex.IsMatch(txtbox_surname.Text))
            {
                txtbox_surname.ForeColor = Color.Red;
                btn_save.Enabled = false;
            }
            else
            {
                txtbox_surname.ForeColor = Color.Green;
                btn_save.Enabled = true;
            }
        }

        private void txtbox_father_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new("^[a-zA-Z]{3,15}$");
            if (!regex.IsMatch(txtbox_father.Text))
            {
                txtbox_father.ForeColor = Color.Red;
                btn_save.Enabled = false;
            }
            else
            {
                txtbox_father.ForeColor = Color.Green;
                btn_save.Enabled = true;
            }
        }

        private void txtbox_country_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new("^[a-zA-Z]{3,15}$");
            if (!regex.IsMatch(txtbox_country.Text))
            {
                txtbox_country.ForeColor = Color.Red;
                btn_save.Enabled = false;
            }
            else
            {
                txtbox_country.ForeColor = Color.Green;
                btn_save.Enabled = true;
            }
        }

        private void txtbox_city_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new("^[a-zA-Z]{3,15}$");
            if (!regex.IsMatch(txtbox_city.Text))
            {
                txtbox_city.ForeColor = Color.Red;
                btn_save.Enabled = false;
            }
            else
            {
                txtbox_city.ForeColor = Color.Green;
                btn_save.Enabled = true;
            }
        }

        private void txtbx_search_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new("^[a-zA-Z]{3,15}$");
            if (!regex.IsMatch(txtbox_searchsurname.Text))
            {
                txtbox_searchsurname.ForeColor = Color.Red;
                btn_load.Enabled = false;
            }
            else
            {
                txtbox_searchsurname.ForeColor = Color.Green;
                btn_load.Enabled = true;
            }
        }

        private void txtbx_searchname_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new("^[a-zA-Z]{3,15}$");
            if (!regex.IsMatch(txtbx_search.Text))
            {
                txtbx_search.ForeColor = Color.Red;
                btn_load.Enabled = false;
            }
            else
            {
                txtbx_search.ForeColor = Color.Green;
                btn_load.Enabled = true;
            }
        }

    }
}