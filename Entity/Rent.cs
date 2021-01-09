namespace Entity
{
    public class Rent
    {
        public int book_id { get; set; }
        public int student_id { get; set; }
        public string start_date { get; set; }
        public string end_date_expected { get; set; }
        public string end_date { get; set; }
        public string debt { get; set; }
        public string process_type { get; set; }
    }
}
