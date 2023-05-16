using System;
using System.Data;
class Program
{
    static void Main()
    {
        // Step 1: get the DataTable.
        DataTable table = GetTable();

        // Step 4: print the first cell.
        Console.WriteLine("{0}  {1}  {2}  {3}",table.Columns[0], table.Columns[1] ,table.Columns[2], table.Columns[3]);
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("");
        Console.WriteLine("  {0}   {1}  {2}  {3}", table.Rows[0]["Dosage"], table.Rows[0]["Drug"], table.Rows[0]["Diagnosis"], table.Rows[0]["Date"]);
        Console.WriteLine("  {0}   {1}  {2}  {3}", table.Rows[1]["Dosage"], table.Rows[1]["Drug"], table.Rows[1]["Diagnosis"], table.Rows[1]["Date"]);
        Console.WriteLine("  {0}   {1}  {2}  {3}", table.Rows[2]["Dosage"], table.Rows[2]["Drug"], table.Rows[2]["Diagnosis"], table.Rows[2]["Date"]);
        Console.WriteLine("  {0}   {1}  {2}  {3}", table.Rows[3]["Dosage"], table.Rows[3]["Drug"], table.Rows[3]["Diagnosis"], table.Rows[3]["Date"]);
    }
//table input
    static DataTable GetTable()
    {
        
        DataTable table = new DataTable();
        table.Columns.Add("Dosage", typeof(int));
        table.Columns.Add("Drug", typeof(string));
        table.Columns.Add("Diagnosis", typeof(string));
        table.Columns.Add("Date", typeof(DateTime));

        
        table.Rows.Add(25, "Drug A", "Disease A", DateTime.Now);
        table.Rows.Add(50, "Drug Z", "Problem Z", DateTime.Now);
        table.Rows.Add(10, "Drug Q", "Disorder Q", DateTime.Now);
        table.Rows.Add(21, "Medicine A", "Diagnosis A", DateTime.Now);
        return table;
    }
}
