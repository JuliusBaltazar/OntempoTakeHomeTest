// ================================================================
// Module   : Main
// Author   : Julius Baltazar
// Date     : 17/09/2024
// ================================================================
// Revision History
// JLnnnnn | dd/mm/yyyy | Author | Change description
// ================================================================
// ================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OntempoTakeHomeTest
{
    public partial class Main : Form
	{
        #region Declarations
        private RegionList regionList = new RegionList();
        private const int colID = 0;
        private const int colName = 1;
        #endregion Declarations

        #region Constructor        
        public Main()
		{
			InitializeComponent();
		}
        #endregion Constructor

        #region Methods
        #region Private Methods
        #region LoadRegionsData
        /// <summary>
        /// Load the regions data from data.json file from application path
        /// </summary>
        private void LoadRegionsData()
        {
            string appPath = AppContext.BaseDirectory;
            regionList = Helper.LoadDataFromJsonFile($@"{appPath}\data.json");
        }
        #endregion LoadRegionsData

        #region InitialiseRegionControl
        /// <summary>
        /// Initialise the Region Control
        /// </summary>
        private void InitialiseRegionControl()
        {
            if (regionList == null) return;
            if (regionList.Regions == null) return;

            // Create a list of ComboBoxItem
            var comboBoxItems = new List<ComboBoxItem>();

            //Populate the region to ComboBoxItem list
            regionList.Regions?
                .ForEach(region => comboBoxItems.Add(new ComboBoxItem() { Id = region.Id, Label = region.Name }));

            // Set the DataSource
            cboRegion.DataSource = comboBoxItems;

            // Set DisplayMember to show the Label property
            cboRegion.DisplayMember = "Label";
        }
        #endregion InitialiseRegionControl

        #region InitialiseGridControl
        /// <summary>
        /// Initialise the grid control
        /// </summary>
        private void InitialiseGridControl()
        {
            lblBranches.Text = string.Empty;
            grdBranches.ColumnCount = 2;
            grdBranches.Columns[colID].Name = "ID";
            grdBranches.Columns[colID].Width = 50;
            grdBranches.Columns[colName].Name = "Name";
            grdBranches.Columns[colName].Width = 250;
        }
        #endregion InitialiseGridControl

        #region GetBranches
        /// <summary>
        /// Get the branches based on region ID 
        /// </summary>
        /// <param name="iD"></param>
        private List<Branch> GetBranches(int iD)
        {
            var result = new List<Branch>();
            if (regionList == null) return result;
            if (regionList.Regions == null) return  result;

            var region = regionList.Regions.FirstOrDefault(i=> i.Id == iD);
            if (region == null) return result;
            result = region.Branches;

            return result;
        }
        #endregion GetBranches

        #region PopulateGrid
        /// <summary>
        /// Populate the grid controls with branches data
        /// </summary>
        /// <param name="branches"></param>
        private void PopulateGrid(List<Branch> branches)
        {
            grdBranches.Rows.Clear();
            if (branches == null) return;
            branches.ForEach(branch => grdBranches.Rows.Add(branch.Id, branch.Name));
        }
        #endregion PopulateGrid

        #endregion Private Methods


        #endregion Methods

        #region Form Events
        private void Main_Load(object sender, System.EventArgs e)
        {
            this.LoadRegionsData();
            this.InitialiseRegionControl();
            this.InitialiseGridControl();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var selectedItem = (ComboBoxItem)cboRegion.SelectedItem;
            var branch = this.GetBranches(selectedItem.Id);
            lblBranches.Text = $"{selectedItem.Label} Retail Branches";
            this.PopulateGrid(branch);
        }
        #endregion Form Events
    }
}
