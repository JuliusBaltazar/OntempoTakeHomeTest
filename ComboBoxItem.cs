// ================================================================
// Module   : ComboBoxItem
// Author   : Julius Baltazar
// Date     : 17/09/2024
// ================================================================
// Revision History
// JLnnnnn | dd/mm/yyyy | Author | Change description
// ================================================================
// ================================================================


namespace OntempoTakeHomeTest
{
    public class ComboBoxItem
    {
        public int Id { get; set; }
        public string Label { get; set; }

        // Override ToString to customize the display text
        public override string ToString()
        {
            return Label;
        }
    }
}
