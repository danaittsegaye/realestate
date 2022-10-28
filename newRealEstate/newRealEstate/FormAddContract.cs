using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Forms
{
    public partial class FormAddContract : Form
    {
        private DatabaseCore core = new DatabaseCore();



        //
        private void maptoComboclientBox()
        {
            //comboBoxClient
            comboBoxClient.Items.Clear();
            DataSet table = core.RunTableFunction(new SqlCommand("select * from ListClients()"));

            int i = 0;
            while (table.Tables[0].Rows.Count > i)
            {
                comboBoxClient.Items.Add(table.Tables[0].Rows[i].ItemArray.GetValue(0).ToString()
                                         + "/" + table.Tables[0].Rows[i].ItemArray.GetValue(1).ToString()

                                         );
                i++;
            }
        }
        private void maptotype()
        {
            comboBoxType.Items.Clear();
            DataSet table = core.RunTableFunction(new SqlCommand("select * from ListContract_Type()"));

            int i = 0;
            while (table.Tables[0].Rows.Count > i)
            {
                comboBoxType.Items.Add(table.Tables[0].Rows[i].ItemArray.GetValue(0).ToString()
                                         + "/" + table.Tables[0].Rows[i].ItemArray.GetValue(1).ToString()

                );
                i++;
            }
        }
        private void maptoemployee()
        {
            comboBoxEmployee.Items.Clear();
            DataSet table = core.RunTableFunction(new SqlCommand("select id,first_name,last_name from EmployeeTableGetAll()"));

            int i = 0;
            while (table.Tables[0].Rows.Count > i)
            {
                comboBoxEmployee.Items.Add(table.Tables[0].Rows[i].ItemArray.GetValue(0).ToString()
                                       + "/" + table.Tables[0].Rows[i].ItemArray.GetValue(1).ToString()
                                       + "/" + table.Tables[0].Rows[i].ItemArray.GetValue(2).ToString()

                );
                i++;
            }
        }
        private void maptoclientOffered()
        {
            comboBoxClientOffered.Items.Clear();
            DataSet table = core.RunTableFunction(new SqlCommand("select id,client_offered from ListTransaction()"));

            int i = 0;
            while (table.Tables[0].Rows.Count > i)
            {
                comboBoxClientOffered.Items.Add(table.Tables[0].Rows[i].ItemArray.GetValue(0).ToString()
                                           + "/" + table.Tables[0].Rows[i].ItemArray.GetValue(1).ToString()

                );
                i++;
            }
        }
        private void maptoclientrequested()
        {
            comboBoxClientRequested.Items.Clear();
            DataSet table = core.RunTableFunction(new SqlCommand("select id,client_requested from ListTransaction()"));

            int i = 0;
            while (table.Tables[0].Rows.Count > i)
            {
                comboBoxClientRequested.Items.Add(table.Tables[0].Rows[i].ItemArray.GetValue(0).ToString()
                                                + "/" + table.Tables[0].Rows[i].ItemArray.GetValue(1).ToString()

                );
                i++;
            }
        }
        private void maptotransactionType()
        {
            comboBoxTransactionType.Items.Clear();
            DataSet table = core.RunTableFunction(new SqlCommand("select * from ListTransaction_Type()"));

            int i = 0;
            while (table.Tables[0].Rows.Count > i)
            {
                comboBoxTransactionType.Items.Add(table.Tables[0].Rows[i].ItemArray.GetValue(0).ToString()
                                                  + "/" + table.Tables[0].Rows[i].ItemArray.GetValue(1).ToString()

                );
                i++;
            }
        }
        private void maptoPaymentFrequency()
        {
            comboBoxPaymentFrequency.Items.Clear();
            DataSet table = core.RunTableFunction(new SqlCommand("select * from ListPayment_Frequency()"));

            int i = 0;
            while (table.Tables[0].Rows.Count > i)
            {
                comboBoxPaymentFrequency.Items.Add(table.Tables[0].Rows[i].ItemArray.GetValue(0).ToString()
                                                + "/" + table.Tables[0].Rows[i].ItemArray.GetValue(1).ToString()

                );
                i++;
            }
        }
        private void maptoEstate()
        {
            comboBoxEstateUnderContract.Items.Clear();

            DataSet table = core.RunTableFunction(new SqlCommand("select * from ListEstate()"));

            int i = 0;
            while (table.Tables[0].Rows.Count > i)
            {
                comboBoxEstateUnderContract.Items.Add(
                    table.Tables[0].Rows[i].ItemArray.GetValue(0).ToString() + "/" +
                    table.Tables[0].Rows[i].ItemArray.GetValue(1).ToString() + "/" +
                    table.Tables[0].Rows[i].ItemArray.GetValue(2).ToString() + "/" +
                    table.Tables[0].Rows[i].ItemArray.GetValue(3).ToString() + "/" +
                    table.Tables[0].Rows[i].ItemArray.GetValue(4).ToString() + "/" +
                    table.Tables[0].Rows[i].ItemArray.GetValue(5).ToString() + "/" +
                    table.Tables[0].Rows[i].ItemArray.GetValue(6).ToString() + "/" +
                    table.Tables[0].Rows[i].ItemArray.GetValue(7).ToString() + "/" +
                    table.Tables[0].Rows[i].ItemArray.GetValue(8).ToString() + "/" +
                    table.Tables[0].Rows[i].ItemArray.GetValue(9).ToString() + "/" +
                    table.Tables[0].Rows[i].ItemArray.GetValue(10).ToString() + "/" +
                    table.Tables[0].Rows[i].ItemArray.GetValue(11).ToString() + "/" +
                    table.Tables[0].Rows[i].ItemArray.GetValue(12).ToString()
                );
                i++;
            }

        }



        public FormAddContract()
        {
            InitializeComponent();
            maptoComboclientBox();
            maptotype();////
            maptoemployee();
            maptoclientOffered();///
            maptoclientrequested();///
            maptotransactionType();//
            maptoPaymentFrequency();/////
            maptoEstate();

        }

        private void btnAddConract_Click(object sender, EventArgs e)
        {
            try
            {
                getContract();
                clear();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            textBoxPaymentAmount.Text = "";
            textBoxFeePercentage.Text = "";
        }


        private void getContract()
        {
            try
            {
                String contracttype, offered, requested, transaction, freq;
                offered = comboBoxClientOffered.Text.ToString();
                requested = comboBoxClientRequested.Text.ToString();

                if (comboBoxType.SelectedItem != null && comboBoxTransactionType.SelectedItem != null && comboBoxPaymentFrequency.SelectedItem != null)
                {
                    contracttype = comboBoxType.SelectedItem.ToString();
                    offered = comboBoxClientOffered.Text.ToString();
                    requested = comboBoxClientRequested.Text.ToString();
                    transaction = comboBoxTransactionType.SelectedItem.ToString();
                    freq = comboBoxPaymentFrequency.SelectedItem.ToString();
                }
                else
                {
                    if (comboBoxType.SelectedItem == null)
                    {
                        int id = new Random().Next();
                        List<SqlParameter> p = new List<SqlParameter>();
                        p.Add(new SqlParameter("@id", id));
                        p.Add(new SqlParameter("@contract_type_name", comboBoxType.Text));
                        core.RunStored_Procedure("[SP_addContract_type]", p);
                        contracttype = id + "/" + comboBoxType.Text;
                    }
                    else
                    {
                        contracttype = comboBoxType.SelectedItem.ToString();
                    }

                    if (comboBoxPaymentFrequency.SelectedItem == null)
                    {
                        int id = new Random().Next();
                        List<SqlParameter> p = new List<SqlParameter>();
                        p.Add(new SqlParameter("@id", id));
                        p.Add(new SqlParameter("@Payment_Frequency", comboBoxPaymentFrequency.Text));
                        core.RunStored_Procedure("[SP_addPayment_Frequency]", p);
                        freq = id + "/" + comboBoxPaymentFrequency.Text;
                    }
                    else
                    {
                        freq = comboBoxPaymentFrequency.SelectedItem.ToString();
                    }

                    if (comboBoxTransactionType.SelectedItem == null)
                    {
                        int id = new Random().Next();
                        List<SqlParameter> p = new List<SqlParameter>();
                        p.Add(new SqlParameter("@id", id));
                        p.Add(new SqlParameter("@Transaction_type", comboBoxTransactionType.Text));
                        core.RunStored_Procedure("[SP_addTransaction_type]", p);
                        transaction = id + "/" + comboBoxTransactionType.Text;
                    }
                    else
                    {
                        transaction = comboBoxTransactionType.SelectedItem.ToString();
                    }
                }


                Contract contract = new Contract(
                    new Random().Next(),
                    int.Parse(comboBoxClient.SelectedItem.ToString().Substring(0, comboBoxClient.SelectedItem.ToString().IndexOf("/"))),
                    int.Parse(contracttype.Substring(0, contracttype.IndexOf("/"))),
                    int.Parse(comboBoxEmployee.SelectedItem.ToString().Substring(0, comboBoxEmployee.SelectedItem.ToString().IndexOf("/"))),
                    int.Parse(offered),
                    new Transaction(int.Parse(transaction.Substring(0, transaction.IndexOf("/"))), int.Parse(comboBoxClientOffered.Text), int.Parse(comboBoxClientRequested.Text), dateTimePickerTrasactionDate.Value, richTextBoxTrasactionDetail.Text),
                    dateTimePickerStartDate.Value,
                    richTextBoxTrasactionDetail.Text,
                    int.Parse(freq.Substring(0, freq.IndexOf("/"))),
                    int.Parse(textBoxPaymentAmount.Text),
                    int.Parse(textBoxFeePercentage.Text),
                    dateTimePickerDateSigned.Value,
                    dateTimePickerStartDate.Value,
                    dateTimePickerEndDate.Value,
                    int.Parse(comboBoxEstateUnderContract.SelectedItem.ToString().Substring(0, comboBoxEstateUnderContract.SelectedItem.ToString().IndexOf("/")))
                );
                Transaction t = new Transaction(int.Parse(transaction.Substring(0, transaction.IndexOf("/"))), int.Parse(comboBoxClientOffered.Text), int.Parse(comboBoxClientRequested.Text), dateTimePickerTrasactionDate.Value, richTextBoxTrasactionDetail.Text);

                try
                {
                    addContract(t, contract);
                }
                catch (Exception e)
                {
                    MessageBox.Show("sql error " + e.Message);
                }
            }
            catch (NullReferenceException e)
            {
                MessageBox.Show("please fill out all the fields" + e.Message);
            }
        }



        private void addContract(Transaction t, Contract contract)
        {

            //SP_addTransaction_
            int idd = new Random().Next();
            List<SqlParameter> ll = new List<SqlParameter>();
            ll.Add(new SqlParameter("@id", idd));
            ll.Add(new SqlParameter("@Transaction_type_id", t.TransactionTypeID));
            ll.Add(new SqlParameter("@client_offered", t.ClientOffered));
            ll.Add(new SqlParameter("@client_requested", t.ClientRequested));
            ll.Add(new SqlParameter("@transaction_date", t.TransactionDate));
            ll.Add(new SqlParameter("@transaction_details", t.TransactionDetail));

            core.RunStored_Procedure("[SP_addTransaction_]", ll);

            int estateid = new Random().Next();
            List<SqlParameter> j = new List<SqlParameter>();
            j.Add(new SqlParameter("@id", contract.ID));
            j.Add(new SqlParameter("@client_id", contract.ClientID));
            j.Add(new SqlParameter("@employee_id", contract.EmployeeID));
            j.Add(new SqlParameter("@contranct_type_id", contract.ContarctTypeID));
            j.Add(new SqlParameter("@payment_frequency_id", contract.PaymentFrequencyID));
            j.Add(new SqlParameter("@transaction_id", idd));
            j.Add(new SqlParameter("@payment_amount", contract.PaymentAmount));
            j.Add(new SqlParameter("@fee_percentage", contract.FeePercentage));
            j.Add(new SqlParameter("@fee_amount", contract.FeeAmount));
            j.Add(new SqlParameter("@date_signed", contract.DateSigned));
            j.Add(new SqlParameter("@start_date", contract.StartDate));
            j.Add(new SqlParameter("@end_date", contract.EndDate));
            core.RunStored_Procedure("[SP_addContract]", j);
        }
    }
}
