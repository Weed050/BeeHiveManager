namespace BeeHiveManager
{
    public partial class Form1 : Form
    {
        private Queen queen;
        public Form1()
        {
            InitializeComponent();
            workerBeeJob.SelectedIndex = 1;
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Zbieranie nektaru", "Wytwarzanie miodu" });
            workers[1] = new Worker(new string[] { "Piel�gnacja jaj", "Uczenie pszcz�" });
            workers[2] = new Worker(new string[] { "Utrzymywanie ula", "Patrol z ��d�ami" });
            workers[3] = new Worker(new string[] { "Utrzymywanie ula", "Patrol z ��d�ami", "Piel�gnacja jaj", "Uczenie pszcz�", "Wytwarzanie miodu", "Zbieranie nektaru" });
            queen = new Queen(workers);
        }

        private void assignJob_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(workerBeeJob.Text, (int)Shifts.Value) == false)
                MessageBox.Show("Nie ma robotnic do wykoania '" + workerBeeJob.Text + "'", "Kr�lowa pszcz� m�wi...");
            else
                MessageBox.Show("Zadanie '" + workerBeeJob.Text + "' b�dzie uko�czone za " + Shifts.Value + " zmiany.", "Kr�lowa pszcz� m�wi...");
        }
        private void nextShift_Click(object sender, EventArgs e)
        {
            report.Text = queen.WorkTheNextShift();
        }
    }
}


