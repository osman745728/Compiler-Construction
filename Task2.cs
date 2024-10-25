private void btnInsert_Click(object sender, EventArgs e)
{
    // Insert values into the DataGridView
    string inputValue = txtInput.Text; // Get value from TextBox
    dataGridView.Rows.Add(inputValue); // Add a new row with the input value
    txtInput.Clear(); // Clear the input field after adding the value
}
