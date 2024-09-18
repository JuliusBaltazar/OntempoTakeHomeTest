// ================================================================
// Module   : Region
// Author   : Julius Baltazar
// Date     : 17/09/2024
// ================================================================
// Revision History
// JLnnnnn | dd/mm/yyyy | Author | Change description
// ================================================================
// ================================================================

using System.Collections.Generic;

namespace OntempoTakeHomeTest
{
    public class Region
	{        
        public int Id { get; set; }
     
        public string Name { get; set; }
        
        public List<Branch> Branches { get; set; } = new List<Branch>();
	}
}
